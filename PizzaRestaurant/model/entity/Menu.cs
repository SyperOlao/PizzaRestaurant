using PizzaRestaurant.model.factory;
using PizzaRestaurant.model.factory.concrete_recipe;
using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.@abstract;
using PizzaRestaurant.view.components;

namespace PizzaRestaurant.model.entity;

// Меню ресторана
public class Menu : IMenu
{
    // Готовый продукт -> фабрика 
    public Dictionary<IFinishedProduct, RecipeFactory> RestaurantMenu { get; set; }
    public Dictionary<IFinishedProduct, PizzaView> View { get; set; }


    public Menu(Control pictureBox)
    {
        var pepperoni = new PepperoniRecipe().Cook();
        var margherita = new MargheritaRecipe().Cook();
        RestaurantMenu = new Dictionary<IFinishedProduct, RecipeFactory>
                         {
                             { pepperoni, new PepperoniRecipe() },
                             { margherita, new MargheritaRecipe() }
                         };
        View = new Dictionary<IFinishedProduct, PizzaView>
               {
                   {
                       pepperoni, new PepperoniView(pictureBox)
                   },
                   {
                       margherita, new MargheritaView(pictureBox)
                   }
               };
    }
}