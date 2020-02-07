using System;
using System.Threading;
namespace _11Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            Countdown Counter = new Countdown();
            Alo alo = new Alo();

            Counter.Mes += alo.Message;

            Counter.Count(5);

        }
        public class Countdown
        {
            public delegate void Del();
            public event Del Mes;
            public void Count(int j)
            {
                
                for (int i = j; i >= 0; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(500);
                }
                Mes();
                
            }
        }
        class Alo
        {
            public void Message()
            {
                Console.WriteLine("it's time to ur message");
            }

        }
    }
}
