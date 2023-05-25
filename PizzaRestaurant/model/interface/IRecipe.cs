namespace PizzaRestaurant.model.@interface;

public interface IRecipe
{
    public string Id { get; set; }
    public Dictionary<IProduct, int> Products { get; set; }
}