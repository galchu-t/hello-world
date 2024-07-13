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
            PrintByColor($"Goodbye!", GetRandomEnumValue<ConsoleColor>());
        }

        private static void PrintByColor(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static T GetRandomEnumValue<T>() where T: Enum
        {
            Array values = Enum.GetValues(typeof(T));
            Random random = new Random();
            T randomValue = (T)values.GetValue(random.Next(values.Length));
            return randomValue;
        }
    }
}
