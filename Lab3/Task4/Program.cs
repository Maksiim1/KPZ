using System;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CreateSampleFiles();

                Console.WriteLine("=== SmartTextReader Direct Usage ===");
                ISmartTextReader reader = new SmartTextReader();
                char[][] content = reader.ReadFile("sample.txt");
                PrintContent(content);

                Console.WriteLine("\n=== SmartTextChecker (Logging Proxy) ===");
                ISmartTextReader loggedReader = new SmartTextChecker();
                content = loggedReader.ReadFile("sample.txt");
                PrintContent(content);

                Console.WriteLine("\n=== SmartTextReaderLocker (Access Control Proxy) ===");
                ISmartTextReader restrictedReader = new SmartTextReaderLocker(@".*restricted.*\.txt");

                Console.WriteLine("Trying to access allowed file:");
                content = restrictedReader.ReadFile("sample.txt");
                PrintContent(content);

                Console.WriteLine("\nTrying to access restricted file:");
                content = restrictedReader.ReadFile("restricted.txt");
                if (content != null)
                {
                    PrintContent(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static void PrintContent(char[][] content)
        {
            if (content == null) return;

            Console.WriteLine("Content read:");
            foreach (char[] line in content)
            {
                Console.WriteLine(new string(line));
            }
        }

        static void CreateSampleFiles()
        {
            File.WriteAllText("sample.txt", "Hello, World!\nThis is a test file.\nFor proxy pattern demonstration.");

            File.WriteAllText("restricted.txt", "This is restricted content.\nAccess should be denied.");
        }
    }
}