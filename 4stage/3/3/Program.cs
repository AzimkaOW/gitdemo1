using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int fnum = 0;
            int snum = 0;
            int i;
            int z = -1;
            Console.WriteLine("Кол-во элементов массива");
            
            int colvo = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[colvo];
            for (i = 0; i < colvo; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                fnum += array[i];
            }
            i--;
            if (snum == (fnum - array[0]))
            {
                Console.WriteLine(0);
                z = 1;
            }
            else
            if (snum == (fnum - array[i]))
            {
                Console.WriteLine(i);
                z = 1;
            }
            else 
            {
                fnum -= array[0];
                for (i = 1; i < colvo - 1; i++)
                {
                    snum += array[i - 1];
                    fnum -= array[i];
                    if (fnum == snum)
                    {
                        Console.WriteLine(i);
                        z = 1;
                    }
                }
            }
            if (z != 1)
            {
                Console.WriteLine("null");
            }
        }
    }
}
