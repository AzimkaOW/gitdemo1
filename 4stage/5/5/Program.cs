using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, f = "";
            a = Convert.ToString(Console.ReadLine());
            char[] arr = a.ToString().ToCharArray();
            Console.WriteLine(FindNextBiggerNumber(arr, f, a));
        }
        private static string FindNextBiggerNumber(char[] arr, string f, string a)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            f = String.Concat<char>(arr);
            if (f != a)
            {
            }
            else f = "-1";
            return f;
        }
    }
    
      
}
