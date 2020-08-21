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
            start:
            //one character game where stats start normally
            //this variable sets the normal health
            float health = 100.0f;
            //this value sets the starter level
            float level = 1.0f;
            string role = "not set";
            string place = "lobby";
            float coins = 0.0f;
            float maxhealth = 0.0f;



            //start of the game generation
            Console.WriteLine("hello stranger, what's your name?");
            // this value stores add your name
            string name = Console.ReadLine();
            Console.WriteLine("im glad you came " + name + ".");
            Console.WriteLine("press enter to continue!");
            Console.ReadLine();
            Console.Clear();

            //gives individual stats for this person
            while (place.ToLower() == "lobby")
            {

                Console.WriteLine("         ::::lobby::::");
                Console.WriteLine();
                Console.WriteLine("         things to do.");
                Console.WriteLine();
                Console.WriteLine("    type stats for your stats.");
                Console.WriteLine();
                Console.WriteLine("type role to give yourself a role.");
                Console.WriteLine();
                Console.WriteLine("  type rest to regain health");
                Console.WriteLine();
                if (role != "not set")
                {
                    Console.WriteLine(" type hunt to walk out the lobby");
                    Console.WriteLine();
                }
                string todo = Console.ReadLine().ToLower();
                Console.Clear();
                //stats
                if (todo == "stats")
                {
                    Console.WriteLine("user: " + name);
                    Console.WriteLine("role:" + role);
                    Console.WriteLine("health: " + health);
                    Console.WriteLine("level: " + level);
                    Console.WriteLine("cash: " + coins);
                    
                    Console.WriteLine("press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (todo == "role" && role == "not set")
                //roles
                {
                    Console.WriteLine("so you want a role!");
                    Console.WriteLine("here are your choices");
                    Console.WriteLine("fighter: 150 max health|");
                    Console.WriteLine("tank: 300 max health|");

                    // this is where it places your role and applies to the person
                    string roleS = Console.ReadLine().ToLower();
                    if (roleS == "fighter")
                    {
                        Console.WriteLine("you have chossen the fighter role!");
                        maxhealth = 150;
                        health = 150;
                        role = "fighter";
                        Console.WriteLine("press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (roleS == "tank")
                    {
                        Console.WriteLine("you have chossen tank role!");
                        maxhealth = 300;
                        health = 300;
                        role = "tank";
                        Console.WriteLine("press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                else if (todo == "role" && role != "not set")
                {
                    Console.WriteLine("sorry you have already chose your role.");
                    Console.WriteLine("press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (todo == "hunt")
                {
                    place = "hunt";
                }
                else if(todo == "rest")
                {
                    Console.WriteLine("you decide to rest and regined health");
                    health = maxhealth;
                    Console.ReadKey();
                    Console.Clear();
                }





                //this is the loop for random eencounters
                while (place == "hunt")
                {
                    
                    Random rnd = new Random();
                    //array for diffrent numbers
                    int[] randNum = {0, 1, 2, 3, 4, 5, 6, 7, 8};
                    int[] randDamage = {10,20,30,40,50};
                    Console.WriteLine("you walk around to find something to do");
                    Console.WriteLine();
                    Console.WriteLine("press 1 to continue to walk");
                    Console.WriteLine();
                    Console.WriteLine("press 2 to go back to lobby");
                    char input = Console.ReadKey().KeyChar;
                    Console.Clear();

                    // get random indexes for number
                    int pulledNum = rnd.Next(randNum.Length);
                    int pulledDamage = rnd.Next(randDamage.Length);

                  
                    
                    if(health < 50)
                    {
                        Console.WriteLine("you are low on health go to the lobby to replenish your health");
                        Console.WriteLine();
                    }
                    if(health <= 0)
                    {
                        Console.WriteLine("you died while running into enemies");
                        Console.WriteLine();
                        Console.WriteLine("do you want to play again?");
                        Console.WriteLine();
                        Console.WriteLine("press 1 for yes");
                        Console.WriteLine("press 2 for no");
                        char key = Console.ReadKey().KeyChar;
                        if(key == 1)
                        {
                            goto start;
                        }
                        else if(key == 2)
                        {
                            break;
                        }
                    }
                    

                    if (input == '1')
                    {
                        if (pulledNum == 1)
                        {
                            Console.WriteLine("nothing happens");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 2)
                        {
                            int enemyDamage = randDamage[pulledDamage];
                            Console.WriteLine("you stumbled across an orc");
                            health -= enemyDamage;
                            Console.WriteLine();
                            Console.WriteLine("you took " + enemyDamage + " before defeating them");
                            Console.WriteLine();
                            level += 0.5f;

                        }
                        else if (pulledNum == 3)
                        {
                            Console.WriteLine("nothing happens");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 4)
                        {
                            int enemyDamage = randDamage[pulledDamage];
                            Console.WriteLine("you stumbled across goblins");
                            health -= enemyDamage;
                            Console.WriteLine();
                            Console.WriteLine("you took " + enemyDamage + " before defeating them");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 5)
                        {
                            Console.WriteLine("nothing happens");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 6)
                        {
                            int enemyDamage = randDamage[pulledDamage];
                            health -= enemyDamage;
                            if (enemyDamage > 20)
                            {
                                Console.WriteLine("you ran into a pack of wolves!");
                                level += 1;
                            }
                            else
                            {
                                Console.WriteLine("you ran into a wolf!");
                                Console.WriteLine();
                                level += 0.2f;
                            }
                            Console.WriteLine("you took " + enemyDamage + " before defeating them");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 7)
                        {
                            Console.WriteLine("nothing happens");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 8)
                        {
                            Console.WriteLine("random " + pulledNum + " has been pulled");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 0)
                        {
                            Console.WriteLine("nothing happens");
                            Console.WriteLine();
                        }
                    }
                    else if (input == '2')
                    {
                        place = "lobby";
                    }
                    else
                    {
                        Console.WriteLine("invalid input!");
                        Console.WriteLine();
                    }
                }
            } 
            
        }
    }
}
