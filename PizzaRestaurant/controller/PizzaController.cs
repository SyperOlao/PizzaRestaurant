using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.controller;

public class PizzaController
{
  private readonly Dictionary<IFinishedProduct, PizzaView> _drawPizza;

  PizzaController()
  {
    _drawPizza = new Dictionary<IFinishedProduct, PizzaView> {  };
  }

}