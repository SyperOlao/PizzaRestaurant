namespace PizzaRestaurant.model.interfaces
{
    public interface IFinishedProduct
    {

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int Weight { get; set; }

    }
}
