using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace HelloWorld
{
    class Game
    {
        private readonly Random rand = new Random();
        public int RandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }
        public void Run()
        {
        start:
            //one character game where stats start normally
            //this variable sets the normal health
            float playerLevel = 1, playerHealth = 100, playerMaxhealth = 100, playerDamage = 10;
            string playerRole = "not set", place = "lobby";
            //enemy stats


            void PlayerStats(float mH, float h, float l, float pD, string r)
            {
                playerMaxhealth = mH;
                playerHealth = h;
                playerLevel = l;
                playerRole = r;
                playerDamage = pD;
            }


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
                if (playerRole != "not set")
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
                    Console.WriteLine("role:" + playerRole);
                    Console.WriteLine("health: " + playerHealth);
                    Console.WriteLine("level: " + playerLevel);
                    Console.WriteLine("press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (todo == "role" && playerRole == "not set")
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
                        PlayerStats(150, 150, playerLevel, 50, "fighter");
                        Console.WriteLine("press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (roleS == "tank")
                    {
                        Console.WriteLine("you have chossen tank role!");
                        PlayerStats(300, 300, playerLevel, 30, "tank");
                        Console.WriteLine("press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }

                }
                else if (todo == "role" && playerRole != "not set")
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
                else if (todo == "rest")
                {
                    playerHealth = playerMaxhealth;
                }





                //this is the loop for random eencounters
                while (place == "hunt")
                {

                    Random rnd = new Random();
                    //array for diffrent numbers
                    
                    Console.WriteLine("you walk around to find something to do");
                    Console.WriteLine();
                    Console.WriteLine("press 1 to continue to walk");
                    Console.WriteLine();
                    Console.WriteLine("press 2 to go back to lobby");
                    char input = Console.ReadKey().KeyChar;
                    Console.Clear();

                    // get random indexes for number
                    int pulledNum = RandomNumber(0, 9);



                    if (playerHealth < 50)
                    {
                        Console.WriteLine("you are low on health go to the lobby to replenish your health");
                        Console.WriteLine();
                    }
                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("you died while running into enemies");
                        Console.WriteLine();
                        Console.WriteLine("do you want to play again?");
                        Console.WriteLine();
                        Console.WriteLine("press 1 for yes");
                        Console.WriteLine("press 2 for no");
                        char key = Console.ReadKey().KeyChar;
                        if (key == '1')
                        {
                            Console.Clear();
                            goto start;
                        }
                        else if (key == '2')
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
                            int enemyDamage = RandomNumber(10, 50);
                            Console.WriteLine("you stumbled across an orc");
                            playerHealth -= enemyDamage;
                            Console.WriteLine();
                            Console.WriteLine("you took " + enemyDamage + " before defeating them");
                            Console.WriteLine();
                            playerLevel += 0.5f;

                        }
                        else if (pulledNum == 3)
                        {
                            Console.WriteLine("you walk through the never ending woods");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 4)
                        {
                            int enemyDamage = RandomNumber(10, 50);
                            Console.WriteLine("you stumbled across goblins");
                            playerHealth -= enemyDamage;
                            Console.WriteLine();
                            Console.WriteLine("you took " + enemyDamage + " before defeating them");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 5)
                        {
                            Console.WriteLine("you walk through the never ending woods");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 6)
                        {
                            int enemyDamage = RandomNumber(10,50);
                            playerHealth -= enemyDamage;
                            if (enemyDamage > 20)
                            {
                                Console.WriteLine("you ran into a pack of wolves!");
                                playerLevel += 1;
                            }
                            else
                            {
                                Console.WriteLine("you ran into a wolf!");
                                Console.WriteLine();
                                playerLevel += 0.2f;
                            }
                            Console.WriteLine("you took " + enemyDamage + " before defeating them");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 7)
                        {
                            Console.WriteLine("you walk through the never ending woods");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 8)
                        {
                            int enemyDamage = RandomNumber(10,50);
                            playerHealth -= enemyDamage;
                            Console.WriteLine("you ran into a oger");
                            Console.WriteLine("you took " + enemyDamage + " before defeating it");
                            Console.WriteLine();
                        }
                        else if (pulledNum == 0)
                        {
                            Console.WriteLine("while wandering through the woods you found a chef");
                            Console.WriteLine("you gain 25 health while on your journy!");
                            playerHealth += 25;
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
                if (playerHealth <= 0) { break; }
            }

        }
    }
}
