using System;
using System.Threading.Tasks;

namespace App_M22_L3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyAsyncClass();

            var count =myClass.GetLinesCount("file.txt").Result;

            Console.WriteLine(count);
        }
    }
}
