using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Manipulating a struct
            
            Console.WriteLine("\nWORKING WITH A STRUCT!!!\n");

            GameStruct myGameStructObj = new GameStruct("Pokemon", "Niantic", 4.1, "06.01.2016");

            Console.WriteLine("Calling the Display() method on the original Game object: ");
            myGameStructObj.Display();

            Console.WriteLine("\nCalling the ChangeGameName() static method with the previously displayed game...\n");
            ChangeGameStructObjName(myGameStructObj);
            Console.WriteLine("\nCalling the Display() method on the recently changed struct FROM OUTSIDE THE CHANGEGAMEMETHOD()!!!\n");
            myGameStructObj.Display();

            // Same example, but with a class

            Console.WriteLine("\nWORKING WITH A CLASS!!!\n");
            
            GameClass myGameClassObj = new GameClass("Pokemon", "Niantic", 4.1, "06.01.2016");

            Console.WriteLine("Calling the Display() method on the original Game object: ");
            myGameClassObj.Display();

            Console.WriteLine("\nCalling the ChangeGameName() static method with the previously displayed game...\n");
            ChangeGameClassObjName(myGameClassObj);
            Console.WriteLine("\nCalling the Display() method on the recently changed struct FROM OUTSIDE THE CHANGEGAMEMETHOD()!!!\n");
            myGameClassObj.Display();


        }

        static void ChangeGameStructObjName(GameStruct aGameObj)
        {
            Console.WriteLine($"\nName of the passed Game (Game.name) = {aGameObj.name}");
            Console.WriteLine($"Changing the name in the method from {aGameObj.name} to \"Candy Crush\"...");
            aGameObj.name = "Candy Crush";
            Console.WriteLine("Calling the Display() method on the recently changed struct FROM WITHIN THE CHANGEGAMEMETHOD()!!!\n");
            aGameObj.Display();
        }

        static void ChangeGameClassObjName(GameClass aGameObj)
        {
            Console.WriteLine($"\nName of the passed Game (Game.name) = {aGameObj.name}");
            Console.WriteLine($"Changing the name in the method from {aGameObj.name} to \"Candy Crush\"...");
            aGameObj.name = "Candy Crush";
            Console.WriteLine("Calling the Display() method on the recently changed struct FROM WITHIN THE CHANGEGAMEMETHOD()!!!\n");
            aGameObj.Display();
        }
    }
}
