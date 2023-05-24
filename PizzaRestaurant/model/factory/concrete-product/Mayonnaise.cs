using PizzaRestaurant.model.interfaces;

namespace PizzaRestaurant.model.factory.concrete_product
{
    internal class Mayonnaise: IProduct
    {
        public string Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }

        public Mayonnaise()
        {
            Id = Utils.Utils.GenerateID();
            Name = "Mayonnaise";
            Price = 35;
            Weight = 10;
        }
    }
}
