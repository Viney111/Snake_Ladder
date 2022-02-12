using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder game");
            //CONSTANTS
            const int SNAKE = 1;
            const int LADDER = 2;
            const int TARGETPOSITION = 100;

            //VARIABLES
            int position1 = 0;
            Random random = new Random();
            
            while (position1 <= TARGETPOSITION)
            {
                //VARIABLES

                int dieRoll = random.Next(1, 7);
                int chooseOption = random.Next(0, 3);

                switch (chooseOption)
                {
                    case SNAKE:
                        position1 -= dieRoll;
                        int output = position1 < 0? position1 +=dieRoll: position1;
                        Console.WriteLine("Position1 decremented");
                        break;
                    case LADDER:
                        position1 += dieRoll;
                        Console.WriteLine("Position1 Incremented");
                        break;
                    default:
                        position1 += 0;
                        Console.WriteLine("NOT PLAY");
                        break;
                }
            }
            Console.WriteLine($"Game over ! Player is at {position1}");
        }
    }
}
