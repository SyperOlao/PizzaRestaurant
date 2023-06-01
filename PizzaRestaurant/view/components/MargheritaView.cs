using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.view.components;

public class MargheritaView: PizzaView
{
    private const int DiameterDill = 10;
    public MargheritaView(PictureBox pictureBox) : base(pictureBox)
    {
    }
    
    public override void DrawPizza(Graphics graphics)
    {
        var x = WidthCenter - (float)DiameterPizza / 2;
        var y = HeightCenter - (float)DiameterPizza / 2;
        var outer = 20f;
        graphics.FillEllipse(new SolidBrush(Color.Khaki), x - outer / 2, y - outer / 2, DiameterPizza + outer,
            DiameterPizza + outer);
        graphics.FillEllipse(new SolidBrush(Color.Goldenrod), x, y, DiameterPizza, DiameterPizza);
    }

    public override void DrawFractal(Graphics graphics)
    {
        var r = DiameterPizza / 2;
        var rPepperoni = DiameterDill / 2;

        var x = (float)(WidthCenter) - rPepperoni +
            (float)(new Random().Next(r - rPepperoni) * Math.Cos(new Random().Next(360)));
        var y = (float)(HeightCenter) - rPepperoni +
            (float)(new Random().Next(r - rPepperoni) * Math.Sin(new Random().Next(360)));
        
        graphics.FillRectangle(new SolidBrush(Color.ForestGreen), x, y, DiameterDill, DiameterDill);
    }
}