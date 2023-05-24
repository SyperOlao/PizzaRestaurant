using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaRestorant.model.entity
{
    internal class FinishedProduct
    {
        public FinishedProduct(string name, List<Product> products)
        {
            Id = Utils.GenerateID();
            Name = name;
            Products = products;
        }

        public string Id { get; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Product> Products { get; set; }



    }
}
