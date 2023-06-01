using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.view.components;

public class PepperoniView : PizzaView
{
    private const int DiameterPepperoni = 25;
    private const int AmountPepperoni = 25;

    public PepperoniView(Control pictureBox) : base(pictureBox)
    {
    }

    private void DrawPizza(Graphics graphics)
    {
        var x = WidthCenter - (float)DiameterPizza / 2;
        var y = HeightCenter - (float)DiameterPizza / 2;
        const float outer = 20f;
        graphics.FillEllipse(new SolidBrush(Color.Khaki), x - outer / 2, y - outer / 2, DiameterPizza + outer,
            DiameterPizza + outer);
        graphics.FillEllipse(new SolidBrush(Color.Coral), x, y, DiameterPizza, DiameterPizza);
    }

    private void DrawFractal(Graphics graphics)
    {
        const int r = DiameterPizza / 2;
        const int rPepperoni = DiameterPepperoni / 2;

        var x = (float)(WidthCenter) - rPepperoni +
            (float)(new Random().Next(r - rPepperoni) % r * Math.Cos(new Random().Next(360)));
        var y = (float)(HeightCenter) - rPepperoni +
            (float)(new Random().Next(r - rPepperoni) % r * Math.Sin(new Random().Next(360)));
        graphics.FillEllipse(new SolidBrush(Color.Brown), x, y, DiameterPepperoni, DiameterPepperoni);
    }

    public override void Draw(Graphics graphics)
    {
        DrawPizza(graphics);

        for (var i = 0; i < AmountPepperoni; i++)
        {
            DrawFractal(graphics);
        }
    }
}