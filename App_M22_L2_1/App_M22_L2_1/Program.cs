using System;
using System.Threading;

namespace App_M22_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(SayHello);
            thread.Start();
            for(var i = 0; i < 20; i++)
            {
                Console.WriteLine("Main");
                Thread.Sleep(500);
            }
        }

        public static void SayHello()
        {
            for (var i = 0; i < 20; i++)
            {
                Console.WriteLine("SayHello");
                Thread.Sleep(500);
            }
        }
    }
}
