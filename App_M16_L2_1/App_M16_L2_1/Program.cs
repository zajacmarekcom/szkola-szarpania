using System;

namespace App_M16_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = 1.22;
            int newValue = (int)value;

            Console.WriteLine(newValue);


            Base baza = new Child();

            Child dziecko = (Child)baza;
        }
    }
}
