using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaRestaurant.model.interfaces;

namespace PizzaRestaurant.model.entity
{
    internal class Client
    {
        public Client(string name, Address address, string phone, List<IFinishedProduct> order)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Order = order;
        }

        public string Name { get; set; }

        public Address Address { get; set; }

        public string Phone { get; set; }

        public List<IFinishedProduct> Order { get; set; }

    }
}
