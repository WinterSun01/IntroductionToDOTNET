using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITriangle
{
    double GetArea();
    double GetPerimeter();
}

public abstract class Triangle : ITriangle
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public abstract double GetArea();

    public double GetPerimeter()
    {
        return SideA + SideB + SideC;
    }
}
public class EquilateralTriangle : Triangle
{
    public EquilateralTriangle(double side) : base(side, side, side) { }

    public override double GetArea()
    {
        return (Math.Sqrt(3) / 4) * SideA * SideA;
    }
}

public class RightTriangle : Triangle
{
    public RightTriangle(double baseSide, double heightSide, double hypotenuseSide)
        : base(baseSide, heightSide, hypotenuseSide) { }

    public override double GetArea()
    {
        return 0.5 * SideA * SideB;
    }
}

public class TriangleInterfaces
{
    public static void Main()
    {
        Console.WriteLine("Выберите тип треугольника:");
        Console.WriteLine("1. Равносторонний треугольник");
        Console.WriteLine("2. Прямоугольный треугольник");
        string choice = Console.ReadLine();

        ITriangle triangle = null;

        switch (choice)
        {
            case "1":
                Console.Write("Введите длину стороны: ");
                double side = Convert.ToDouble(Console.ReadLine());
                triangle = new EquilateralTriangle(side);
                break;

            case "2":
                Console.Write("Введите длину основания: ");
                double baseSide = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите высоту: ");
                double heightSide = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите длину гипотенузы: ");
                double hypotenuseSide = Convert.ToDouble(Console.ReadLine());
                triangle = new RightTriangle(baseSide, heightSide, hypotenuseSide);
                break;

            default:
                Console.WriteLine("Некорректный ввод!");
                return;
        }

        Console.WriteLine($"Площадь: {triangle.GetArea()}");
        Console.WriteLine($"Периметер: {triangle.GetPerimeter()}");
    }
}


