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
            int counterDieRoll = 0;
            
            while (position1 != TARGETPOSITION)
            {
                //VARIABLES

                int dieRoll = random.Next(1, 7);
                int chooseOption = random.Next(0, 3);

                switch (chooseOption)
                {
                    case SNAKE:
                        position1 -= dieRoll;
                        int output1 = position1 < 0 ? position1 += dieRoll : position1;
                        Console.WriteLine($"Player is at {position1}");
                        break;
                    case LADDER:
                        position1 += dieRoll;
                        //For decrementing if player crosses 100 position.
                        int output2 = position1 > TARGETPOSITION ? position1 -= dieRoll : position1;
                        Console.WriteLine($"Player is at {position1}");
                        break;
                    default:
                        position1 += 0;
                        Console.WriteLine("NOT PLAY");
                        break;
                }
            counterDieRoll++;
            }
            Console.WriteLine($"Game over ! Player is at exact {position1}.\nTotal number of die roll is {counterDieRoll}.");
        }
    }
}
