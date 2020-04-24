using System;
using System.Collections.Generic;

namespace CityBase.Estates
{
    class Parcel : Estate
    {
        public ParcelType ParcelType { get; }

        public Parcel(int number, string address, decimal width, decimal length,
            decimal price, Owner owner, DateTime addedDate, ParcelType type)
                :base(number, address, width, length, price, owner, addedDate)
        {
            ParcelType = type;
        }

        public override IEnumerable<string> AdditionalInfo()
        {
            return new List<string>()
            {
                $"Typ: {(ParcelType == ParcelType.Building ? "Budowlana" : "Rolna")}"
            };
        }
    }
}
