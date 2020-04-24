using System;
using System.IO;

namespace App_M20_L2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                File.ReadAllLines("test.txt");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Plik nie istnieje");
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Coś się stało");
                throw;
            }
        }
    }
}