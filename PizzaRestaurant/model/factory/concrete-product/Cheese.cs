using PizzaRestaurant.model.interfaces;
using PizzaRestaurant.model.Utils;

namespace PizzaRestaurant.model.factory.concrete_product
{
    internal class Cheese : IProduct
    {
        public string Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }

        public Cheese()
        {
            Id = Utils.Utils.GenerateID();
            Name = "Cheese";
            Price = 120;
            Weight = 100;
        }
    }
}
