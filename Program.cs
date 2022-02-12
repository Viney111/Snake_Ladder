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

            //VARIABLES
            int position1 = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);
            int chooseOption = random.Next(0,3);

            switch (chooseOption)
            {
                case SNAKE:
                    position1 -= dieRoll;
                    break;
                case LADDER:
                    position1 += dieRoll;
                    break;
                default:
                    position1 +=0;
                    Console.WriteLine("NOT PLAY");
                    break;
            }
            Console.WriteLine($"Player is at {position1}");
        }
    }
}
