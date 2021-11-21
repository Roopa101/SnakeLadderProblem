using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    class Program
    {
        public static void Main(string[] args)
        { 
            const int InitialPosition = 0;
            const int LadderPosition = 1;
            const int SnakePosition = 2;

            int SinglePlayerPosition = InitialPosition;
         
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Player got the num :" + DiceRoll);
            Random random1 = new Random();
            int CheckForoptions = random.Next(0, 3);

            switch (CheckForoptions)
            {
                case LadderPosition:
                    SinglePlayerPosition = SinglePlayerPosition + DiceRoll;
                    Console.WriteLine("Player got a Ladder , player position is + " SinglePlayerPosition);
                    break;

                case SnakePosition:
                    SinglePlayerPosition = SinglePlayerPosition - DiceRoll;
                    Console.WriteLine("Player got a Snake , player position is + " SinglePlayerPosition);
                    break;

                default:
                    Console.WriteLine(""Player got nothing ");
                    break;

            }
            
            Console.ReadLine();
        }
    }
}