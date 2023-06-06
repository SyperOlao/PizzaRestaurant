namespace PizzaRestaurant.view.@abstract;

public abstract class PizzaView
{
    protected readonly int WidthCenter;
    protected readonly int HeightCenter;
    protected const int DiameterPizza = 300;

    protected PizzaView(Control pictureBox)
    {
        WidthCenter = pictureBox.Width / 2;
        HeightCenter = pictureBox.Height / 2;
    }

    public abstract void Draw(Graphics graphics, int tick);
}