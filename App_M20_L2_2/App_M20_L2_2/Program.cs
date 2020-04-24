using System;

namespace App_M20_L2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var obj = new MyClass();
                obj.ThrowException();
            }
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
