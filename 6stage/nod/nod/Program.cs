using System;

namespace nod
{
    public static class lol
    {
        //число нечетное
        public static bool IsOdd(this int num) => (num & 1) == 1;

        //число четное
        public static bool IsEven(this int num) => (num & 1) == 0;

        //быстрое умножение на два
        public static int Mul2(this int n) => n << 1;

        //быстрое деление на два
        public static int Div2(this int n) => n >> 1;
    } // упрощенные действия сравнения, деления и умножения в int


    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(MnodBIN(arr));
            Console.WriteLine(MnodEv(arr));
        }// для проверки
       
    }
    public class NOD
    {
        delegate int MNodez(int[] arr);
        delegate int Nod(int a, int b);
        
        static int EvklidNod(int[] arr)
        {
            MNodez del = MnodEv;
            return del(arr);
        }
        static int BinarNod(int[] arr)
        {
            MNodez del = MnodBIN;
            return del(arr);
        }


        static int MnodEv(int[] arr)
        {
            Nod ez = nod;
            int NOD = 1;
            NOD = ez(arr[0], arr[1]);
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % NOD != 0)
                {
                    NOD = ez(arr[i], NOD);
                }
            }
            return NOD;
        }// простой Евклид
        static int MnodBIN(int[] arr)
        {
            Nod ha = binarA;
            int NOD = 1;
            NOD = ha(arr[0], arr[1]);
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % NOD != 0)
                {
                    NOD = ha(arr[i], NOD);
                }
            }
            return NOD;
        }// через бинарный метод
        static int binarA(int a, int b)
        {
            if (a == b || a == 0)
                return b;

            if (b == 0)
                return a;

            if (a.IsEven())
            {
                return b.IsOdd()
                    ? binarA(a.Div2(), b)
                    : binarA(a.Div2(), b.Div2()).Mul2();
            }
            else if (b.IsEven())
            {
                return binarA(a, b.Div2());
            }
            else
            {
                return a > b
                    ? binarA((a - b).Div2(), b)
                    : binarA((b - a).Div2(), a);
            }
        }// нахождение нод бинарным методом
        private static void PrintArray(int[] arr)
        {

            for (int j = 0; j < arr.Length; j++)
            {
                Console.Write(arr[j] + " ");
            }
            Console.WriteLine();


        }// вывод матрицы
        static int nod(int a, int b)
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        } //нахождение нод у двух чисел обычным методом
    }
    


}
