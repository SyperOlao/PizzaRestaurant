using PizzaRestaurant.controller;
using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.@interface;
using PizzaRestaurant.model.observer;
using PizzaRestaurant.model.service;
using PizzaRestaurant.view.components;

namespace PizzaRestaurant.view;

public partial class Form1 : Form
{
    private readonly MenuController _menuController;
    private readonly OrderController _orderController;
    private readonly IMenu _menu = new Menu();
    private readonly IClient _client;
    private readonly Wealth _wealth = new Wealth(3000);
    public Form1()
    {
        InitializeComponent();
        _menuController = new MenuController(_menu, new MenuView(dataGridView1));
        _client = new Client("Lol");
        _orderController = new OrderController(_client, new OrderView(listBox1));
    }

    private void Form1_Load(object sender, EventArgs e)
    {

        _menuController.InitMenu();
        
        var eventManager = new EventManager();
        var orderService = new OrderService(_wealth, _menu);
        eventManager.Subscribe("order", orderService);
        eventManager.Notify("order", _client.Order);
        label1.Text = _wealth.CashReserve.ToString();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var product = _menuController.GetProductByName(e);
        _orderController.AddToOrder(product);
        _orderController.ShowOrderPrice(label1);
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      
    }
}