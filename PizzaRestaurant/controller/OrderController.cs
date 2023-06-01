using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.components;

namespace PizzaRestaurant.controller;

public class OrderController
{
    private readonly IClient _client;

    private readonly OrderView _orderView;

    public OrderController(IClient client, OrderView orderView)
    {
        _client = client;
        _orderView = orderView;
    }

    public void AddToOrder(IFinishedProduct? finishedProduct)
    {
        if(finishedProduct == null) return;
        
        _client.Order.Add(finishedProduct);
        
        _orderView.InitOrder(_client.Order);
    }

    


}