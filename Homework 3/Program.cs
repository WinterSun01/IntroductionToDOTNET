using System;

class Program
{
    static void Main(string[] args)
    {
        //ввод значения для вычисления факториала
        Console.Write("Введите число для вычисления его факториала: ");
        int factorialInput = int.Parse(Console.ReadLine());

        Console.WriteLine("Факториал " + factorialInput + ": " + Factorial(factorialInput));

        //ввод значения для возведения в степень
        Console.Write("Введите основание степени: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите показатель степени: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(a+ " в степени " + n + ": " + Power(a, n));

        //ввод предела для ряда Фибоначчи
        Console.Write("Введите предел для ряда Фибоначчи: ");
        int fibonacciLimit = int.Parse(Console.ReadLine());

        Console.WriteLine("Ряд Фибоначчи до " + fibonacciLimit + ":");
        FibonacciLimit(fibonacciLimit);
        Console.WriteLine();

        //ввод количества чисел для ряда Фибоначчи
        Console.Write("Введите количество чисел для ряда Фибоначчи: ");
        int fibonacciCount = int.Parse(Console.ReadLine());

        Console.WriteLine("Результат " + fibonacciCount);
        FibonacciCount(fibonacciCount);
        Console.WriteLine();
    }

    //метод для вычисления факториала
    static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    //метод для возведения числа в указанную степень
    static double Power(double a, int n)
    {
        return n == 0 ? 1 : n > 0 ? a * Power(a, n - 1) : 1 / Power(a, -n);
    }

    //метод для вывода ряда Фибоначчи до указанного предела
    static void FibonacciLimit(int limit)
    {
        void Calculations(int a, int b)
        {
            if (a <= limit)
            {
                Console.Write(a + " ");
                Calculations(b, a + b);
            }
        }
        Calculations(0, 1);
    }

    //метод для вывода указанного количества чисел из ряда Фибоначчи
    static void FibonacciCount(int count)
    {
        void Calculations(int a, int b, int remaining)
        {
            if (remaining > 0)
            {
                Console.Write(a + " ");
                Calculations(b, a + b, remaining - 1);
            }
        }
        Calculations(0, 1, count);
    }
}
