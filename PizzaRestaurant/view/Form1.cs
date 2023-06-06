using System.Runtime.InteropServices;
using System.Timers;
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
    private int _tick;
    private int _tick2 = 0;

    public Form1()
    {
        InitializeComponent();
        _menu = new Menu(pictureBox1);
        _menuController = new MenuController(_menu, new MenuView(dataGridView1));
        _client = new Client("Alice");
        _orderController = new OrderController(_client, new OrderView(listBox1), _menu);
        _graphics = CreateGraphics();
        timer1.Start();
        timer1.Enabled = true;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        AllocConsole();
        _menuController.InitMenu();
        _orderController.Subscribe();
        _orderController.ShowWealth(label1);
        _bitmap = new Bitmap(ClientSize.Width, ClientSize.Height);
    }
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    static extern bool AllocConsole();
    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        var product = _menuController.GetProductByName(e);
        _orderController.AddToOrder(product);
        _orderController.ShowOrderPrice(label6);
        _orderController.ShowWealth(label1);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Buy();
    }

    private void Buy()
    {
        _orderController.Notify();
        _orderController.UpdateOrder();
        _orderController.ShowOrderPrice(label6);
        _orderController.ShowWealth(label1);
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        using var graphics = Graphics.FromImage(_bitmap);
        pictureBox1.Refresh();
        _tick += 1;
        if (_tick >= 10)
        {
            _tick2 += 1;
        }
        _orderController.ShowOrderPrice(label6);
        _orderController.ShowWealth(label1);
    }

    private void pictureBox1_Paint(object sender, PaintEventArgs e)
    {
        if (_tick <= 10)
        {
            Amin(e, 1, _tick);
        }
        else
        {
            Amin(e, 0, _tick2);    
        }
        

    }

    private void Amin(PaintEventArgs e, int index, int tick)
    {
        Console.WriteLine(tick);
        var products = _menu.RestaurantMenu.Keys;
        if (index > products.Count) throw new Exception("Index is not valid");
        var graphics = e.Graphics;
      
        switch (tick)
        {
            case 2:
                _orderController.AddToOrder(products.ElementAt(index));
                break;
            case 10:
                Buy();
                break;
        }

        _menu.View[products.ElementAt(index)].Draw(graphics, tick);
    }
}