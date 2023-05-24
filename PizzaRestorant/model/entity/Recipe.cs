using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaRestorant.model.entity
{
    internal class Recipe
    {
        public Recipe(string name, List<Product> products)
        {
            Id = Utils.GenerateID();
            Name = name;
            Products = products;
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public List<Product> Products { get; set; }


        public FinishedProduct Cook()
        {
            return new FinishedProduct(Name, Products);
        }

    }
}
