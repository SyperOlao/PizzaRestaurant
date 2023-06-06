using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.view.components;

public class PepperoniView : PizzaView
{
    private const int DiameterPepperoni = 25;
    private const int AmountPepperoni = 25;
    private const int Limit = 10;
    private const int R = DiameterPizza / 2;

    public PepperoniView(Control pictureBox) : base(pictureBox)
    {
    }

    private void DrawPizza(Graphics graphics, int tick)
    {
        var x = WidthCenter - (float)DiameterPizza / 2;
        var y = HeightCenter - (float)DiameterPizza / 2;
        const float outer = 20f;
        graphics.FillEllipse(new SolidBrush(Color.Khaki), x - outer / 2, y - outer / 2, DiameterPizza + outer,
            DiameterPizza + outer);
        if (tick > 3)
        {
            graphics.FillEllipse(new SolidBrush(Color.Coral), x, y, DiameterPizza, DiameterPizza);       
        }
     
    }

    private void DrawFractal(Graphics graphics, int lenght, int angle)
    {
        const int rPepperoni = DiameterPepperoni / 2;

        var x = WidthCenter - rPepperoni +
            lenght * Math.Cos(angle);
        var y = HeightCenter - rPepperoni +
            lenght * Math.Sin(angle);
        graphics.FillEllipse(new SolidBrush(Color.Brown), (float)x, (float)y, DiameterPepperoni, DiameterPepperoni);
    }

    public override void Draw(Graphics graphics, int tick)
    {
        DrawPizza(graphics, tick);

        switch (tick)
        {
            case > 5 and < Limit:
                DrawInTick(graphics, tick);
                break;
            case >= Limit:
                DrawInTick(graphics, Limit);
                break;
        }
    }

    private void DrawInTick(Graphics graphics, int n)
    {
        while (true)
        {
            if (n is < 0 or > Limit) return;
            var len = n * DiameterPepperoni * 2 % R;
            for (var j = 0; j <= 7 * n; j += 2)
            {
                if (j % 3 != 0) continue;
                DrawFractal(graphics, len , j);
                j += 5;

            }
            n -= 1;
        }
    }
}