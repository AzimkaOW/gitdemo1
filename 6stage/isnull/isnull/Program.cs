using System;

namespace isnull
{
    public static class inull
    {
        public static string IsNull(this int? a)
        {
            if (a.HasValue)
            {
                return "false";
            }
            else return "true";
        }
        public static string IsNull(this double? a)
        {
            if (a.HasValue)
            {
                return "false";
            }
            else return "true";
        }
        public static string IsNull(this string a)
        {
            if (a == null)
            {
                return "true";
            }
            else return "false";
        }
        public static string IsNull(this char? a)
        {
            if (a.HasValue)
            {
                return "false";
            }
            else return "true";
        }
        public static string IsNull(this bool? a)
        {
            if (a.HasValue)
            {
                return "false";
            }
            else return "true";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string a = null;
            Console.WriteLine(a.IsNull());
        }
    }
}
