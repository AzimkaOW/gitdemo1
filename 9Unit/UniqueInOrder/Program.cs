using System;
using System.Linq;
using System.Collections.Generic;

namespace UniqueInOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaaaddsssddddaaaaa";
            acc<int>.UniqueInOrder(str);
            List<double> newlist = new List<double>{ 1.1, 2.2, 2.2, 3.3 };
            List<double> Snew;
            Snew = acc<double>.UniqueInOrder(newlist);
            for (int i = 0; i < Snew.Count; i++)
            {
                Console.WriteLine(Snew[i]);
            }
        }
        class acc<T>
        {
            public static string UniqueInOrder(string str)
            {
                str = new string(str.Distinct().ToArray());
                return str;
            }
            public static List<T> UniqueInOrder(List<T> l)
            {
                l = new List<T>(l.Distinct());
                return l;
            }
        }
    }
}
