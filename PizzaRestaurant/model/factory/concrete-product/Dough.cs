using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.factory.concrete_product
{
    //Тесто
    public class Dough : IProduct
    {
        public string Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }

        public Dough()
        {
            Id = Utils.Utils.GenerateID();
            Name = "Dough";
            Price = 15;
            Weight = 500;
        }
    }
}
