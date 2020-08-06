using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    class VHS : Movie
    {
        //property 
        public int CurrentTime { get; set; }

        public VHS()
        {

        }

        public VHS(string Title, Genre Category, int Runtime, int CurrentTime, List<string> Scenes) : base(Title, Category, Runtime, Scenes)
        {
            CurrentTime = 0;
        }

       //method
        public override void Play()
        {
            bool lContinue = true; 
            while (lContinue)
            {
                bool a = true;
                while (a)
                {
                    if (CurrentTime < Scenes.Count)
                    {
                        Console.WriteLine(Scenes[CurrentTime]);
                        CurrentTime++;
                        a = false;
                    }
                    else
                    {
                        Rewind();
                        a = true; 
                    }
                }
                Console.WriteLine("Would you like to watch the next scene? y/n");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    lContinue = true;
                }
                else
                {
                    Console.WriteLine("Bubye Now."); 
                    lContinue = false; 
                }
            }
        }
        public void Rewind()
        {
            CurrentTime = 0; 
        }
    }
}
