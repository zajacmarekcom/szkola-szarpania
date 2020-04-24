using System;
using System.Collections.Generic;

namespace CityBase.Estates
{
    abstract class Estate
    {
        public int Number { get; }
        public string Address { get; }
        public decimal Width { get; }
        public decimal Length { get; }
        public decimal Price { get; }
        public Owner Owner { get; }
        public DateTime AddedDate { get; }
        public DateTime ControlDate { get; }

        public decimal Area
        {
            get
            {
                return Width * Length;
            }
        }

        public decimal PricePerMeter
        {
            get
            {
                return Price / Area;
            }
        }

        public virtual IEnumerable<string> AdditionalInfo()
        {
            return new List<string>();
        }

        public Estate(int number, string address, decimal width, decimal length,
            decimal price, Owner owner, DateTime addedDate)
        {
            Number = number;
            Address = address;
            Width = width;
            Length = length;
            Price = price;
            Owner = owner;
            AddedDate = addedDate;
            ControlDate = AddedDate.AddYears(3);
        }

        public Estate(string address, decimal width, decimal length,
            decimal price, Owner owner, DateTime addedDate)
        {
            Number = 0;
            Address = address;
            Width = width;
            Length = length;
            Price = price;
            Owner = owner;
            AddedDate = addedDate;
            ControlDate = AddedDate.AddYears(3);
        }
    }
}
