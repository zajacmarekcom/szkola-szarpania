using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App_M22_L2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task>();

            for(var i = 0; i < 10; i++)
            {
                tasks.Add(Task.Run(() => Console.WriteLine(i)));
            }

            Task.WaitAll(tasks.ToArray());
        }
    }
}
