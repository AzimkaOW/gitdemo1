using System;
using System.Linq;

namespace _4
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static string concat(string fstr, string sstr)
        {
            fstr += sstr;
            fstr = new string(fstr.Distinct().ToArray());
            return fstr;
        }
    }
}
