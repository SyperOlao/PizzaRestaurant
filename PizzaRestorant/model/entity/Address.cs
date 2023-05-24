using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestorant.model.entity
{
    internal class Address
    {
        public Address(string street, string city, int numberOfHouse)
        {
            Street = street;
            City = city;
            NumberOfHouse = numberOfHouse;
        }

        public string Street { get; set; }

        public string City { get; set; }

        public int NumberOfHouse { get; set; }


    }
}
