using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int xPosition = 35;
            int yPosition = 20;
            int gameSpeed = 150;

            bool isGameOn = true;
            bool is WallHit = false;

            //Get the snake to appear on screen

            Console.SetCursorPosition(xPosition, yPosition);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((char)2);

            //Build boundary
            buildWall();

            //Get snake to move

            ConsoleKey command = Console.ReadKey().Key;

            do
            {
                switch (command)
                {
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        xPosition--;
                        break;

                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        yPosition--;
                        break;

                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        xPosition++;
                        break;

                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(xPosition, yPosition);
                        Console.Write(" ");
                        xPosition++;
                        break;
                }

                Console.SetCursorPosition(xPosition, yPosition);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine((char)2);

                isWallHit = DidSnakeHitWall(xPosition, yPosition);

                if (isWallHit)
                {
                    isGameOn = false;
                    Console.SetCursorPosition(28, 20);
                    Console.WriteLine("GAME OVER");
                }

                if (Console.KeyAvailable) command = Console.ReadKey().Key;
                System.Threading.Thread.Sleep(gameSpeed)
            }

            while (isGameOn);

            //Detect when snake hits boundary
            //Slow game down

            //Place apple on board (randomly)

            //Detect when apple was eaten
                //Make snake faster
                //Make sneak longer
                //Keep track of how many apples were eaten

            //Beald welcome screen

            //Give player option to read directions

            //Show score

            //Give player option to restart the game


        }

        private static void buildWall()
        {
            for (int i = 1; i < 41; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, i);
                Console.Write("#");
                Console.SetCursorPosition(70, i);
                Console.Write("#");
            }

            for (int i = 1; i < 71; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("#");
                Console.SetCursorPosition(i, 40);
                Console.Write("#");
            }
        }
    }
}
