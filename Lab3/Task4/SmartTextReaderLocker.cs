using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task4
{
    public class SmartTextReaderLocker : ISmartTextReader
    {
        private readonly SmartTextReader _reader;
        private readonly Regex _restrictionPattern;

        public SmartTextReaderLocker(string restrictionPattern)
        {
            _reader = new SmartTextReader();
            _restrictionPattern = new Regex(restrictionPattern);
        }

        public char[][] ReadFile(string filePath)
        {
            if (_restrictionPattern.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return null;
            }

            return _reader.ReadFile(filePath);
        }
    }

}
