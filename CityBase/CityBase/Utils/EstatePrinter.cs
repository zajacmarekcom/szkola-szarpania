using CityBase.Estates;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBase.Utils
{
    class EstatePrinter
    {
        public static void Print(Estate estate)
        {
            Console.WriteLine($"{estate.Number} - {estate.Address}");
            Console.WriteLine($"Data dodania: {estate.AddedDate.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Data kontroli: {estate.ControlDate.ToString("dd-MM-yyyy")}");
            Console.WriteLine($"Właśność: {GetOwner(estate)}");
            Console.WriteLine($"Wymiary: {estate.Length}x{estate.Width}");
            Console.WriteLine($"Powierzchnia: {estate.Area}");
            Console.WriteLine($"Cena za m2: {estate.PricePerMeter}");
            foreach(var info in estate.AdditionalInfo())
            {
                Console.WriteLine(info);
            }
        }

        public static void Print(IEnumerable<Estate> estates)
        {
            foreach(var estate in estates)
            {
                Console.WriteLine($"{estate.Number} - {estate.Address} ({GetOwner(estate)})");
                Console.WriteLine($"Powierzchnia: {estate.Area}");
                Console.WriteLine($"Cena: {estate.Price}");
                Console.WriteLine("================");
            }
        }

        private static string GetOwner(Estate estate)
        {
            switch(estate.Owner)
            {
                case Owner.City:
                    return "Miasto";
                case Owner.Private:
                    return "Prywatny";
                case Owner.Other:
                    return "Inny";
            }

            return "";
        }
    }
}
