using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.@interface;
using PizzaRestaurant.model.observer;
using PizzaRestaurant.model.service;
using PizzaRestaurant.view.components;

namespace PizzaRestaurant.controller;

public class OrderController
{
    private readonly Client _client;

    private readonly OrderView _orderView;
    
    private readonly Order _order;
    
    private readonly Wealth _wealth = new(3000);

    private readonly OrderService _orderService;
    
    public OrderController(Client client, OrderView orderView, IMenu menu)
    {
        _client = client;
        _orderView = orderView;
        _order = new Order(_client);
        _orderService = new OrderService(_wealth, menu);
    }
    
    public void Subscribe()
    {
        _order.Events.Subscribe("order", _orderService);
        _order.Events.Subscribe("order", _client);
    }

    public void Notify()
    {
        _order.Events.Notify("order", _client.Order);
    }


    public void AddToOrder(IFinishedProduct? finishedProduct)
    {
        if(finishedProduct == null) return;
        
        _client.Order.Add(finishedProduct);

        UpdateOrder();
    }

    public void UpdateOrder()
    {
        _orderView.UpdateOrder(_client.Order);
    }
    

    public void ShowOrderPrice(Label label)
    {
        label.Text = _client.CostOfOrder().ToString();
    }

    public void ShowWealth(Label label)
    {
        label.Text = _wealth.CashReserve.ToString();
    }
    
    
    public void MakeAnOrder()
    {
        _order.GetOrder();
    }

}