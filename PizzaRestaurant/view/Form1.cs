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
    private readonly IMenu _menu = new Menu();
    public Form1()
    {
 
        _menuController = new MenuController(_menu, new MenuView(dataGridView1));
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
     
        _menuController.InitMenu();
        
        var wealth = new Wealth(3000);
        var key = _menu.RestaurantMenu.Keys;
        var client = new Client("Lol", new Address("fff", "aaa", 6), new List<IFinishedProduct> { key.First() });
        var eventManager = new EventManager();
        var orderService = new OrderService(wealth, _menu);
        eventManager.Subscribe("order", orderService);
        eventManager.Notify("order", client.Order);
        label1.Text = wealth.CashReserve.ToString();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
    }
}