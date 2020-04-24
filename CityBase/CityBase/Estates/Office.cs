using System;
using System.Collections.Generic;
using System.Text;

namespace CityBase.Estates
{
    class Office : Estate
    {
        public int Floors { get; }
        public int MaxPeople { get; }

        public Office(int number, string address, decimal width, decimal length,
            decimal price, Owner owner, DateTime addedDate, int floors, int maxPeople)
                : base(number, address, width, length, price, owner, addedDate)
        {
            Floors = floors;
            MaxPeople = maxPeople;
        }

        public override IEnumerable<string> AdditionalInfo()
        {
            return new List<string>()
            {
                $"Liczba pięter: {Floors}",
                $"Maksymalna liczba osób: {MaxPeople}"
            };
        }
    }
}
