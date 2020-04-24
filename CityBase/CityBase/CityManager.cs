using CityBase.Data;
using CityBase.Estates;
using System.Linq;

namespace CityBase
{
    class CityManager
    {
        private IDatabase _database;
        public void Add(Estate estate)
        {
            if (ExistsOnList(estate.Number))
            {
                _database.Remove(estate.Number);
            }

            var toAdd = estate;

            if (estate.Number == 0)
            {
                var newNumber = GetNewNumber();

                if (toAdd is Office)
                {
                    var office = toAdd as Office;
                    toAdd = new Office(newNumber, estate.Address, estate.Width, estate.Length, estate.Price, estate.Owner, estate.AddedDate, office.Floors, office.MaxPeople);
                }
                else if (toAdd is Parcel)
                {
                    var parcel = toAdd as Parcel;
                    toAdd = new Parcel(newNumber, estate.Address, estate.Width, estate.Length, estate.Price, estate.Owner, estate.AddedDate, parcel.ParcelType);
                }

                _database.Add(toAdd);
            }
        }
        private bool ExistsOnList(int number)
        {
            return _database.GetAll().Any(x => x.Number == number);
        }

        private int GetNewNumber()
        {
            var all = _database.GetAll();
            if (all.Any())
            {
                return all.Max(x => x.Number) + 1;
            }
            return 1;
        }
    }
}
