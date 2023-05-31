using PizzaRestaurant.model.factory;

namespace PizzaRestaurant.model.@interface;

public interface IMenu
{
    public Dictionary<IFinishedProduct, RecipeFactory> RestaurantMenu { get; set; }
}