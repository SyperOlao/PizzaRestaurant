namespace PizzaRestaurant.model.@interface;

public interface IObserver
{
     void Update(List<IFinishedProduct> state);
}