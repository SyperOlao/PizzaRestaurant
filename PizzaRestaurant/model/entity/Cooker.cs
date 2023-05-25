using PizzaRestaurant.model.factory;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.entity;

public class Cooker
{
    public Dictionary<IRecipe, RecipeFactory> Cook { get; set; }

    public Cooker(Dictionary<IRecipe, RecipeFactory> cook)
    {
        Cook = cook;
    }

    public RecipeFactory ToCook(IRecipe recipe)
    {
       return Cook[recipe];
    }
}