using System;

namespace App_M8_L4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? parameter = 2;

            int result = parameter.HasValue ? parameter.Value : 0;
        }
    }
}
