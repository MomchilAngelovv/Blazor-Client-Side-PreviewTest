using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models;

namespace Test1.Services
{
    public class PeopleService : IPeopleService
    {
        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>
            {
                new Person
                {
                    Id = 1,
                    FirstName = "Momchil",
                    LastName = "Angelov",
                    PhoneNumber = "123456789"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Asen",
                    LastName = "Angelov",
                    PhoneNumber = "987654321"
                },
                new Person
                {
                    Id = 2,
                    FirstName = "Elena",
                    LastName = "Agelova",
                    PhoneNumber = "123459876"
                }
            };

            return people;
        }
    }
}
