using PizzaRestaurant.model.factory;
using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.model.@interface;

public interface IMenu
{
    public Dictionary<IFinishedProduct, RecipeFactory> RestaurantMenu { get; set; }

    public Dictionary<IFinishedProduct, PizzaView> View { get; set; }
}