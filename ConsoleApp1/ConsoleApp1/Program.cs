using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Fraction
        {
            public int Numerator { get; private set; }
            public int Denominator { get; private set; }

            public Fraction(int numerator, int denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
            }

            public static Fraction operator +(Fraction f1, Fraction f2)
            {
                return new Fraction(f1.Numerator * f2.Denominator + f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
            }

            public static Fraction operator -(Fraction f1, Fraction f2)
            {
                return new Fraction(f1.Numerator * f2.Denominator - f2.Numerator * f1.Denominator, f1.Denominator * f2.Denominator);
            }

            public static Fraction operator *(Fraction f1, Fraction f2)
            {
                return new Fraction(f1.Numerator * f2.Numerator, f1.Denominator * f2.Denominator);
            }

            public static Fraction operator /(Fraction f1, Fraction f2)
            {
                return new Fraction(f1.Numerator * f2.Denominator, f1.Denominator * f2.Numerator);
            }

            public static bool operator ==(Fraction f1, Fraction f2)
            {
                return f1.Numerator == f2.Numerator && f1.Denominator == f2.Denominator;
            }

            public static bool operator !=(Fraction f1, Fraction f2)
            {
                return !(f1 == f2);
            }

            public static bool operator >(Fraction f1, Fraction f2)
            {
                return f1.Numerator * f2.Denominator > f2.Numerator * f1.Denominator;
            }

            public static bool operator <(Fraction f1, Fraction f2)
            {
                return f1.Numerator * f2.Denominator < f2.Numerator * f1.Denominator;
            }

            public static Fraction operator ++(Fraction f)
            {
                return new Fraction(f.Numerator + f.Denominator, f.Denominator);
            }

            public static Fraction operator --(Fraction f)
            {
                return new Fraction(f.Numerator - f.Denominator, f.Denominator);
            }

            public override string ToString()
            {
                return $"{Numerator}/{Denominator}";
            }
        }

        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(1, 3);

            Console.WriteLine($"Fraction 1: {fraction1}");
            Console.WriteLine($"Fraction 2: {fraction2}");

            Fraction sum = fraction1 + fraction2;
            Console.WriteLine($"Sum: {sum}");

            Fraction difference = fraction1 - fraction2;
            Console.WriteLine($"Difference: {difference}");

            Fraction product = fraction1 * fraction2;
            Console.WriteLine($"Product: {product}");

            Fraction quotient = fraction1 / fraction2;
            Console.WriteLine($"Quotient: {quotient}");

            Console.WriteLine($"Is fraction1 equal to fraction2? {fraction1 == fraction2}");
            Console.WriteLine($"Is fraction1 not equal to fraction2? {fraction1 != fraction2}");

            Console.WriteLine($"Is fraction1 greater than fraction2? {fraction1 > fraction2}");
            Console.WriteLine($"Is fraction1 less than fraction2? {fraction1 < fraction2}");

            Fraction incremented = fraction1++;
            Console.WriteLine($"Incremented fraction1: {incremented}");

            Fraction decremented = fraction2--;
            Console.WriteLine($"Decremented fraction2: {decremented}");
        }
    }
}
