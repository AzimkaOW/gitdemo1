using System;

namespace Stepen
{
    public class Mnogochlen
    {
        public string mnogochlen = "";
        public string Vstepen(int stepen)
        {
            if (stepen == 0)
            {
                mnogochlen = "1";
            }
            else if (stepen != 1) 
            {
                mnogochlen = "(" + mnogochlen + ")^" + Convert.ToString(stepen);
            }
            return mnogochlen;
        }
        public static Mnogochlen operator +(Mnogochlen c1, Mnogochlen c2)
        {
            if (c1.mnogochlen != c2.mnogochlen) return new Mnogochlen { mnogochlen = c1.mnogochlen + " + " + c2.mnogochlen };
            else return new Mnogochlen { mnogochlen = "2(" + c1.mnogochlen + ")" };
        }
        public static Mnogochlen operator -(Mnogochlen c1, Mnogochlen c2)
        {
            if (c1.mnogochlen != c2.mnogochlen) return new Mnogochlen { mnogochlen = c1.mnogochlen + " - " + c2.mnogochlen };
            else return new Mnogochlen { mnogochlen = "0" };
        }
        public static Mnogochlen operator /(Mnogochlen c1, Mnogochlen c2)
        {
            if (c1.mnogochlen!= c2.mnogochlen) return new Mnogochlen { mnogochlen = "(" + c1.mnogochlen + ") / (" + c2.mnogochlen + ")" };
            else return new Mnogochlen { mnogochlen = "1" };
        }
        public static Mnogochlen operator *(Mnogochlen c1, Mnogochlen c2)
        {
            if (c1.mnogochlen != c2.mnogochlen) return new Mnogochlen { mnogochlen = "(" + c1.mnogochlen + ") * (" + c2.mnogochlen + ")" };
            else return new Mnogochlen { mnogochlen = "(" + c1.mnogochlen + ")^2" };
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Mnogochlen z = new Mnogochlen();
            Mnogochlen c = new Mnogochlen();
            c.mnogochlen = "2a + 3c";
            z.mnogochlen = "2a + 3c";
            z = z + c;
            z.Vstepen(5);
            Console.WriteLine(z.mnogochlen);
        }
    }
}
