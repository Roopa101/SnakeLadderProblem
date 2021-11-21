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
            int SinglePlayerPosition = InitialPosition;
            Console.WriteLine("Single Player is starting with position" + SinglePlayerPosition);
            Random random = new Random();
            int DiceRoll = random.Next(1, 7);
            Console.WriteLine("Player got the num :" + DiceRoll);
            Console.ReadLine();
        }
    }
}