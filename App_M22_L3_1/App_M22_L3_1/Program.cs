using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace App_M22_L3_1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await File.WriteAllTextAsync("test.txt", "Test content");
            Console.WriteLine("Hello World!");
        }
    }
}
