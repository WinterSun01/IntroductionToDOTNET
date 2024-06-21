#define CLASS_CONSOLE
using System;

namespace IntroductionToDOTNET
{
    class Program
    {
        static int squareX = 10;
        static int squareY = 10;
        const int squareSize = 1;
        const int consoleWidth = 40;
        const int consoleHeight = 20;

        static void Main(string[] args)
        {
#if CLASS_CONSOLE
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            DrawSquare();

            while (true)
            {
                var key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.Escape)
                    break;

                MoveSquare(key);
                DrawSquare();
            }
            Console.ResetColor();
#endif
        }

        static void MoveSquare(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.W:
                    if (squareY > 0) squareY--;
                    break;
                case ConsoleKey.S:
                    if (squareY < consoleHeight - 1) squareY++;
                    break;
                case ConsoleKey.A:
                    if (squareX > 0) squareX--;
                    break;
                case ConsoleKey.D:
                    if (squareX < consoleWidth - 1) squareX++;
                    break;
            }
        }

        static void DrawSquare()
        {
            Console.Clear();
            for (int y = 0; y < consoleHeight; y++)
            {
                for (int x = 0; x < consoleWidth; x++)
                {
                    if (x == squareX && y == squareY)
                    {
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
