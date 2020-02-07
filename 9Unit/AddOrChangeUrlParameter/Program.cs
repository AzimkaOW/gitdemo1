using System;

namespace AddOrChangeUrlParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sstr = "www.example.com?key=oldValue";
            string fstr = "key=newValue";
            Console.WriteLine(AddOrChangeUrlParameter(sstr,fstr));
        }
        public static string AddOrChangeUrlParameter(string Sstr, string Fstr)
        {
            string str = null;
            string key = Fstr.Remove(Fstr.IndexOf("=") + 1,Fstr.Length - Fstr.IndexOf("=") - 1);

            if (Sstr.Length == Sstr.IndexOf("com") + 3)
            {
                str = Sstr + "?" + Fstr;
            }
            else if (Sstr.Contains(key))
            {
                int index = Sstr.IndexOf(key);
                do
                {
                    Sstr = Sstr.Remove(index, 1);
                } while (Sstr.Length != index && Sstr[index] != '&');
                str = Sstr.Insert(index, Fstr);
                
            }
            else str = Sstr + "&" + Fstr;
            return str;
        }
    }
}
