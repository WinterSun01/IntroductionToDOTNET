using System;
using System.Data;

class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите выражение для вычисления: ");
        string input = Console.ReadLine();

        try
        {
            double result = EvaluateExpression(input);
            Console.WriteLine($"Результат: {result}");
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Ошибка: {exception.Message}");
        }
    }

    public static double EvaluateExpression(string expression)
    {
        var dataTable = new DataTable();
        var value = dataTable.Compute(expression, string.Empty);
        return Convert.ToDouble(value);
    }
}
