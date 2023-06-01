using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.view.components;

public class PepperoniView: PizzaView
{
    public PepperoniView(Graphics graphics, PictureBox pictureBox) : base(graphics, pictureBox)
    {
    }
    
    public override void DrawPizza()
    {
        var x = PictureBox.Width / 2;
        var y = PictureBox.Height / 2;
        Graphics.FillEllipse(new SolidBrush(Color.Coral), x, y, DiameterPizza, DiameterPizza);
    }
    
}