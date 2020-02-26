using System;

namespace sort
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество строк в массиве");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Количество чисел в строке");
            int b = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[a][];
            for (int i = 0; i < a; i++)
            {
                arr[i] = new int[b];
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //BubbleSortSum(arr, ">");
            BubbleSortMin_Max(arr, ">", "max");
            PrintArray(arr);
        }

        private static void PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

        }// вывод матрицы

        delegate int[][] Del(int[][] mas, string s); 
        delegate int[][] Zel(int[][] mas, string s, string z); 
        public static int[][] SortSum(int[][] mas, string s)
        {
            Del del = BubbleSortSum;
            return del(mas, s);
        }// сортировка по сумме с параметрами: матрица, знак(убывание>, возрастание<)
        public static int[][] SortMin_Max(int[][] mas, string s, string z)
        {
            Zel del = BubbleSortMin_Max;
            return del(mas, s, z);
        }// сортировка по макс/мин элементу с параметрами: матрица, знак(убывание>, возрастание<), макс/мин(max, min)


        public static int[][] BubbleSortSum(int[][] mas, string s)
        {
            int[] temp;
            int tmp;
            int[] zap = new int[mas.Length];
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    zap[i] += mas[i][j];
                }
            } // счет суммы
            if (s == ">")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (zap[i] < zap[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                            tmp = zap[i];
                            zap[i] = zap[j];
                            zap[j] = tmp;
                        }
                    }
                }
            } // по убыванию
            else
            if (s == "<")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (zap[i] > zap[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                            tmp = zap[i];
                            zap[i] = zap[j];
                            zap[j] = tmp;
                        }
                    }
                }
            } // по возрастанию 
            
            return mas;
        } // сортировка по сумме с параметрами: матрица, знак(убывание>, возрастание<)

        public static int[][] BubbleSortMin_Max(int[][] mas, string s, string z)
        {
            int[] temp;
            int tmp;
            
            int[] zap = new int[mas.Length];
            if (z == "max")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            zap[i] = mas[i][j];
                        } // присвоение первого элемента
                        if (zap[i] < mas[i][j] && j > 0)
                        {
                            zap[i] = mas[i][j];
                        }
                    }
                }
            }// если сортировка по максимальному
            if (z == "min")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = 0; j < mas[i].Length; j++)
                    {
                        if (j == 0)
                        {
                            zap[i] = mas[i][j];
                        } // присвоение первого элемента
                        if (zap[i] > mas[i][j] && j > 0)
                        {
                            zap[i] = mas[i][j];
                        }
                    }
                }
            }// если сортировка по минимальному
            if (s == ">")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (zap[i] < zap[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                            tmp = zap[i];
                            zap[i] = zap[j];
                            zap[j] = tmp;
                        }
                    }
                }
            } // по убыванию
            else
            if (s == "<")
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (zap[i] > zap[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                            tmp = zap[i];
                            zap[i] = zap[j];
                            zap[j] = tmp;
                        }
                    }
                }
            } // по возрастанию

            return mas;
        }// сортировка по макс/мин элементу с параметрами: матрица, знак(убывание>, возрастание<), макс/мин(max, min)
    }
}
