using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.interfaces;
using System.Windows.Forms;

namespace PizzaRestaurant.view.components
{
    public class MenuView : IMenuView
    {

        private readonly DataGridView _dataGridView;

        public MenuView(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }
        
        public void Clear()
        {
            _dataGridView.Rows.Clear();
        }

        public void Add(IFinishedProduct finishedProduct)
        {
            _dataGridView.Rows.Add(finishedProduct.Name, finishedProduct.Price, finishedProduct.Weight);
        }
    }
}
