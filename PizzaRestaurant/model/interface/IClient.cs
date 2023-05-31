using PizzaRestaurant.model.entity;

namespace PizzaRestaurant.model.@interface;

public interface IClient
{
    string Name { get; set; }

    Address Address { get; set; }

    List<IFinishedProduct> Order { get; set; }

    int CostOfOrder();
}