using System;
using System.Collections.Generic;

namespace UsingTheRandomClass
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> myFriends = new List<string>();

            Console.WriteLine($"My favorite friends among my best friends is {RandomStringPicker(myFriends)}");
            
        }

        static void FortuneTellerGame()
        {
            Random fortuneTeller = new Random();

            Console.Write("Please enter your question: ");
            Console.ReadLine();

            int myAnswer = fortuneTeller.Next(1, 4);

            switch (myAnswer)
            {
                case 1:
                    Console.WriteLine("My answer is: \"YES\"");
                    break;
                case 2:
                    Console.WriteLine("My answer is: \"NO\"");
                    break;
                case 3:
                    Console.WriteLine("My answer is: \"MAYBE...\"");
                    break;
                default:
                    Console.WriteLine("My answer is: \"I REALLY DON'T KNOW...\"");
                    break;
            }
        }

        static void RandomEyesExample()
        {
            Random dice = new Random();

            int eyesNumber = 0;

            for (int i = 0; i < 10; i++)
            {
                eyesNumber = dice.Next(1, 7);
                Console.WriteLine($"Current number of eyes: {eyesNumber}");
            }

            Console.WriteLine($"Final number of eyes: {eyesNumber}");
        }

        static string RandomStringPicker(List<string> aStringList)
        {
            // Method returns null if the List is empty. Else, it will return a random string from the List
            Random picker = new Random();
            if (aStringList.Count == 0)
                return null;
            else
                return aStringList[picker.Next(0, aStringList.Count)];
        }
    }
}
