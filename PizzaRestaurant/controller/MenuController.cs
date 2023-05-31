using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.controller;

public class MenuController
{
    private List<IFinishedProduct> _finishedProduct;

    MenuController(List<IFinishedProduct> finishedProduct)
    {
        _finishedProduct = finishedProduct;
    }


    MenuController()
    {
        _finishedProduct = new List<IFinishedProduct>();
    }
}