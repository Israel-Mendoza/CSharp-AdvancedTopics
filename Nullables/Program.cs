using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;

            double? d1 = new double?();
            double? d2 = 3.141592;

            bool? myBool = null;

            Console.WriteLine($"My nullable values are '{num1}', '{num2}', '{d1}', '{d2}', and '{myBool}'");

            DisplayGender(myBool);

            bool validGender = myBool ?? false;

            Console.WriteLine($"A valid gender: {validGender}");
        }

        static void DisplayGender(bool? isMale)
        {
            if (isMale == true) Console.WriteLine("Gender chosen: Male");
            else if (isMale == false) Console.WriteLine("Gender chosen: Female");
            else Console.WriteLine("Gender not specified...");
        }
    }
}
