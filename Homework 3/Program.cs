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
        Console.Write("Введите число: ");
        double number = double.Parse(Console.ReadLine());

        Console.Write("Введите показатель степени: ");
        int stepen = int.Parse(Console.ReadLine());

        Console.WriteLine(number + " в степени " + stepen + ": " + Power(number, stepen));

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
    public static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        else
            return n * Factorial(n - 1);
    }

    //метод для возведения числа в указанную степень
    public static double Power(double number, int stepen)
    {
        if (stepen == 0)
            return 1;
        else if (stepen > 0)
            return number * Power(number, stepen - 1);
        else
            return 1 / Power(number, -stepen);
    }

    //метод для вывода ряда Фибоначчи до указанного предела
    public static void FibonacciLimit(int limit)
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
    public static void FibonacciCount(int count)
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
