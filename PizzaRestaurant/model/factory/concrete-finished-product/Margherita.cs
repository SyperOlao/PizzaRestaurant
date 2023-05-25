using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.factory.concrete_finished_product
{
    internal class Margherita : IFinishedProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }

        public Margherita(int price, int weight)
        {
            Name = "Margherita";
            Description = "Pizza with cheese";
            Price = price;
            Weight = weight;
        }
    }
}
