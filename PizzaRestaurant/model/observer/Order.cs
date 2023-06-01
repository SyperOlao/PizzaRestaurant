using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.observer;

public class Order
{
    public EventManager Events { get; set; }
    
    private List<IFinishedProduct> ClientOrder { get; set; }
    private IClient OrderedClient { get; set; }

    public Order(IClient client)
    {
        Events = new EventManager();
        OrderedClient = client;
        ClientOrder = new List<IFinishedProduct>();
    }

    public void GetOrder()
    {
        Events.Notify("order", OrderedClient.Order);
    }

    public void GiveTheOrderedFood()
    {
        Events.Notify("ready", ClientOrder);
    }
}