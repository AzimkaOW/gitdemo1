using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int colvo = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[colvo];
            
            array[0] = Convert.ToInt32(Console.ReadLine());
            max = array[0];
            for (int i = 1; i < colvo; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (max < array[i]) 
                {
                    max = array[i];
                }
            }

            Console.WriteLine(max);


        }
    }
}
