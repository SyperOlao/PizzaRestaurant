namespace PizzaRestaurant.view.@abstract;

public abstract class PizzaView
{
    protected readonly PictureBox PictureBox;
    protected readonly int WidthCenter;
    protected readonly int HeightCenter;
    protected const int DiameterPizza = 300;

    protected PizzaView(PictureBox pictureBox)
    {
        PictureBox = pictureBox;
        WidthCenter = PictureBox.Width / 2;
        HeightCenter = PictureBox.Height / 2;
    }

    public abstract void DrawPizza(Graphics graphics);
    public abstract void DrawFractal(Graphics graphics);
}