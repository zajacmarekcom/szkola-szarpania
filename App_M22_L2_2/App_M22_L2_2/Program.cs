using System;
using System.Threading;

namespace App_M22_L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i = 0; i < 5; i++)
            {
                var thread = new Thread(DoDo);
                thread.Start(i);
            }
        }

        static void DoDo(object value)
        {
            var i = (int)value;
            Console.WriteLine($"Wątek {i}");
        }
    }
}
