using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        //CONSTANTS
        const int SNAKE = 1;
        const int LADDER = 2;
        const int TARGETPOSITION = 100;
        public static int Getposition(int position)
        {
            StartAgain:

            //VARIABLES
            Random random = new Random();
            int chooseOption = random.Next(0, 3);
            int dieRoll = random.Next(1, 7);

            switch (chooseOption)
            {
                case SNAKE:
                    position -= dieRoll;
                    int output1 = position < 0 ? position += dieRoll : position;
                    break;
                case LADDER:
                    position += dieRoll;
                    Console.WriteLine("Ladder wons");
                    //For decrementing if player crosses 100 position.
                    int output2 = position > TARGETPOSITION ? position -= dieRoll : position;
                    //For playing again, if player got at ladder
                    goto StartAgain;
                default:
                    position += 0;
                    Console.WriteLine("NOT PLAYED");
                    break;
            }
        return position;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake & Ladder game");

            //VARIABLES
            int player1Position = 0;
            int player2Position = 0;

            while (player1Position != TARGETPOSITION && player2Position != TARGETPOSITION)
            {
                player1Position = Getposition(player1Position);
                player2Position = Getposition(player2Position);
                Console.WriteLine($"PLAYER1 IS AT {player1Position}");
                Console.WriteLine($"PLAYER2 IS AT {player2Position}");
            }
            string result = player1Position == TARGETPOSITION ? ("Player1 Won the game") : ("Player2 won the game");
            Console.WriteLine(result);
            
            
        }
    }
}
