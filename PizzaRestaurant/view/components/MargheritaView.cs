using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.view.components;

public class MargheritaView : PizzaView
{
    private const int DiameterDill = 10;
    private const int AmountDill = 150;

    public MargheritaView(Control pictureBox) : base(pictureBox)
    {
    }

    private void DrawPizza(Graphics graphics)
    {
        var x = WidthCenter - (float)DiameterPizza / 2;
        var y = HeightCenter - (float)DiameterPizza / 2;
        const float outer = 20f;
        graphics.FillEllipse(new SolidBrush(Color.Khaki), x - outer / 2, y - outer / 2, DiameterPizza + outer,
            DiameterPizza + outer);
        graphics.FillEllipse(new SolidBrush(Color.Goldenrod), x, y, DiameterPizza, DiameterPizza);
    }

    private void DrawFractal(Graphics graphics)
    {
        const int r = DiameterPizza / 2;
        const int rDill = DiameterDill / 2;

        var x = (float)WidthCenter - rDill +
            (float)(new Random().Next(r - DiameterDill) % r * Math.Cos(new Random().Next(360)));
        var y = (float)HeightCenter - rDill +
            (float)(new Random().Next(r - DiameterDill) % r * Math.Sin(new Random().Next(360)));

        graphics.FillRectangle(new SolidBrush(Color.ForestGreen), x, y, DiameterDill, DiameterDill);
    }

    public override void Draw(Graphics graphics, int tick)
    {
        DrawPizza(graphics);

        for (var i = 0; i < AmountDill; i++)
        {
            DrawFractal(graphics);
        }
    }
}