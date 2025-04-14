using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextChecker : ISmartTextReader
    {
        private readonly SmartTextReader _reader;

        public SmartTextChecker()
        {
            _reader = new SmartTextReader();
        }

        public char[][] ReadFile(string filePath)
        {
            Console.WriteLine($"[LOG] Opening file: {filePath}");

            try
            {
                char[][] content = _reader.ReadFile(filePath);

                int totalLines = content.Length;
                int totalChars = 0;

                foreach (char[] line in content)
                {
                    totalChars += line.Length;
                }

                Console.WriteLine($"[LOG] Successfully read file: {filePath}");
                Console.WriteLine($"[LOG] Total lines: {totalLines}");
                Console.WriteLine($"[LOG] Total characters: {totalChars}");
                Console.WriteLine($"[LOG] Closing file: {filePath}");

                return content;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Failed to read file: {ex.Message}");
                throw;
            }
        }
    }
}
