using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class Blockbuster
    {
        public List<Movie> Movies = new List<Movie>
            {
                new VHS("The Princess Bride", Genre.Comedy, 98, 0, new List<string>(){"Ass You Wish", "Dread Pirate Robets", "Inconceivable!", "ROUS!", "The Escape"}),
                new VHS("101 Dalmations", Genre.Drama, 79, 0, new List<string>(){"All the puppies", "That Bad Lady", "More puppies", "The escape", "Finding more spots"}),
                new VHS("Aladin", Genre.Romance, 91, 0, new List<string>(){ "Harassing Law Enforcement", "Don't Touch That!", "If I Lie She'll Like Me", "Travel", "Messing With The Wrong Gene"}),
                new DVD("LOTR Trilogy", Genre.Action, 656, new List<string>(){"Unexpected Vacay", "Jewelery That's Just Not Worth It", "Split The Party, Roll Initiative", "Just Doing Our Best", "Finally Getting Home"}),
                new DVD("Midsommar", Genre.Horror, 138, new List<string>(){"Tragic Disaster", "Strange and Awkward Conversations", "More Violent Things", "Fun With Drugs", "More Creepy Violent Things"}),
                new DVD("V For Vendetta", Genre.Action, 133, new List<string>(){"Visiting Your Sugar Daddy", "Truble on The Horizon", "Getting Into Trouble", "Getting Into More Trouble", "Let'S blow up Some Stuff"}),
            };

        public void PrintMovies()
        {
            int count = 1;
            foreach (Movie movie in Movies)
            {
                Console.WriteLine($"{count} Title: {movie.Title}");
                count++;
            }
        }

        public virtual void CheckOut()
        {
            PrintMovies();
            Console.WriteLine("What movie would you like to check out?");
            try
            {
                int input = int.Parse(Console.ReadLine());

                Movies[input - 1].PrintInfo();

                Console.WriteLine("Would you like to play this movie? y/n");
                string input1 = Console.ReadLine();

                if (input1 == "y")
                {
                    Movies[input - 1].Play();
                }
            }
            catch
            {
                Console.WriteLine("That input was not a an option.");
                Console.WriteLine("Press any key to try again");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
