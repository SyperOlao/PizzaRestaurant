namespace PizzaRestaurant.view.@abstract;

public abstract class PizzaView
{
    protected readonly Graphics Graphics;
    protected readonly PictureBox PictureBox;
    protected const int DiameterPizza = 100;

    protected PizzaView(Graphics graphics, PictureBox pictureBox)
    {
        Graphics = graphics;
        PictureBox = pictureBox;
    }

    public abstract void DrawPizza();
}