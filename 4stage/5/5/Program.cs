using System;

namespace _5
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            Console.WriteLine(FindNextBiggerNumber(a));
        }
        public static int FindNextBiggerNumber(int a)
        {
            string b = Convert.ToString(a);
            string f = "";
            char[] arr = a.ToString().ToCharArray();
            Array.Sort(arr);
            Array.Reverse(arr);
            f = String.Concat<char>(arr);
            if (f == b)
            {
                int ots = -1;
                return ots;
            }
            int ot = Convert.ToInt32(f);
            return ot;
        }
    }
    
      
}
