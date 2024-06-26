using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число для вычисления его факториала: ");
        int factorialInput = Convert.ToInt32(Console.ReadLine());

        // Вывод результата вычисления факториала
        Console.WriteLine("Факториал " + factorialInput + ": " + Factorial(factorialInput));
    }

    //метод для вычисления факториала с использованием длинной арифметики
    static BigInteger Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }
}
