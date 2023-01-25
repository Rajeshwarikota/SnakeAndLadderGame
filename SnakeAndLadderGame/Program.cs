﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Snake = 0;
            const int Ladder = 1;
            const int NoGame = 2;
            int position = 0;
            Random random= new Random();
            int diceRoll = random.Next(1,7);
            Console.WriteLine("Rolled Dice number is:" + diceRoll);
            int choice = random.Next(0,3);
        

                switch (choice)
            {
                case Snake:
                    position -= diceRoll;
                    Console.WriteLine("Its a snake");
                    if (position < 0)
                    {
                        Console.WriteLine("Player 1 position : 0");
                    }
                    else
                    {
                        Console.WriteLine("Player 1 position : " + position);
                    }
                    break;
                case Ladder:
                    position += diceRoll;
                    Console.WriteLine("Its a ladder");
                    Console.WriteLine("Player 1 position : " + position);
                    break;
                case NoGame:
                    Console.WriteLine("Its a NoGame");
                    Console.WriteLine("Player 1 position : " + position);
                    break;

            }
                    Console.ReadLine();
        }
    }
}
