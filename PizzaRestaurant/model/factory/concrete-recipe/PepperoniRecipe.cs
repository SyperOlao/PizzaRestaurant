using PizzaRestaurant.model.factory.concrete_finished_product;
using PizzaRestaurant.model.factory.concrete_product;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.factory.concrete_recipe
{
    internal class PepperoniRecipe : RecipeFactory
    {

        public int ProfitСoefficient { get; set; }

        public PepperoniRecipe()
        {
            Products.Add(new Cheese(), 2);
            Products.Add(new Sausages(), 3);
            Products.Add(new Dough(), 1);
            Products.Add(new Ketchup(), 3);
            ProfitСoefficient = 2;
        }


        public override IFinishedProduct Cook()
        {
            return new Pepperoni(GetCost() * ProfitСoefficient, GetWeight());
        }
    }
}
