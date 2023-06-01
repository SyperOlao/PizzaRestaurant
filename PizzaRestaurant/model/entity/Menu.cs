using PizzaRestaurant.model.factory;
using PizzaRestaurant.model.factory.concrete_recipe;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.entity;

// Меню ресторана
public class Menu : IMenu
{
    // Готовый продукт -> фабрика 
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