using System;

namespace _3
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public static int? sumLr(double[] array)
        {
            double fnum = 0;
            double snum = 0;
            int i;
            double z = -1;
            int ind = 0;
            
            for (i = 0; i < array.Length; i++)
            {
                fnum += array[i];
            }
            i--;
            if (snum == (fnum - array[0]))
            {
                ind = 0;
                z = 1;
            }
            else
            if (snum == (fnum - array[i]))
            {
                ind = i;
                z = 1;
            }
            else
            {
                fnum -= array[0];
                for (i = 1; i < array.Length - 1; i++)
                {
                    snum += array[i - 1];
                    fnum -= array[i];
                    if (fnum == snum)
                    {
                        ind = i;
                        z = 1;
                    }
                }
            }
            if (z != 1)
            {
                int? indd = null;
                return indd;
            }
            return ind;
        }
    }
}
