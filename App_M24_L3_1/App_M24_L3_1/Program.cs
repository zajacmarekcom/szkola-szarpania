using System;

namespace App_M24_L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator(2, 4.0M);
            var x = calc.Calc(2.0M);
        }
    }
}
