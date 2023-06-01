using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.interfaces;

namespace PizzaRestaurant.controller;

public class MenuController
{
    private readonly IMenu _menu;
    private readonly IMenuView _view;
    public MenuController(IMenu menu, IMenuView view)
    {
        _menu = menu;
        _view = view;
    }
    

    public void InitMenu()
    {
        _view.ShowAllMenu(_menu);
    }

    public IFinishedProduct? GetProductByName(DataGridViewCellEventArgs e)
    {
        var name = _view.GetSelectedName(e);
        Console.WriteLine("name", name);
        if (name == null) return null;
        var keys = _menu.RestaurantMenu.Keys;
        return keys.FirstOrDefault(key => key.Name.Equals(name));
    }
}