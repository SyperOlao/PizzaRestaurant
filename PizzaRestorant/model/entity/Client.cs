using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestorant.model.entity
{
    internal class Client
    {
        public Client(string name, Address address, string phone, List<FinishedProduct> order)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Order = order;
        }

        public string Name { get; set; }

        public Address Address { get; set; }

        public string Phone { get; set; }

        public List<FinishedProduct> Order { get; set; }

    }
}
