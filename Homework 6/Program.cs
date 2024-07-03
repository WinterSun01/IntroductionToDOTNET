using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        //одномерный массив
        int[] SingleDimArr = new int[10];
        for (int i = 0; i < 10; i++)
        {
            SingleDimArr[i] = rand.Next(1, 101);
        }

        Console.WriteLine("Одномерный массив:");
        foreach (var element in SingleDimArr)
        {
            Console.Write($"{element} ");
        }
        Console.WriteLine();

        int sum1 = SingleDimArr.Sum();
        double average1 = SingleDimArr.Average();
        int min1 = SingleDimArr.Min();
        int max1 = SingleDimArr.Max();

        Console.WriteLine($"Сумма: {sum1}");
        Console.WriteLine($"Среднее арифметическое: {average1}");
        Console.WriteLine($"Минимальное значение: {min1}");
        Console.WriteLine($"Максимальное значение: {max1}");
        Console.WriteLine();

        //двумерный массив
        int[,] MultiDimArr = new int[3, 4];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                MultiDimArr[i, j] = rand.Next(1, 101);
            }
        }

        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write($"{MultiDimArr[i, j]} ");
            }
            Console.WriteLine();
        }

        int sum2 = 0;
        int min2 = MultiDimArr[0, 0];
        int max2 = MultiDimArr[0, 0];
        int count = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                int value = MultiDimArr[i, j];
                sum2 += value;
                if (value < min2) min2 = value;
                if (value > max2) max2 = value;
                count++;
            }
        }
        double average2 = (double)sum2 / count;

        Console.WriteLine($"Сумма: {sum2}");
        Console.WriteLine($"Среднее арифметическое: {average2}");
        Console.WriteLine($"Минимальное значение: {min2}");
        Console.WriteLine($"Максимальное значение: {max2}");
        Console.WriteLine();

        //зубчатый массив
        int[][] JaggedArr = new int[3][];
        for (int i = 0; i < 3; i++)
        {
            int cols = rand.Next(1, 6);
            JaggedArr[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                JaggedArr[i][j] = rand.Next(1, 101);
            }
        }

        Console.WriteLine("Зубчатый массив:");
        for (int i = 0; i < JaggedArr.Length; i++)
        {
            for (int j = 0; j < JaggedArr[i].Length; j++)
            {
                Console.Write($"{JaggedArr[i][j]} ");
            }
            Console.WriteLine();
        }

        int sum3 = 0;
        int min3 = JaggedArr[0][0];
        int max3 = JaggedArr[0][0];
        int count3 = 0;

        for (int i = 0; i < JaggedArr.Length; i++)
        {
            for (int j = 0; j < JaggedArr[i].Length; j++)
            {
                int value = JaggedArr[i][j];
                sum3 += value;
                if (value < min3) min3 = value;
                if (value > max3) max3 = value;
                count3++;
            }
        }
        double average3 = (double)sum3 / count3;

        Console.WriteLine($"Сумма: {sum3}");
        Console.WriteLine($"Среднее арифметическое: {average3}");
        Console.WriteLine($"Минимальное значение: {min3}");
        Console.WriteLine($"Максимальное значение: {max3}");
        Console.WriteLine();
    }
}
