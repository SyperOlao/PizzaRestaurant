using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.entity;

public class Menu
{
    public Dictionary<string, IRecipe> RestaurantMenu { get; set; }
    
    public Menu(Dictionary<string, IRecipe> menu)
    {
        RestaurantMenu = menu;
    }
    
}