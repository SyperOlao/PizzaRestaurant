namespace PizzaRestorant.model.interfaces
{
    public interface IProduct
    {
        public string Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
    }
}
