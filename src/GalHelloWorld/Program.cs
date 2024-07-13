using System;
using System.Globalization;

namespace GalHelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var dateTime = DateTime.Now;
            var dateTimeString = string.Format(new CultureInfo("en-US"), "{0:F}", dateTime);

            PrintByColor($"Hello World! Time is: {dateTimeString}", ConsoleColor.Green);
        }

        private static void PrintByColor(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
