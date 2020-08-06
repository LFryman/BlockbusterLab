using System;
using System.Collections.Generic;
using System.Text;

namespace BlockbusterLab
{
    abstract class Movie
    {
        //properties/fields
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }


        //constructor
        public Movie() { }
        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Runtime: {RunTime} minutes");
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"{i + 1}: Scene: {Scenes[i]}.");
            }
        }
        public abstract void Play();

    }
}
