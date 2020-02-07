using System;

namespace FindNthRoot
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SqrtN(-0.01, 2, 0.0001));
            
        }

        //static double Pow(double a, int pow)
        //{
        //    double result = 1;
        //    for (int i = 0; i < pow; i++) result *= a;
        //    return result;
        //}

        public static double SqrtN(double A, double n, double eps)
        {
            try
            {
                if (eps < 0 || n < 0 || (A < 0 && n % 2 == 0))
                {
                    throw new ArgumentException("ArgumentException");
                }
                int colv = 0;
                double teps = eps;
                do
                {
                    teps *= 10;
                    colv++;
                } while (teps < 1);

                var x0 = A / n;
                var x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));

                while (Math.Abs(x1 - x0) > eps)
                {
                    x0 = x1;
                    x1 = (1 / n) * ((n - 1) * x0 + A / Math.Pow(x0, (int)n - 1));
                }

                return Math.Round(x1, colv);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException");
                return 0;
            }
            
            
           
        }
    }
}