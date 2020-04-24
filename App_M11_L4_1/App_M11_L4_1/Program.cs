using System;

namespace App_M11_L4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obiekt1 = new MyClass();
            MyClass obiekt2 = new MyClass(5);

            Console.WriteLine(obiekt1.Pole);
            Console.WriteLine(obiekt2.Pole);
        }
    }
}
