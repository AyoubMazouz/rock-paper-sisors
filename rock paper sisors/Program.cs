using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_sisors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int computer;
            string choice;
            string[] rps = { "rock", "paper", "sisors" };
            computer = rand.Next(0, rps.Length);

            Console.WriteLine("Rock Paper Sisors");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. sisors");

            

            processing();

            void processing ()
            {
                Console.WriteLine("What The Fuck.");
                choice = Console.ReadLine();
                Console.WriteLine("What The Fuck2.");


                bool parst = int.TryParse(choice, out int parsenum);

                if (parst)
                {
                    Console.WriteLine("What The Fuck.");
                    gamelogic(parsenum - 1);
                }
                else
                {
                    Console.WriteLine("Please enter 1 or 2 or 3.");
                    choice = Console.ReadLine();
                }
            }

            void gamelogic (int c)
            {
                if (rps[c] == rps[computer])
                {
                    Console.WriteLine("Draw");
                }
                else if (c == 0 && computer == 1)
                {
                    Console.WriteLine("Computer wins");
                }
                else if (c == 0 && computer == 2)
                {
                    Console.WriteLine("You won");
                }
                else if (c == 1 && computer == 0)
                {
                    Console.WriteLine("You won");
                }
                else if (c == 1 && computer == 2)
                {
                    Console.WriteLine("Computer wins");
                }
                else if (c == 2 && computer == 0)
                {
                    Console.WriteLine("Computer wins");
                }
                else if (c == 2 && computer == 1)
                {
                    Console.WriteLine("You won");
                }
                else
                {
                    Console.WriteLine("What The Fuck.");
                }
            }
        }
    }
}
