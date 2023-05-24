using PizzaRestorant.model.interfaces;

namespace PizzaRestorant.model.factory.concrete_product
{
    internal class Sausages : IProduct
    {
        public string Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }


        public Sausages()
        {
            Id = Utils.Utils.GenerateID();
            Name = "Sausages";
            Price = 300;
            Weight = 100;
        }
    }
}
