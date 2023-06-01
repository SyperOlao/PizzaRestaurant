using PizzaRestaurant.model.factory.concrete_finished_product;
using PizzaRestaurant.model.factory.concrete_product;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.factory.concrete_recipe
{
    internal class MargheritaRecipe : RecipeFactory
    {
        public int ProfitСoefficient { get; set; }

        public MargheritaRecipe()
        {
            Products.Add(new Cheese(), 5);
            Products.Add(new Dough(), 1);
            Products.Add(new Ketchup(), 1);
            Products.Add(new Mayonnaise(),7);
            ProfitСoefficient = 3;
        }

        public override IFinishedProduct Cook()
        {
             
            return new Margherita(GetCost() * ProfitСoefficient, GetWeight());
        }
    }
}
