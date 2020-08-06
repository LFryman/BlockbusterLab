using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Blockbuster blockbuster = new Blockbuster();

            List<Movie> movieList = blockbuster.Movies;
            VHS tape = new VHS();
            DVD cd = new DVD();

            Console.WriteLine("Welcome to Blockbuster! The very last one.");

            bool lContinue = true;
            while (lContinue)
            {
                Console.WriteLine("Rent a movie? ... Please? y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    blockbuster.CheckOut();
                    
                }
                else if (input == "n")
                {
                    Console.WriteLine("Why are you here? Make like my ex and get the heck out!");
                    lContinue = false;
                }
                else
                {
                    Console.WriteLine("That was not an acceptable answere. y or n Please....");
                }
            }

        }

    }
}
