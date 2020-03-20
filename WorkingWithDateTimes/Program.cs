using System;

namespace WorkingWithDateTimes
{
    class Program
    {
        static void Main(string[] args)
        {

            
            // Create a DateTime object out of a given moment in time
            DateTime dt = new DateTime(1992, 4, 9, 9, 54, 0);
            Console.WriteLine($"I was born on {dt}");

            // Create a DateTime object out of today's date
            DateTime today = DateTime.Today;
            Console.WriteLine($"And today's date is {today.Date}");

            // Create a DateTime object with the current time info:
            DateTime now = DateTime.Now;
            Console.WriteLine($"Current time is {now}");
            Console.WriteLine($"The current hour is {now.Hour}, the current minute is {now.Minute} and the current second is {now.Second}.");

            // Displaying tomorrow's date:
            Console.WriteLine($"Tomorrow will be {GetTomorrow()}");

            // Displaying the day of the week:
            Console.WriteLine($"Today is {today.DayOfWeek}");

            // Displaying the amount of days in a given month
            int days = DateTime.DaysInMonth(2020, 2);
            Console.WriteLine($"February 2020 had {days} days...");

            // Calculating timespans

            Console.Write("Select a year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.Write("Select a month: ");
            int month = Int32.Parse(Console.ReadLine());
            Console.Write("Select a day: ");
            int day = Int32.Parse(Console.ReadLine());
            DateTime chosenDateTime = new DateTime(year, month, day);
            TimeSpan daysPassed = DateTime.Now.Subtract(chosenDateTime);
            Console.WriteLine($"Days passed since the entered day: {daysPassed.Days}");

            DateTime myBD = new DateTime(1992, 4, 9);
            DateTime tenThousandDaysAfterBD = myBD.AddDays(10000);
            Console.WriteLine($"I turned 10,000 days on {tenThousandDaysAfterBD.Date}.");
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
    }
}
