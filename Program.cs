using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MoviesLAB9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('*', 20));
            Console.WriteLine("Welcome to MovieX");
            Console.WriteLine(new string('*', 20));

            Console.WriteLine("\n\nThere are 10 movies in list");


                //Declare
                Movies starwars = new Movies("Star Wars", "Scifi",1);// dont need to declare string becasue we told our constructor that these inputs are already a string
                Movies it = new Movies("IT", "Horror",2);
                Movies godzilla = new Movies("Godzilla", "Scifi",1);
                Movies lotr = new Movies("Lord of Rings : The Fellowship Of The Ring", "Scifi",1);
                Movies hobbit = new Movies("The Hobbit", "Scifi",1);
                Movies shining = new Movies("The Shining", "Horror",2);
                Movies nightmare = new Movies("A Nightmare On Elm Street", "Horror",2);
                Movies superbad = new Movies("Superbad", "Comedy",3);
                Movies anchor = new Movies("Anchorman: The Legend Of Ron Burgandy", "Comedy",3);
                Movies warcraft = new Movies("Warcraft", "Fantasy",4);

                //create array
            while (true)
            {
                Movies[] movielist = new Movies[10] { starwars, it, godzilla, lotr, hobbit, shining, nightmare, superbad, anchor, warcraft };

                Console.WriteLine("\nWhat category are you interest in?");
                Console.WriteLine("\n[1] Scifi [2] Horror [3] Comedy [4] Fantasy");                
                string userInput = ( Console.ReadLine());

                foreach (Movies movie in movielist) // using foreach with an if statment.
                {
                   
                    if (userInput.ToUpper() == movie.Category.ToUpper())
                    {
                        Console.WriteLine();
                        Console.WriteLine(movie.Title);
                    }

                }

                Console.WriteLine("\nWould you like to run this program again? Y/N");
                string cont = Console.ReadLine().ToLower();
                
                while(cont != "y" && cont !="n")
                {
                    Console.WriteLine("Please Eneter Y or N!");
                    cont = Console.ReadLine().ToLower();
                }

                bool CONT = Validation.validate(cont);
                if (CONT == true)
                {
                    continue;
                }
                else if (CONT == false)
                {
                    break;
                }

            }

        }
    }
}
