using System;

namespace revers
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "battle no requires which that is victory greatest The";
            Console.WriteLine(str);
            Console.WriteLine(revers(str));
        }
        public static string revers(string str)
        {
            string[] Sstr = str.Split();
            Array.Reverse(Sstr);
            str = string.Join(" ",Sstr);
            return str;
        }
    }
}
