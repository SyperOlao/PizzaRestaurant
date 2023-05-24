using PizzaRestorant.model.entity;
using PizzaRestorant.model.interfaces;

namespace PizzaRestorant.model.factory.concrete_finished_product
{
    internal class Peperony : IFinishedProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }

        public Peperony(int price, int weght)
        {   
            Name = "Peperony";
            Description = "Pizza with sausages";
            Price = price;
            Weight = weght;
        }
    }
}
