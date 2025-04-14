using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            Console.WriteLine($"Logs will be saved in: {logFilePath}");
            Console.WriteLine();

            FileLoggerAdapter fileLogger = new FileLoggerAdapter(logFilePath);

            fileLogger.Log("The program is running");
            fileLogger.Warn("This is a warning");
            fileLogger.Error("This is an error message");

            Console.WriteLine();
            Console.WriteLine($"The logs are saved to a file. Check the file: {logFilePath}");
            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }
    }
}
