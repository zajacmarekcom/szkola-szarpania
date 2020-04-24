using System;

namespace App_M11_L5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            int x = 2;

            int y = 2 * x;

            var z = Math.Max(y, x);

            obj.Out(out x);

            Console.WriteLine(x); 
        }
    }
}
