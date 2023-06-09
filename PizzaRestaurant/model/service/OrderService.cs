﻿using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.service;

public class OrderService: IObserver
{
    private readonly Wealth _wealth;
    private readonly IMenu _menu;
    
    public OrderService(Wealth wealth, IMenu menu)
    {
        _wealth = wealth;
        _menu = menu;
    }
    
    public void Update(List<IFinishedProduct> state)
    {
        GetOrder(state);
    }

    private List<IFinishedProduct> GetOrder(List<IFinishedProduct> clientOrder)
    {
        var order = new List<IFinishedProduct>();
        foreach (var finishedProduct in clientOrder)
        {
            BuyIngredients(finishedProduct);
            var factory = _menu.RestaurantMenu[finishedProduct];
            var product = factory.Cook();
            _wealth.CashReserve += product.Price;
            order.Add(product);
        }
        return order;
    }

    private void BuyIngredients(IFinishedProduct finishedProduct)
    {
        var products = GetFactoryFromOrder(finishedProduct);
        foreach (var product in products.Products)
        {
            BuyProduct(product);
        }
    }

    private IRecipe GetFactoryFromOrder(IFinishedProduct finishedProduct)
    {
        if (!_menu.RestaurantMenu.ContainsKey(finishedProduct))
            throw new Exception("We haven't got recipe for this dish!");
        return _menu.RestaurantMenu[finishedProduct];
    }

    private void BuyProduct(KeyValuePair<IProduct, int> product)
    {
        var cost = product.Value * product.Key.Price;
        if (_wealth.CashReserve < product.Value * product.Key.Price)
        {
            throw new Exception("Store busted!!");
        }

        _wealth.CashReserve -= cost;
    }
}