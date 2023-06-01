using PizzaRestaurant.controller;
using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.components;

namespace PizzaRestaurant.view;

public partial class Form1 : Form
{
    private readonly MenuController _menuController;
    private readonly OrderController _orderController;
    private readonly IMenu _menu = new Menu();
    private readonly Client _client;

    public Form1()
    {
        InitializeComponent();
        _menuController = new MenuController(_menu, new MenuView(dataGridView1));
        _client = new Client("Alice");
        _orderController = new OrderController(_client, new OrderView(listBox1), _menu);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _menuController.InitMenu();
        _orderController.Subscribe();
        _orderController.ShowWealth(label1);
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var product = _menuController.GetProductByName(e);
        _orderController.AddToOrder(product);
        _orderController.ShowOrderPrice(label6);
        _orderController.ShowWealth(label1);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _orderController.Notify();
        _orderController.UpdateOrder();
        _orderController.ShowOrderPrice(label6);
        _orderController.ShowWealth(label1);

    }
}