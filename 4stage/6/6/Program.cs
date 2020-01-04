using System;

namespace _6
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numberSourse = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            numberSourse = shodstva(numberSourse, 7);
            PrintArray(numberSourse);
        }
        private static void PrintArray(int[] arr)
        {
            
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[j] + " ");
                }
                
            

        }// вывод матрицы
        public static int[] shodstva(int[] arr, int z)
        {
            string s = Convert.ToString(z);
            int j = 0;
            int[] ar = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                string check = Convert.ToString(arr[i]);

                if (check.Contains(s))
                {

                    Array.Resize(ref ar, ar.Length + 1);
                    ar[j] = Convert.ToInt32(check);
                    j++;
                }
            }
            return ar;
        }
    }
}
