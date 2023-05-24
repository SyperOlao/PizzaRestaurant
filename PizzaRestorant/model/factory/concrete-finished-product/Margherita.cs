using PizzaRestorant.model.entity;
using PizzaRestorant.model.interfaces;
using System.Diagnostics;

namespace PizzaRestorant.model.factory.concrete_finished_product
{
    internal class Margherita : IFinishedProduct
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }

        public Margherita(int price, int weght)
        {
            Name = "Margherita";
            Description = "Pizza with cheese";
            Price = price;
            Weight = weght;
        }
    }
}
