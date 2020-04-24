using CityBase.Estates;
using System.Collections.Generic;
using System.Linq;

namespace CityBase.Data
{
    class MemoryDatabase : IDatabase
    {
        private List<Estate> Estates { get; }

        public MemoryDatabase()
        {
            Estates = new List<Estate>();
        }

        public void Add(Estate estate)
        {
            Estates.Add(estate);
        }

        public IEnumerable<Estate> GetAll()
        {
            return Estates;
        }

        public void Remove(int number)
        {
            var toRemove = Estates.Single(x => x.Number == number);
            Estates.Remove(toRemove);
        }

        public Estate Get(int number)
        {
            return Estates.SingleOrDefault(x => x.Number == number);
        }
    }
}
