using System;
using System.Linq;
namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static string sum(string a, string b)
        {
            string sum = "";
            int c = 0, d = 0;

            int max = Math.Max(a.Length, b.Length);
            if (a.Length < b.Length)
                a = a.PadLeft(max, '0');
            else
                if (a.Length > b.Length)
                b = b.PadLeft(max, '0');

           
            for (int i = max - 1; i >= 0; i--)
            {
                c = (d + (int)Char.GetNumericValue(a[i]) + (int)Char.GetNumericValue(b[i])) % 10;
                sum += c.ToString();
                d = (d + (int)Char.GetNumericValue(a[i]) + (int)Char.GetNumericValue(b[i])) / 10;
            }

            return new String(sum.Reverse().ToArray());
        }
    }
}
