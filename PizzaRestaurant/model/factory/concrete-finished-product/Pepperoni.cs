using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.factory.concrete_finished_product
{
    internal class Pepperoni : IFinishedProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }

        public Pepperoni(int price, int weight)
        {   
            Name = "Pepperoni";
            Description = "Pizza with sausages";
            Price = price;
            Weight = weight;
        }
    }
}
