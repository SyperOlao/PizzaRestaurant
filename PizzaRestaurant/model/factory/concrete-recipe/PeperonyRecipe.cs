using PizzaRestaurant.model.factory.concrete_finished_product;
using PizzaRestaurant.model.factory.concrete_product;
using PizzaRestaurant.model.interfaces;

namespace PizzaRestaurant.model.factory.concrete_recipe
{
    internal class PeperonyRecipe : RecipeFactory
    {

        public int ProfitСoefficient { get; set; }

        public PeperonyRecipe() : base()
        {
            this.Products.Add(2, new Cheese());
            this.Products.Add(3, new Sausages());
            this.Products.Add(1, new Dough());
            this.Products.Add(3, new Ketchup());
            ProfitСoefficient = 2;
        }


        public override IFinishedProduct Cook()
        {
            return new Peperony(this.GetCost() * ProfitСoefficient, this.GetWeght());
        }
    }
}
