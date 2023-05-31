using PizzaRestaurant.model.factory;
using PizzaRestaurant.model.factory.concrete_recipe;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.entity;

public class Menu : IMenu
{
    public Dictionary<IFinishedProduct, RecipeFactory> RestaurantMenu { get; set; }

    public Menu(Dictionary<IFinishedProduct, RecipeFactory> menu)
    {
        RestaurantMenu = menu;
    }

    public Menu()
    {
        RestaurantMenu = new Dictionary<IFinishedProduct, RecipeFactory>
                         {
                             { new PepperoniRecipe().Cook(), new PepperoniRecipe() },
                             { new MargheritaRecipe().Cook(), new MargheritaRecipe() }
                         };
    }
}