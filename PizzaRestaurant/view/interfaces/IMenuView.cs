using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.view.interfaces
{
    public interface IMenuView
    {
        void Clear();
        void Add(IFinishedProduct finishedProduct);

        void ShowAllMenu(IMenu menu);

        string? GetSelectedName(DataGridViewCellEventArgs e);
    }
}
