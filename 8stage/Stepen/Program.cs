using System;
using System.Collections.Generic;
using System.Linq;

namespace Polynome
{
    class Program
    {
        static void Main()
        {
            //var p1 = new Polynom(2,1,0,5);
            //var p2 = new Polynom(2,3,4);
            //var p3 = p1 + p2;
            //for (int i = 0; i < p3.coefficients.Length; i++)
            //{
            //    Console.WriteLine(p3.coefficients[i]);
            //}

            var z = new Polynom(1, 2, 3, 4);
            var x = new Polynom(1, 2, 3);
            if (z == x)
            {
                Console.WriteLine("Da");
            }
            else Console.WriteLine("Net");

        }
    }

    public class Polynom
    {
        public override bool Equals(object o)
        {
            return true;
        }
        public override int GetHashCode()
        {
            return 0;
        }

        public double[] coefficients;

        public Polynom(params double[] coefficients)
        {
            this.coefficients = coefficients;
        }
        public static Polynom operator *(Polynom polynom1, Polynom polynom2)
        {
            double[] coeffs = new double[polynom1.coefficients.Length + polynom2.coefficients.Length - 1];
            for (int i = 0; i < polynom1.coefficients.Length; ++i)
                for (int j = 0; j < polynom2.coefficients.Length; ++j)
                    coeffs[i + j] += polynom1.coefficients[i] * polynom2.coefficients[j];
            return new Polynom(coeffs);
        }
        public static Polynom operator +(Polynom polynom1, Polynom polynom2)
        {
            if (polynom1.coefficients.Length >= polynom2.coefficients.Length)
            {
                for (int i = 0; i < polynom2.coefficients.Length; i++)
                {
                    polynom1.coefficients[polynom1.coefficients.Length - i - 1] = polynom1.coefficients[polynom1.coefficients.Length - i - 1] + polynom2.coefficients[polynom2.coefficients.Length - i - 1];
                }
                return polynom1;
            }
            else
            {
                for (int i = 0; i < polynom1.coefficients.Length; i++)
                {
                    polynom2.coefficients[polynom2.coefficients.Length - i - 1] = polynom1.coefficients[polynom1.coefficients.Length - i - 1] + polynom2.coefficients[polynom2.coefficients.Length - i - 1];
                }
                return polynom2;
            }
        }
        public static Polynom operator -(Polynom polynom1, Polynom polynom2)
        {
            if (polynom1.coefficients.Length >= polynom2.coefficients.Length)
            {
                for (int i = 0; i < polynom2.coefficients.Length; i++)
                {
                    polynom1.coefficients[polynom1.coefficients.Length - i - 1] = polynom1.coefficients[polynom1.coefficients.Length - i - 1] - polynom2.coefficients[polynom2.coefficients.Length - i - 1];
                }
                return polynom1;
            }
            else
            {
                for (int i = 0; i < polynom1.coefficients.Length; i++)
                {
                    polynom2.coefficients[polynom2.coefficients.Length - i - 1] = polynom1.coefficients[polynom1.coefficients.Length - i - 1] - polynom2.coefficients[polynom2.coefficients.Length - i - 1];
                }
                return polynom2;
            }
        }
        public static bool operator ==(Polynom polynom1, Polynom polynom2)
        {
            if (Enumerable.SequenceEqual(polynom2.coefficients, polynom1.coefficients))
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Polynom polynom1, Polynom polynom2)
        {
            if (Enumerable.SequenceEqual(polynom2.coefficients, polynom1.coefficients))
            {
                return false;
            }
            else return true;
        }
        public static Polynom operator /(Polynom polynom1, int a)
        {
            for (int i = 0; i < polynom1.coefficients.Length; i++)
            {
                polynom1.coefficients[i] = polynom1.coefficients[i] / a;
            }
            return polynom1;
        }
        public static Polynom operator *(Polynom polynom1, int a)
        {
            for (int i = 0; i < polynom1.coefficients.Length; i++)
            {
                polynom1.coefficients[i] = polynom1.coefficients[i] * a;
            }
            return polynom1;
        }
        public static Polynom operator /(Polynom dividend, Polynom divisor)
        {
            double[] quotient;
            double[] remainder;
            if (dividend.coefficients.Last() == 0)
            {
                throw new ArithmeticException("Старший член многочлена делимого не может быть 0");
            }
            if (divisor.coefficients.Last() == 0)
            {
                throw new ArithmeticException("Старший член многочлена делителя не может быть 0");
            }
            remainder = (double[])dividend.coefficients.Clone();
            quotient = new double[remainder.Length - divisor.coefficients.Length + 1];
            for (int i = 0; i < quotient.Length; i++)
            {
                double coeff = remainder[remainder.Length - i - 1] / divisor.coefficients.Last();
                quotient[quotient.Length - i - 1] = coeff;
                for (int j = 0; j < divisor.coefficients.Length; j++)
                {
                    remainder[remainder.Length - i - j - 1] -= coeff * divisor.coefficients[divisor.coefficients.Length - j - 1];
                }
            }
            return new Polynom(quotient);
        }
        public static Polynom operator %(Polynom dividend, Polynom divisor)
        {
            double[] quotient;
            double[] remainder;
            if (dividend.coefficients.Last() == 0)
            {
                throw new ArithmeticException("Старший член многочлена делимого не может быть 0");
            }
            if (divisor.coefficients.Last() == 0)
            {
                throw new ArithmeticException("Старший член многочлена делителя не может быть 0");
            }
            remainder = (double[])dividend.coefficients.Clone();
            quotient = new double[remainder.Length - divisor.coefficients.Length + 1];
            for (int i = 0; i < quotient.Length; i++)
            {
                double coeff = remainder[remainder.Length - i - 1] / divisor.coefficients.Last();
                quotient[quotient.Length - i - 1] = coeff;
                for (int j = 0; j < divisor.coefficients.Length; j++)
                {
                    remainder[remainder.Length - i - j - 1] -= coeff * divisor.coefficients[divisor.coefficients.Length - j - 1];
                }
            }
            return new Polynom(remainder);
        }
    }
}
