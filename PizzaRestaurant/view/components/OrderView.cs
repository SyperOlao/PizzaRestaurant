using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.view.components;

public class OrderView
{
    private readonly ListBox _listBox;

    public OrderView(ListBox listBox)
    {
        _listBox = listBox;
    }

    public void InitOrder(List<IFinishedProduct> products)
    {
        foreach (var product in products)
        {
            _listBox.Text += product.Name;
        }
    }
}