using System;

namespace App_M13_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new DateTime(2020, 2, 10);
            var datetime = new DateTime(2020, 2, 10, 12, 30, 0);
            var datetime2 = new DateTime(2020, 2, 10, 12, 30, 0, 100);

            var now = DateTime.Now;

            //var weekLater = now.AddDays(7);

            //Console.WriteLine(weekLater.ToString("dd.MM.yyyy"));

            var myDate = DateTime.ParseExact("24.02.2020", "dd.MM.yyyy", null);

            Console.WriteLine(myDate.ToString("dd.MM.yyyy"));
        }
    }
}
