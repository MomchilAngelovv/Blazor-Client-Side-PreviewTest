using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models;

namespace Test1.Services
{
    interface IPeopleService
    {
        IEnumerable<Person> GetPeople();
    }
}
