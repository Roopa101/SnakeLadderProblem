﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            const int InitialPosition = 0;
            const int WinningPosition = 100;
            const int Ladder = 1;
            const int Snake = 2;
            int PlayerPosition = InitialPosition;

            while (PlayerPosition <= WinningPosition)
            {
                Random random = new Random();
                int DiceRoll = random.Next(1, 7);
                Console.WriteLine("Player got the number on dice is: " + DiceRoll);
                Random random2 = new Random();
                int Checkoptions = random.Next(0, 3);
                switch (Checkoptions)
                {
                    case Ladder:
                        PlayerPosition = PlayerPosition + DiceRoll;
                        //Here to prevent the player position to surpass the winning position we have to give the if condition.
                        if (PlayerPosition > WinningPosition)
                        {
                            PlayerPosition = PlayerPosition - DiceRoll;
                            Console.WriteLine("Player got Ladder. Player position is :" + PlayerPosition);
                        }
                        //Here if player reaches to 100, we have to declare him the winner.
                        else if (PlayerPosition == WinningPosition)
                        {
                            Console.WriteLine("Player reached " + PlayerPosition + ". Player Won the Game");
                            //To end the program here we are using return. 
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Player got Ladder. Player position is :" + PlayerPosition);
                        }
                        break;
                    case Snake:
                        PlayerPosition = PlayerPosition - DiceRoll;
                        //Here we have to give the if condition so that player position doesn't goto negative value.
                        if (PlayerPosition < InitialPosition)
                        {
                            PlayerPosition = InitialPosition;
                            Console.WriteLine("Player got Snake. Player position is :" + PlayerPosition);
                        }
                        //Here if the player position is not negative player position is usually updated.
                        else
                        {
                            Console.WriteLine("Player got Snake. Player position is :" + PlayerPosition);
                        }
                        break;
                    default:
                        Console.WriteLine("Player got Nothing. Player position is :" + PlayerPosition);
                        break;
                }
            }
            Console.ReadLine();

        }
    }