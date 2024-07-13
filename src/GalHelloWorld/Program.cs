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
            Console.WriteLine($"Hello World! Time is: {dateTimeString}");
        }
    }
}
