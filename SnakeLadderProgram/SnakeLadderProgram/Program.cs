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
            const int FinalPosition = 100;
            const int LadderPosition = 1;
            const int SnakePosition = 2;
            int SinglePlayerPosition = InitialPosition;
            int count = 0;
            while (SinglePlayerPosition <= FinalPosition)
            {
                Random random = new Random();
                int DiceRoll = random.Next(1, 7);
                //To track the numbers of loop ran till winning, we have to assign an incremental variable within the loop
                count++;
                Console.WriteLine("Player got the num : " + DiceRoll);
                Random random2 = new Random();
                int CheckForOptions = random.Next(0, 3);
                switch (CheckForOptions)
                {
                    case LadderPosition:
                        SinglePlayerPosition = SinglePlayerPosition + DiceRoll;
                        //Here to prevent the player position to surpass the winning position we have to give the if condition.
                        if (SinglePlayerPosition > FinalPosition)
                        {
                            SinglePlayerPosition = SinglePlayerPosition - DiceRoll;
                            Console.WriteLine("Player got Ladder. Player position is :" + SinglePlayerPosition);
                        }
                        //Here if player reaches to 100, we have to declare him the winner.
                        else if (SinglePlayerPosition == FinalPosition)
                        {
                            Console.WriteLine("Player reached " + SinglePlayerPosition + ". Player Won the Game");
                            //To Count the number of times the dice was played
                            //We have to write the incremental variable which we used to track the numbers of iterations performed by a loop.
                            Console.WriteLine("Number of times the player rolled the dice is :" + count);
                            Console.ReadLine();
                            //To end the program here we are using return. 
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Player got Ladder. Player position is :" + SinglePlayerPosition);
                        }
                        break;
                    case SnakePosition:
                        SinglePlayerPosition = SinglePlayerPosition - DiceRoll;
                        //Here we have to give the if condition so that player position doesn't goto negative value.
                        if (SinglePlayerPosition < InitialPosition)
                        {
                            SinglePlayerPosition = InitialPosition;
                            Console.WriteLine("Player got Snake. Player position is :" + SinglePlayerPosition);
                        }
                        //Here if the player position is not negative player position is usually updated.
                        else
                        {
                            Console.WriteLine("Player got Snake. Player position is :" + SinglePlayerPosition);
                        }
                        break;
                    default:
                        Console.WriteLine("Player got Nothing. Player position is :" + SinglePlayerPosition);
                        break;
                }
            }
        }
    }
}