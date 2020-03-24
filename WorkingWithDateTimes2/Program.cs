using System;
using System.Globalization;

namespace WorkingWithDateTimes2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = new DateTime(1992, 04, 9, 9, 54, 0);

            Console.WriteLine($"Esta es la fecha en la que nací: {now.ToString("D", new CultureInfo("es-MX"))}");

        }
    }
}
