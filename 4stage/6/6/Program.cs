using System;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество чисел в массиве");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] ar = new string [0];
            int j = 0;
            
            for (int i = 0; i < length; i++)
            {
                string check = Console.ReadLine();
                
                if (check.Contains('7'))
                {
                    
                    Array.Resize(ref ar, ar.Length + 1);
                    ar[j] = check;
                    j++;
                }
            }

            Console.WriteLine("полученные числа");
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(ar[i]);
            }
        }
    }
}
