using System;

namespace App_6_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int? maybe = 2;
            maybe = null;

            int a = maybe.HasValue ? maybe.Value : 0;
        }
    }
}
