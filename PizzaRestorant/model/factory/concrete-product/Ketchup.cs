using PizzaRestorant.model.interfaces;

namespace PizzaRestorant.model.factory.concrete_product
{
    internal class Ketchup: IProduct
    {
        public string Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }

        public Ketchup()
        {
            Id = Utils.Utils.GenerateID();
            Name = "Ketchup";
            Price = 20;
            Weight = 10;
        }
    }
}
