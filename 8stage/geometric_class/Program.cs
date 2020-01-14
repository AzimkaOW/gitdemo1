using System;

namespace geometric_class
{
    public class Triangle
    {
        public double a = 0, b = 0, c = 0;
        public double getP()
        {
            double P = a + b + c;
            return P;
        }
        public double getS()
        {
            double p = getP();
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;

        }
    }
    public class Circle
    {
        public double Rad = 0;
        public double getP()
        {
            double P = Rad * 2 * Math.PI;
            return P;
        }
        public double getS()
        {
            double S = Rad * Rad * Math.PI;
            return S;
        }
    }
    public class Rectangle
    {
        public double lengt = 0;
        public double hight = 0;
        public double getP()
        {
            double P = lengt * 2 + hight * 2;
            return P;
        }
        public double getS()
        {
            double S = lengt * hight;
            return S;
        }
    }
    public class kvadrat
    {
        public double lenght = 0;
        public double getP()
        {
            double P = lenght * 4;
            return P;
        }
        public double getS()
        {
            double S = lenght * lenght;
            return S;
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            kvadrat a = new kvadrat();
            a.lenght = 1;
            Console.WriteLine(a.getP());
        }
    }
}
