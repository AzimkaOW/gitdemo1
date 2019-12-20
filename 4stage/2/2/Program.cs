using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int Fmax(int[] array)
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
