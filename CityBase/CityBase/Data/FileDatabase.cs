using CityBase.Estates;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CityBase.Data
{
    class FileDatabase : IDatabase
    {
        private string _path;
        private List<Estate> Estates;

        public FileDatabase(string path)
        {
            _path = path;
            LoadFile().Wait();
        }

        public void Add(Estate estate)
        {
            Estates.Add(estate);
            UpdateFile().Wait();
        }

        public IEnumerable<Estate> GetAll()
        {
            return Estates;
        }

        public void Remove(int number)
        {
            var toRemove = Estates.Single(x => x.Number == number);
            Estates.Remove(toRemove);
            UpdateFile().Wait();
        }

        public Estate Get(int number)
        {
            return Estates.SingleOrDefault(x => x.Number == number);
        }

        private async Task UpdateFile()
        {
            var lines = new List<string>();

            foreach (var estate in Estates)
            {
                if (estate is Office)
                {
                    var office = estate as Office;
                    lines.Add($"{office.Number}|{office.Address}|{office.Owner}|BIUROWIEC|{office.Length}|{office.Width}|{office.Price}|{office.AddedDate.ToString("dd-MM-yyyy")}|{office.Floors}|{office.MaxPeople}");
                }
                else if (estate is Parcel)
                {
                    var parcel = estate as Parcel;
                    lines.Add($"{parcel.Number}|{parcel.Address}|{parcel.Owner}|DZIAŁKA|{parcel.Length}|{parcel.Width}|{parcel.Price}|{parcel.AddedDate.ToString("dd-MM-yyyy")}|{parcel.ParcelType}");
                }
            }

            await File.WriteAllLinesAsync(_path, lines);
        }

        private async Task LoadFile()
        {
            var lines = await File.ReadAllLinesAsync(_path);
            Estates = new List<Estate>();

            foreach(var line in lines)
            {
                var splited = line.Split('|');
                if (splited[3] == "BIUROWIEC")
                {
                   Add(LoadOffice(splited));
                }
                else if (splited[3] == "DZIAŁKA")
                {
                    Add(LoadParcel(splited));
                }
            }
        }

        private Office LoadOffice(string[] line)
        {
            var number = int.Parse(line[0]);
            var address = line[1];
            var owner = Enum.Parse<Owner>(line[2]);
            var length = decimal.Parse(line[4]);
            var width = decimal.Parse(line[5]);
            var price = decimal.Parse(line[6]);
            var addedDate = DateTime.ParseExact(line[7], "dd-MM-yyyy", null);
            var floors = int.Parse(line[8]);
            var maxPeople = int.Parse(line[9]);

            return new Office(number, address, width, length, price, owner, addedDate, floors, maxPeople);
        }

        private Parcel LoadParcel(string[] line)
        {
            var number = int.Parse(line[0]);
            var address = line[1];
            var owner = Enum.Parse<Owner>(line[2]);
            var length = decimal.Parse(line[4]);
            var width = decimal.Parse(line[5]);
            var price = decimal.Parse(line[6]);
            var addedDate = DateTime.ParseExact(line[7], "dd-MM-yyyy", null);
            var type = Enum.Parse<ParcelType>(line[8]);

            return new Parcel(number, address, width, length, price, owner, addedDate, type);
        }
    }
}
