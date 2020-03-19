using System;
using System.Collections.Generic;
using System.Text;

namespace Structs
{
    class GameClass
    {
        // Fields
        public string name;
        public string developer;
        public double rating;
        public string releaseDate;

        // Constructor
        public GameClass(string name, string developer, double rating, string releaseDate)
        {
            this.name = name;
            this.developer = developer;
            this.rating = rating;
            this.releaseDate = releaseDate;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Game name: {name}\nDeveloped by: {developer}\nRelease date: {releaseDate}\nRating: {rating}");
        }
    }
}
