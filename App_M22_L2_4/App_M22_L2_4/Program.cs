using System;
using System.Threading;
using System.Threading.Tasks;

namespace App_M22_L2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Task(Do);
            task.Start();

            // kolejne działania
            var x = 2 * Math.Sqrt(13);
            Console.WriteLine(x);

            task.Wait();
        }

        static void Do()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Zadanie");
        }
    }
}
