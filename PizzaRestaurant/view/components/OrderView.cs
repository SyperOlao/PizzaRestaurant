using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.view.components;

public class OrderView
{
    private readonly ListBox _listBox;

    public OrderView(ListBox listBox)
    {
        _listBox = listBox;
    }

    public void UpdateOrder(List<IFinishedProduct> products)
    {
        _listBox.Items.Clear();
        
        foreach (var product in products)
        {
            _listBox.Items.Add("Name: " + product.Name + ",\t Price: " + product.Price);
            
        }
    }
}