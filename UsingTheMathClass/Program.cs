using System;

namespace UsingTheMathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            double myNumber = 3.1234;
            double yourNumber = 5.6789;
            double aDouble = 81;
            double aNegativeNum = -5;

            Console.WriteLine($"Ceiling \"3.1234\": {Math.Ceiling(myNumber)}");
            Console.WriteLine($"Floor \"3.1234\": {Math.Floor(myNumber)}");
            Console.WriteLine($"Round \"3.1234\": {Math.Round(myNumber)}");
            Console.WriteLine($"Round \"5.6789\": {Math.Round(yourNumber)}");
            Console.WriteLine($"Min(3.1234, 5.6789): {Math.Min(myNumber, yourNumber)}");
            Console.WriteLine($"Max(3.1234, 5.6789): {Math.Max(myNumber, yourNumber)}");
            Console.WriteLine($"Square root of 81: {Math.Sqrt(aDouble)}");
            Console.WriteLine($"Cube root of 81: {Math.Cbrt(aDouble)}");
            Console.WriteLine($"Absolute value of \"-5\": {Math.Abs(aNegativeNum)}");

        }
    }
}
