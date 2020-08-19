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
            string role = "not set";


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
            begin:
            if(Console.ReadLine().ToLower() == "stats")
            {
                Console.WriteLine("user: " + name);
                Console.WriteLine("role:" + role);
                Console.WriteLine("health: " + health);
                Console.WriteLine("level: " + level);
                if(role == "not set")
                {
                    Console.WriteLine("you seem to not have role set to set your role type 'roles'");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            //roles
            if (Console.ReadLine().ToLower() == "roles" && role == "not set")
            {
                Console.WriteLine("so you want a role!");
                Console.WriteLine("here are your choices");
                Console.WriteLine("fighter: +50 health|");
                Console.WriteLine("tank: +200 health|");

                // this is where it places your role and applies to the person
                if(Console.ReadLine().ToLower() == "fighter")
                {
                    Console.WriteLine("you have chossen the fighter role!");
                    health = 150;
                    role = "fighter";
                    Console.WriteLine("press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }else if(Console.ReadLine().ToLower() == "tank")
                {
                    Console.WriteLine("you have chossen tank role!");
                    health = 300;
                    role = "tank";
                    Console.WriteLine("press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("sorry you have already chose your role.");
                Console.WriteLine("press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
            goto begin;
        }
    }
}
