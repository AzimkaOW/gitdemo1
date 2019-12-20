using System;
using System.Linq;

namespace _2
{
    public class Fmax
    {
        static void Main(string[] args)
        {
        }
        public static int FmaxAr(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}