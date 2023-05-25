using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.factory
{
    public abstract class RecipeFactory: IRecipe
    {
        public string Id { get; set; }
        public Dictionary<IProduct, int> Products { get; set; }


        protected RecipeFactory(Dictionary<IProduct, int> products)
        {
            Id = Utils.Utils.GenerateID();
            Products = products;
        }

        protected RecipeFactory()
        {
            Id = Utils.Utils.GenerateID();
            Products = new Dictionary<IProduct, int>();
        }

        public abstract IFinishedProduct Cook();

        protected int GetCost()
        {
            return Products.Sum(product => product.Key.Price * product.Value);
        }

        protected int GetWeight()
        {
            return Products.Sum(product => product.Key.Weight * product.Value);
        }
    }
}