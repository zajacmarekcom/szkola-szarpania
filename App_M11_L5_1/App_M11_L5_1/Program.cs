using System;

namespace App_M11_L5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            int x = 2;

            obj.Reference(ref x);

            Console.WriteLine(x);
        }
    }
}
