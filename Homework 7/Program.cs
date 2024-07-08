using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите числитель первой дроби:");
                int numerator1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите знаменатель первой дроби:");
                int denominator1 = Convert.ToInt32(Console.ReadLine());

                Fraction frac1 = new Fraction(numerator1, denominator1);

                Console.WriteLine("Введите числитель второй дроби:");
                int numerator2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите знаменатель второй дроби:");
                int denominator2 = Convert.ToInt32(Console.ReadLine());

                Fraction frac2 = new Fraction(numerator2, denominator2);

                Fraction sum = frac1 + frac2;
                Fraction difference = frac1 - frac2;
                Fraction multiplication = frac1 * frac2;
                Fraction division = frac1 / frac2;

                Console.WriteLine($"{frac1} + {frac2} = {sum} = {sum.ToDouble()}");
                Console.WriteLine($"{frac1} - {frac2} = {difference} = {difference.ToDouble()}");
                Console.WriteLine($"{frac1} * {frac2} = {multiplication} = {multiplication.ToDouble()}");
                Console.WriteLine($"{frac1} / {frac2} = {division} = {division.ToDouble()}");

                Console.WriteLine($"{frac1} == {frac2} : {frac1 == frac2}");
                Console.WriteLine($"{frac1} != {frac2} : {frac1 != frac2}");
            }

            catch (Exception)
            {
                Console.WriteLine("Ошибка: введено некорректное значение.");
            }
        }
    }

    public class Fraction
    {
        int numerator;
        int denominator;

        public int Numerator
        {
            get => numerator;
            set => numerator = value;
        }

        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0)
                throw new Exception();
                denominator = value;
            }
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Reduction();
        }

        void Reduction()
        {
            int largest_common_divisor = Largest_Common_Divisor(Numerator, Denominator);
            Numerator /= largest_common_divisor;
            Denominator /= largest_common_divisor;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        int Largest_Common_Divisor(int a, int b)
        {
            while (b != 0)
            {
                int c = b;
                b = a % b;
                a = c;
            }
            return Math.Abs(a);
        }
        public double ToDouble()
        {
            return (double)Numerator / Denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new Fraction(numerator, denominator);
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Numerator == b.Numerator && a.Denominator == b.Denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            if (obj is Fraction)
            {
                var other = (Fraction)obj;
                return this == other;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
