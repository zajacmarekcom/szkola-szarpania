using System;
using System.Threading.Tasks;

namespace App_M22_L2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2 * Math.Sqrt(13);
            Console.WriteLine(x);

            var task = Task.Run<double>(() => 2 * x);
            var task2 = new Task<double>(Do, x);
            task2.Start();

            var r1 = task.Result;
            var r2 = task2.Result;

            Console.WriteLine(r1);
            Console.WriteLine(r2);
        }

        static double Do(object value)
        {
            double x = (double)value;

            return 4 * x;
        }
    }
}
