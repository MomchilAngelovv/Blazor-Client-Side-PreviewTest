using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models;

namespace Test1.Services
{
    public class BottleService
    {
        public IEnumerable<BottleModel> GetBottles(double volume)
        {
            var allBottles = new List<BottleModel>
            {
                new BottleModel
                {
                    Id = 1,
                    DrinkName = "Coca-Cola",
                    Volume = 1.5,
                    BottledOn = DateTime.UtcNow.AddDays(-60)
                },
                new BottleModel
                {
                    Id = 2,
                    DrinkName = "Fanta",
                    Volume = 2.5,
                    BottledOn = DateTime.UtcNow.AddDays(-30)
                },
                new BottleModel
                {
                    Id = 3,
                    DrinkName = "Milk",
                    Volume = 0.5,
                    BottledOn = DateTime.UtcNow.AddDays(-5)
                }
            };

            var filteredBottles = allBottles.Where(b => b.Volume >= volume);
            return filteredBottles;
        }
    }
}
