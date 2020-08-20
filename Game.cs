using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

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

        //gives individual stats for this person
        begin:

            Console.WriteLine("::::lobby::::");
            Console.WriteLine("things to do.");
            Console.WriteLine("type stats for your stats.");
            Console.WriteLine("type role to give yourself a role.");
            if(role != "not set")
            { 
                Console.WriteLine("type start to begin fight simulation");
            }
            string todo = Console.ReadLine().ToLower();
            Console.Clear();

            if(todo == "stats")
            {
                Console.WriteLine("user: " + name);
                Console.WriteLine("role:" + role);
                Console.WriteLine("health: " + health);
                Console.WriteLine("level: " + level);
                Console.WriteLine("press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
            else if (todo == "role" && role == "not set")
            //roles
           
            {
                Console.WriteLine("so you want a role!");
                Console.WriteLine("here are your choices");
                Console.WriteLine("fighter: +50 health|");
                Console.WriteLine("tank: +200 health|");

                // this is where it places your role and applies to the person
                string roleS = Console.ReadLine().ToLower();
                if(roleS == "fighter")
                {
                    Console.WriteLine("you have chossen the fighter role!");
                    health = 150;
                    role = "fighter";
                    Console.WriteLine("press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if(roleS == "tank")
                {
                    Console.WriteLine("you have chossen tank role!");
                    health = 300;
                    role = "tank";
                    Console.WriteLine("press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                
            }
            else if(todo == "role" && role != "not set")
            {
                Console.WriteLine("sorry you have already chose your role.");
                Console.WriteLine("press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }else if(todo == "start")
            {
                goto start;
            }
            goto begin;

            start:
            {
                Random rnd = new Random();
                //array for diffrent numbers
                int[] randNum = { 1, 2, 3, 4, 5, 6, 7, 8, 9};

                // get random indexes for number
                int pulledNum = rnd.Next(randNum.Length);

                if(pulledNum == 1)
                {

<<<<<<< HEAD
<<<<<<< Updated upstream
                }
                else if(pulledNum == 2)
                {

                }
                else if(pulledNum == 3)
                {

                }
                else if (pulledNum == 4)
                {

                }
                else if (pulledNum == 5)
                {

                }
                else if (pulledNum == 6)
                {

                }
                else if (pulledNum == 7)
                {

                }
                else if (pulledNum == 8)
                {

                }
                else if (pulledNum == 9)
                {

                }
                else
=======
                }else if(pulledNum == 2)
>>>>>>> Stashed changes
=======
                }else if(pulledNum == 2)
>>>>>>> parent of bcb44af... added more random occurrence
                {

                }
            }

        }
    }
}
