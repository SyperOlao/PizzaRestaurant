using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestorant.model.entity
{
    internal class Product
    {
        public string Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price)
        {
            Id = Utils.GenerateID();
            Name = name;
            Price = price;
        }
    }
}
