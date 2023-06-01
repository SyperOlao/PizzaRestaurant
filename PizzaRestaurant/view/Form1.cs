using PizzaRestaurant.controller;
using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.@interface;
using PizzaRestaurant.view.@abstract;
using PizzaRestaurant.view.components;

namespace PizzaRestaurant.view;

public partial class Form1 : Form
{
    private readonly MenuController _menuController;
    private readonly OrderController _orderController;
    private readonly IMenu _menu;
    private readonly Client _client;
    private readonly Graphics _graphics;
    private Bitmap _bitmap;
    int tickcount = 1;

    public Form1()
    {
        InitializeComponent();
        _menu = new Menu(pictureBox1);
        _menuController = new MenuController(_menu, new MenuView(dataGridView1));
        _client = new Client("Alice");
        _orderController = new OrderController(_client, new OrderView(listBox1), _menu);
        _graphics = CreateGraphics();
        timer1.Start();
        timer1.Tick += new EventHandler(timer1_Tick);
        timer1.Interval = (1000);
        timer1.Enabled = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _menuController.InitMenu();
        _orderController.Subscribe();
        _orderController.ShowWealth(label1);
        _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
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

    private void timer1_Tick(object sender, EventArgs e)
    {

        tickcount++;
        if (tickcount > 3)
        {
            timer1.Stop();
            timer1.Enabled = false;
        }
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        var graphics = e.Graphics;
        var products = _menu.RestaurantMenu.Keys;
        foreach (var product in products)
        {
            if (tickcount == 1)
            {
                _orderController.AddToOrder(product);
                _menu.View[product].Draw(graphics);         
            }
       
        }

        _orderController.ShowOrderPrice(label6);
        _orderController.ShowWealth(label1);
      
    }
}