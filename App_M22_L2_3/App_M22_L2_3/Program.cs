using System;
using System.Threading;
using System.Threading.Tasks;

namespace App_M22_L2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // uruchamiamy zadanie
            var task = Task.Run(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Zadanie");
            });

            // kolejne działania
            var x = 2 * Math.Sqrt(13);
            Console.WriteLine(x);

            // czekamy aż zadanie się zakończy
            task.Wait();
        }
    }
}
