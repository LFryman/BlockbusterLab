using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class DVD : Movie
    {
        public DVD()
        {

        }

        public DVD(string Title, Genre Category, int Runtime, List<string> Scenes) : base(Title, Category, Runtime, Scenes)
        {
            
        }
        public override void Play()
        {
            bool lContinue = true;
            while (lContinue)
            {
                Console.WriteLine("Which scene would you like to play?");
                PrintScenes();
                int input = int.Parse(Console.ReadLine());
                if (input < Scenes.Count)
                {
                    Console.WriteLine($"Enjoy: {Scenes[input - 1]}");
                    Console.WriteLine("Would you like to play another scene?");
                    string input2 = Console.ReadLine();
                    if (input2 == "y")
                    {
                        lContinue = true;
                    }
                    else
                    {
                        Console.WriteLine("Bubye Now.");
                        lContinue = false; 
                    }
                }
                else
                {
                    Console.WriteLine("That's a no go bro. Try agian.");
                }
            }
        }
    }
}
