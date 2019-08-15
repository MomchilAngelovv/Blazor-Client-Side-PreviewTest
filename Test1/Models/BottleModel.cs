using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Models
{
    public class BottleModel
    {
        public int Id { get; set; }

        public string DrinkName { get; set; }

        public double Volume { get; set; }

        public DateTime BottledOn { get; set; }
    }
}
