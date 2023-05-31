using PizzaRestaurant.model.factory;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.entity;

public class Menu
{
    public Dictionary<IFinishedProduct, RecipeFactory> RestaurantMenu { get; set; }
    
    public Menu(Dictionary<IFinishedProduct, RecipeFactory> menu)
    {
        RestaurantMenu = menu;
    }
    
}