using System;

namespace Ieee754
{
    public static class Double
    {
        public static string Ieee754(this double a)
        {
            // Предустановленные значения
            if (a == double.MinValue)
            {
                return "1111111111101111111111111111111111111111111111111111111111111111";
            }
            if (a == double.MaxValue)
            {
                return "0111111111101111111111111111111111111111111111111111111111111111";
            }
            if (a == double.Epsilon)
            {
                return "0000000000000000000000000000000000000000000000000000000000000001";
            }
            if (a == double.NaN)
            {
                return "1111111111111000000000000000000000000000000000000000000000000000";
            }
            if (a == double.NegativeInfinity)
            {
                return "1111111111110000000000000000000000000000000000000000000000000000";
            }
            if (a == double.PositiveInfinity)
            {
                return "0111111111110000000000000000000000000000000000000000000000000000";
            }
            // Предустановленные значения 
            string str;
            string znak = "0";
            string exp = "00000000 ";
            string mant = "00000000000000000000000";
            int expp = 127;
            string cel = "";
            string drob = "";
            int i = 0;

            if (a < 0)
            {
                znak = "1";
                a = a * (-1);
            } // при отрицательном числе заменяем первый символ на 1 и делаем его положительным для удобства

            int z = Convert.ToInt32(Math.Truncate(a));

            if (a >= 1)
            {
                a = a - z;
                cel = Convert.ToString(z, 2);
                drob = ToBinFrac(a, 23);
                expp = expp + cel.Length - 1;
                exp = Convert.ToString(expp, 2);
                if (exp.Length != 8)
                {
                    while (exp.Length != 8)
                    {
                        exp = exp.Insert(0, "0");
                    }
                }// если символов меньше 8 в exp
                cel = cel + drob;
                mant = cel.Substring(1);
            } // если число имеет целую часть
            else
            {
                drob = ToBinFrac(a, 23);
                i = TBF(a, 23);
                expp = expp - i;
                exp = Convert.ToString(expp, 2);
                if (exp.Length != 8)
                {
                    while (exp.Length != 8)
                    {
                        exp = exp.Insert(0, "0");
                    }
                }// если символов меньше 8 в exp
                cel = cel + drob;
                mant = cel.Substring(1);
            }// если не имеет целую часть
            str = znak + " " + exp + " " + mant;
            if (str.Length > 34)
            {
                do
                {
                    str = str.Remove(str.Length - 1);
                } while (str.Length > 34);
            }
            return str;
        }
        public static string ToBinFrac(double frac, int len)
        {
            string str = "";
            
            int n = 0;
            while (n < len)
            {
                frac *= 2;
                if (frac > 1)
                {
                    str += "1";
                    frac -= 1;
                }
                if (frac == 1)
                {
                    str += "1";
                    frac -= 1;
                    for (int i = 0; i < len - n; i++)
                    {
                        str += "0";
                    }
                    break;
                }
                if (frac < 1)
                {
                    str += "0";
                }
                n++;
            }
            return str;
        }// преобразвоние дробной части в двоичную систему
        public static int TBF(double frac, int len)
        {
            string str = "";

            int n = 0;
            while (n < len)
            {
                frac *= 2;
                if (frac > 1)
                {
                    break;
                }
                if (frac == 1)
                {
                    for (int i = 0; i < len - n; i++)
                    {
                        str += "0";
                    }
                    break;
                }
                n++;
            }
            return n;
        }// счет exp в числе меньше 1


    }

    class Program
    {
        static void Main(string[] args)
        {
            double a;
            a = 1.625;
            Console.WriteLine(a.Ieee754());
        }

    }
}
