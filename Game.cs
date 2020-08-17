using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        public void Run()
        {
            int numLet = 5;
            int health = 100;
            float flow = 10.5f;
            double doub = 0.88;
            Console.WriteLine("whats your name stranger?");
            string name = Console.ReadLine();
            char letter = 'A';
            bool ifOn = true;
            if (name.Length > numLet)
            {
                Console.WriteLine(name + " is longer than five characters");
            }else if(name.Length == numLet)
            {
                Console.WriteLine(name + " is exactly five characters");
            }
            else {
                Console.WriteLine(name + " is shorter than five characters");
            };
        }
    }
}
