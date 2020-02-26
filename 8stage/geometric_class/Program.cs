using System;

namespace geometric_class
{

    public class geometric
    {
        public double frst = 0;
        public double sec = 0;
        public double thr = 0;
        public double rad = 0;
    }
        public class Triangle : geometric
        {
            public double GetP()
            {
                double P = sec + thr + frst;
                return P;
            }
            public double GetS()
            {
                double p = GetP();
                double S = Math.Sqrt(p * (p - sec) * (p - frst) * (p - thr));
                return S;
            }
        }
        public class Circle : geometric
        {
            public double GetP()
            {
                double P = rad * 2 * Math.PI;
                return P;
            }
            public double GetS()
            {
                double S = rad * rad * Math.PI;
                return S;
            }
        }
        public class Rectangle : geometric
        {
            public double GetP()
            {
                double P = frst * 2 + sec * 2;
                return P;
            }
            public double GetS()
            {
                double S = frst * sec;
                return S;
            }
        }
        public class Kvadrat : geometric
        {
            public double GetP()
            {
                double P = frst * 4;
                return P;
            }
            public double GetS()
            {
                double S = frst * frst;
                return S;
            }

        }
  
    public class Program
    {
        static void Main(string[] args)
        {
            Triangle a = new Triangle {frst = 1, sec = 2, thr = 3 };
            Console.WriteLine(a.GetP());
        }
    }

}
