using PizzaRestaurant.model.entity;
using System.Diagnostics;
using PizzaRestaurant.model.interfaces;

namespace PizzaRestaurant.model.factory.concrete_finished_product
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
