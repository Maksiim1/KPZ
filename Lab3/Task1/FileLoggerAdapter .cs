using System;

namespace Task1
{
    public class FileLoggerAdapter : Logger
    {
        private readonly FileWriter _fileWriter;

        public FileLoggerAdapter(string filePath)
        {
            _fileWriter = new FileWriter(filePath);
        }

        public new void Log(string message)
        {
            base.Log(message);
            _fileWriter.WriteLine($"LOG: {message}");
        }

        public new void Error(string message)
        {
            base.Error(message);
            _fileWriter.WriteLine($"ERROR: {message}");
        }

        public new void Warn(string message)
        {
            base.Warn(message);
            _fileWriter.WriteLine($"WARNING: {message}");
        }
    }
}
