using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.observer;

public class Order
{
    private EventManager Events { get; set; }
    
    private List<IFinishedProduct> ClientOrder { get; set; }
    private Client OrderedClient { get; set; }

    public Order(List<IFinishedProduct> clientOrder, Client client)
    {
        Events = new EventManager();
        OrderedClient = client;
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