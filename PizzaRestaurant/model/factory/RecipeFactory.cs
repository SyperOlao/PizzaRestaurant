using PizzaRestaurant.model.interfaces;

namespace PizzaRestaurant.model.factory
{
    public abstract class RecipeFactory
    {
        public string Id { get; set; }
        protected Dictionary<int, IProduct> Products { get; set; }


        protected RecipeFactory(Dictionary<int, IProduct> products)
        {
            Id = Utils.Utils.GenerateID();
            Products = products;
        }

        protected RecipeFactory()
        {
            Id = Utils.Utils.GenerateID();
            Products = new Dictionary<int, IProduct>();
        }

        public abstract IFinishedProduct Cook();

        protected int GetCost()
        {
            return Products.Sum(product => product.Value.Price * product.Key);
        }

        protected int GetWeight()
        {
            return Products.Sum(product => product.Value.Weight * product.Key);
        }
    }
}