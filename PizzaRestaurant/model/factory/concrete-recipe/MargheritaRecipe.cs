using PizzaRestaurant.model.factory.concrete_finished_product;
using PizzaRestaurant.model.factory.concrete_product;
using PizzaRestaurant.model.interfaces;

namespace PizzaRestaurant.model.factory.concrete_recipe
{
    internal class MargheritaRecipe : RecipeFactory
    {
        public int ProfitСoefficient { get; set; }

        public MargheritaRecipe(Dictionary<int, IProduct> products) : base(products)
        {
            this.Products.Add(5, new Cheese());
            this.Products.Add(1, new Dough());
            this.Products.Add(1, new Ketchup());
            this.Products.Add(2, new Mayonnaise());
            ProfitСoefficient = 3;
        }

        public override IFinishedProduct Cook()
        {
             
            return new Margherita(this.GetCost() * ProfitСoefficient, this.GetWeght());
        }
    }
}
