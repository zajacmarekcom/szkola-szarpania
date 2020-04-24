using System;

namespace App_M18_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int> x = () => 10;

            Func<int, string, int> z = (x, y) =>
            {
                return x;
            };

            int a = x();
        }
    }
}
