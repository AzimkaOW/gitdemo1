using System;
using System.Globalization;

namespace TitleWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "The In";
            string fstr = "the quick brown fox";
            Console.WriteLine(TitleWord(str, fstr));
            Console.WriteLine(TitleWord(fstr));
        }
        public static string TitleWord(string Fstr, string Sstr)
        {
            TextInfo txtInfo = new CultureInfo("en-US", false).TextInfo;
            Fstr = Fstr.ToLower();
            Sstr = Sstr.ToLower();
            Fstr = txtInfo.ToTitleCase(Fstr);
            Sstr = txtInfo.ToTitleCase(Sstr);
            string[] words1 = Fstr.Split();
            string[] words2 = Sstr.Split();
            
            for (int i = 0; i < words1.Length; i++)
            {
                for (int j = 1; j < words2.Length; j++)
                {
                    if (words2[j] == words1[i])
                    {
                        words2[j] = words2[j].ToLower();
                    }
                }
            }
            string str = string.Join(" ", words2);
            return str;
        }
        public static string TitleWord(string str)
        {
            str = str.ToLower();
            TextInfo txtInfo = new CultureInfo("en-US", false).TextInfo;
            str = txtInfo.ToTitleCase(str);
            return str;
        }
    }
}
