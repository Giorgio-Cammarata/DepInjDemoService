using DIdemoLibrary;
using System;

namespace DIdemoConsole
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(Exception exception)
        {
            LogError(exception.Message);
        }

        public void LogError(string error)
        {
            ConsoleColor color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(error);

            Console.ForegroundColor = color;
        }             

        public void LogInfo(string info)
        {
            ConsoleColor color = System.Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine(info);

            Console.ForegroundColor = color;
        }
    }
}
