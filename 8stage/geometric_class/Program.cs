using System;

namespace geometric_class
{

    public class geometric
    {
        public class Triangle : geometric
        {
            public double a = 0, b = 0, c = 0;
            public double GetP()
            {
                double P = a + b + c;
                return P;
            }
            public double GetS()
            {
                double p = GetP();
                double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return S;

            }
        }
        public class Circle : geometric
        {
            public double Rad = 0;
            public double GetP()
            {
                double P = Rad * 2 * Math.PI;
                return P;
            }
            public double GetS()
            {
                double S = Rad * Rad * Math.PI;
                return S;
            }
        }
        public class Rectangle : geometric
        {
            public double lengt = 0;
            public double hight = 0;
            public double GetP()
            {
                double P = lengt * 2 + hight * 2;
                return P;
            }
            public double GetS()
            {
                double S = lengt * hight;
                return S;
            }
        }
        public class Kvadrat : geometric
        {
            public double lenght = 0;
            public double GetP()
            {
                double P = lenght * 4;
                return P;
            }
            public double GetS()
            {
                double S = lenght * lenght;
                return S;
            }

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            geometric.Triangle a = new geometric.Triangle { a = 1, b = 2, c = 3 };
            Console.WriteLine(a.GetP());
        }
    }

}
