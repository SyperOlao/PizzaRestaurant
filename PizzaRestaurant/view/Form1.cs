using PizzaRestaurant.model.entity;
using PizzaRestaurant.model.factory;
using PizzaRestaurant.model.factory.concrete_recipe;
using PizzaRestaurant.model.@interface;
using PizzaRestaurant.model.observer;
using PizzaRestaurant.model.service;
using PizzaRestaurant.view.components;

namespace PizzaRestaurant.view;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        var a = new MenuView(dataGridView1);
        var b = new PepperoniRecipe();
        var b1 = new MargheritaRecipe();
        a.Add(b.Cook());


        var client = new Client("Lol", new Address("fff", "aaa", 6), new List<IFinishedProduct> { b.Cook() });
        var f = new Order(client);
        var menu = new Menu(new Dictionary<IFinishedProduct, RecipeFactory>{{b.Cook(), new PepperoniRecipe()}, {b1.Cook(), new MargheritaRecipe()}});
        var eventManager = new EventManager();
        var orderService = new OrderService(new Wealth(3000), menu);
        eventManager.Subscribe("order", orderService); 
        
        eventManager.Notify("order", client.Order);
        
        
       
        
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {

    }
}