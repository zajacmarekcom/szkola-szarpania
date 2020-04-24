using System;

namespace App_M16_L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Base baza = new Child();

            baza.BaseMethod();

            if (baza is Child child)
            {
                Console.WriteLine("Haha! Tak naprawdę jestem Child!");
                child.ChildMethod();
            }

            var x = baza as Child;
            x.ChildMethod();
        }
    }
}
