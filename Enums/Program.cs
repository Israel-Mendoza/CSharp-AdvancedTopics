using System;

namespace Enums
{
    // Enum must be placed at namespace level
    enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
    enum Month { Jan, Feb, Mar, Apr, Jun, Jul, Aug, Sep, Oct, Nov, Dec}

    class Program
    {
        static void Main(string[] args)
        {
            Day myDay = Day.Friday;
            Day yourDay = Day.Sunday;

            // Checking for equality
            Console.WriteLine($"myDay == yourDay = {myDay == yourDay}");

            // Checking the enum string representation
            Console.WriteLine($"myDay = {myDay} || yourDay = {yourDay}");

            // Checking the enum int representation
            Console.WriteLine($"(int) myDay = {(int) myDay} || (int) yourDay = {(int) yourDay}");
            Console.WriteLine();


            Month myMonth = Month.Apr;
            Month yourMonth = Month.Sep;
            
            // Checking for equality
            Console.WriteLine($"myMonth == yourMonth = {myMonth == yourMonth}");

            // Checking the enum string representation
            Console.WriteLine($"myMonth = {myMonth} || yourDay = {yourMonth}");

            // Checking the enum int representation
            Console.WriteLine($"(int) myMonth ==  3: {(int)myMonth == 3} || (int) yourMonth == 5: {(int) yourMonth == 5}");

        }
    }
}
