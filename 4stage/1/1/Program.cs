using System;
using System.Linq;

namespace _1
{
    public class Insertnum
    {

        static void Main(string[] args)
        {
            int numberSourse = Convert.ToInt32(Console.ReadLine());
            int numberIn = Convert.ToInt32(Console.ReadLine());
            int i;
            int j;


            do
            {
                i = 32 - Convert.ToInt32(Console.ReadLine());
                j = 32 - Convert.ToInt32(Console.ReadLine());
                if (i < j)
                {
                    Console.WriteLine("\"i\" should be less then \"j\"");
                }
                else break;

            } while (true);

            Console.WriteLine(InsertNumber(numberSourse, numberIn, i, j));
        }

        public static int InsertNumber(int numberSourse, int numberIn, int i, int j)
        {

            string firstNum = "00000000000000000000000000000000";
            firstNum = firstNum.Remove(32 - Convert.ToString(numberSourse, 2).Length, Convert.ToString(numberSourse, 2).Length);
            firstNum = firstNum.Insert(32 - Convert.ToString(numberSourse, 2).Length, Convert.ToString(numberSourse, 2));

            string secondNum = "00000000000000000000000000000000";
            secondNum = secondNum.Remove(32 - Convert.ToString(numberIn, 2).Length, Convert.ToString(numberIn, 2).Length);
            secondNum = secondNum.Insert(32 - Convert.ToString(numberIn, 2).Length, Convert.ToString(numberIn, 2));

            string returnVal = firstNum;
            returnVal = returnVal.Remove(j - 1, i - j + 1);
            returnVal = returnVal.Insert(j - 1, secondNum.Substring(j - 1, i - j + 1));

            return Convert.ToInt32(returnVal, 2);
        }
    }
}
