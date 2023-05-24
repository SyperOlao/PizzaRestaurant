using PizzaRestaurant.model.factory.concrete_finished_product;
using PizzaRestaurant.model.factory.concrete_product;
using PizzaRestaurant.model.interfaces;

namespace PizzaRestaurant.model.factory.concrete_recipe
{
    internal class PepperoniRecipe : RecipeFactory
    {

        public int ProfitСoefficient { get; set; }

        public PepperoniRecipe()
        {
            Products.Add(2, new Cheese());
            Products.Add(3, new Sausages());
            Products.Add(1, new Dough());
            Products.Add(3, new Ketchup());
            ProfitСoefficient = 2;
        }


        public override IFinishedProduct Cook()
        {
            return new Peperony(GetCost() * ProfitСoefficient, GetWeight());
        }
    }
}
