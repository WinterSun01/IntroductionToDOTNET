using System;

namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Фигуры
            Console.WriteLine("Фигура 0:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Фигура 1:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Фигура 2:");
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Фигура 3:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 5; k > i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Фигура 4:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Фигура 5:");
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                for (int k = 0; k < i * 2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                Console.WriteLine();
            }
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.Write("\\");
                for (int k = 0; k < i * 2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("/");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Фигура 6:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("- ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(" ");

            //Шахматная доска (вариант 1)
            Console.WriteLine("Шахматная доска (вариант 1):");
            Console.Write("Введите размер доски: ");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) % 2 == 0)
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
            Console.WriteLine();
            Console.WriteLine(" ");

            //Шахматная доска (вариант 2)
            Console.WriteLine("Шахматная доска (вариант 2):");
            Console.Write("Введите размер доски: ");
            size = int.Parse(Console.ReadLine());
            int cellSize = 3;
            Console.WriteLine();

            for (int i = 0; i < size; i++)
            {
                for (int row = 0; row < cellSize; row++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        for (int col = 0; col < cellSize; col++)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
