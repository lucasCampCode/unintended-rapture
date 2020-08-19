using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        public void Run()
        {
            //one character game where stats start normally
            //this variable sets the normal health
            float health = 100.0f;
            //this value sets the starter level
            float level = 1.0f;

            //start of the game generation
            Console.WriteLine("hello stranger, what's your name?");
            // this value stores add your name
            string name = Console.ReadLine();
            Console.WriteLine("im glad you came " + name + ".");
            Console.WriteLine("press enter to continue!");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("you have stats that are given to you at the begining.");
            Console.WriteLine("to see those stats type 'stats'.");

            //gives individual stats for this person
            if(Console.ReadLine() == "stats")
            {
                Console.WriteLine("user: " + name);
                Console.WriteLine("health: " + health);
                Console.WriteLine("level: " + level);
            }
        }
    }
}
