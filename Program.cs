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
            //VARIABLES
            //int position1 = 0;
            Random random = new Random();
            int dieRoll = random.Next(1, 7);

            Console.WriteLine($"Rolling die Number is {dieRoll}");
        }
    }
}
