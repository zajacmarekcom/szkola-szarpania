using CityBase.Estates;
using System.Collections.Generic;

namespace CityBase.Data
{
    interface IDatabase
    {
        void Add(Estate estate);
        void Remove(int number);
        Estate Get(int number);
        IEnumerable<Estate> GetAll();
    }
}
