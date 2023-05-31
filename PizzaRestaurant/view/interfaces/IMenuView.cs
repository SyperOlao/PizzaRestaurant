using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.view.interfaces
{
    public interface IMenuView
    {
        void Clear();
        void Add(IFinishedProduct finishedProduct);
    }
}
