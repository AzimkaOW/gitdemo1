using System;
using System.Linq;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fstr, sstr;
            fstr = Convert.ToString(Console.ReadLine());
            sstr = Convert.ToString(Console.ReadLine());
            fstr += sstr;
            fstr = new string(fstr.Distinct().ToArray());
            Console.WriteLine(fstr);

        }
    }
}
