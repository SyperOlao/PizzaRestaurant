using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.interfaces;

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

        public void ShowAllMenu(IMenu menu)
        {
            var keys = menu.RestaurantMenu.Keys;
            foreach (var key in keys)
            {
                Add(key);
            }
        }

        public string? GetSelectedName(DataGridViewCellEventArgs e)
        {
            return e.RowIndex < -1 ? null : _dataGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
        }
    }
}