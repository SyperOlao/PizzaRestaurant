using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.factory;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.service;

public class OrderService:  IObserver
{
    private readonly Wealth _wealth;
    private readonly Menu _menu;
    private readonly Cooker _cooker;

    OrderService(Wealth wealth, Menu menu, Dictionary<IRecipe, RecipeFactory> cook)
    {
        _wealth = wealth;
        _menu = menu;
        _cooker = new Cooker(cook);
    }

    OrderService(Menu menu, Dictionary<IRecipe, RecipeFactory> cook)
    {
        _wealth = new Wealth();
        _menu = menu;
        _cooker = new Cooker(cook);
    }

    private List<IFinishedProduct> GetOrder(List<IFinishedProduct> clientOrder)
    {
        var dish = new List<IFinishedProduct>();
        foreach (var finishedProduct in clientOrder)
        {
            BuyIngredients(finishedProduct);
            var factory = _cooker.ToCook(GetRecipeFromOrder(finishedProduct));
            dish.Add(factory.Cook());
        }
        return dish;
    }

    private void BuyIngredients(IFinishedProduct finishedProduct)
    {
        var products = GetRecipeFromOrder(finishedProduct);
        foreach (var product in products.Products)
        {
            BuyProduct(product);
        }
    }

    private IRecipe GetRecipeFromOrder(IFinishedProduct finishedProduct)
    {
        if (!_menu.RestaurantMenu.ContainsKey(finishedProduct.Name))
            throw new Exception("We haven't got recipe for this dish!");
        var recipe = _menu.RestaurantMenu[finishedProduct.Name];
        return recipe;
    }

    private void BuyProduct(KeyValuePair<IProduct, int> product)
    {
        var cost = product.Value * product.Key.Price;
        if (_wealth.CashReserve < product.Value * product.Key.Price)
        {
            throw new Exception("Store busted!!");
        }

        _wealth.CashReserve = -cost;
    }

    public void Update(List<IFinishedProduct> state)
    {
        GetOrder(state);
    }
}