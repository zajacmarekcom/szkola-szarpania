using System;
using System.Collections.Generic;
using System.Linq;

namespace App_M18_L3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Data>
            {
                new Data(1, "TestName1", 332.33M),
                new Data(2, "My data", 33.21M),
                new Data(3, "Test data", 54.90M),
                new Data(4, "Something", 100.20M),
                new Data(5, "TestName2", 433.88M),
                new Data(6, "Another data", 111.32M),
                new Data(7, "Important", 2.33M),
                new Data(8, "Public data", 33.00M)
            };

            var sum = list.Sum(x => x.Amount);
            var avg = list.Average(x => x.Amount);
            var min = list.Min(x => x.Amount);
            var max = list.Max(x => x.Amount);
            var count = list.Count(x => x.Id > 4);
            var countAll = list.Count();
            var hasElementWithIdOver5 = list.Any(x => x.Id > 5);
            var allItemsHasAmountOver10 = list.All(x => x.Amount > 10.0M);
            var el = list[0];
            var contains = list.Contains(el);
            var where = list.Where(x => x.Id > 3);
            var select = list.Select(x => x.Name);
            var select2 = list.Select(x => new NewData(x.Id, x.Name));
            var first = list.First(x => x.Id == 1);
            var firstOrDefault = list.FirstOrDefault(x => x.Amount > 1000.0M);
            var last = list.Last(x => x.Id > 5);
            var lastOrDefault = list.LastOrDefault(x => x.Amount > 1000.0M);
            var single = list.Single(x => x.Id == 5);
            var singleOrDefault = list.SingleOrDefault(x => x.Amount > 1000.0M);

            var moreLinq = list
                .Where(x => x.Amount > 100.0M)
                .Select(x => x.Amount)
                .Sum();

            Console.WriteLine(countAll);
        }
    }
}
