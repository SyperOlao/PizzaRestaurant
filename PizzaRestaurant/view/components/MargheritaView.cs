using PizzaRestaurant.view.@abstract;

namespace PizzaRestaurant.view.components;

public class MargheritaView : PizzaView
{
    private const int DiameterDill = 10;
    private const int DiameterTomato = 45;
    private const int AmountDill = 150;
    private const int Limit = 10;
    public MargheritaView(Control pictureBox) : base(pictureBox)
    {
    }

    private void DrawPizza(Graphics graphics, int tick)
    {
        var x = WidthCenter - (float)DiameterPizza / 2;
        var y = HeightCenter - (float)DiameterPizza / 2;
        const float outer = 20f;
        graphics.FillEllipse(new SolidBrush(Color.Khaki), x - outer / 2, y - outer / 2, DiameterPizza + outer,
            DiameterPizza + outer);
        if (tick > 5)
        {
            graphics.FillEllipse(new SolidBrush(Color.Goldenrod), x, y, DiameterPizza, DiameterPizza);    
        }
        
    }

    private void DrawFractal(Graphics graphics, int lenght, int angle)
    {
        const int rDill = DiameterDill / 2;
        var x = WidthCenter - rDill +
            lenght * Math.Cos(angle);
        var y = HeightCenter - rDill +
            lenght * Math.Sin(angle);
        graphics.FillRectangle(new SolidBrush(Color.ForestGreen), (float)x, (float)y, DiameterDill, DiameterDill);
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
    
    private void DrawTomato(Graphics graphics, int lenght, int angle)
    {
        const int rPepperoni = DiameterTomato / 2;

        var x = WidthCenter - rPepperoni +
            lenght * Math.Cos(angle);
        var y = HeightCenter - rPepperoni +
            lenght * Math.Sin(angle);
        graphics.FillEllipse(new SolidBrush(Color.Tomato), (float)x, (float)y, DiameterTomato, DiameterTomato);
    }
    
    private void DrawInTick(Graphics graphics, int n)
    {
        while (true)
        {
            if (n is < 0 or > Limit) return;
            var len = n * DiameterDill * 2 % R;
            var lenTomato = n * DiameterTomato  % R;
            for (var j = 0; j <= 50; j += 1)
            {
              
               
                if (n==5 && j % 7 == 0)
                {
                    DrawTomato(graphics, lenTomato , j);       
                }

                if (len <= 70)
                {
                    if (j % 2 == 0)
                    {
                        DrawFractal(graphics, len*2 , j);   
                    }
                }
                else
                {
                    DrawFractal(graphics, len , j%360);
                }


            }
            n -= 1;
        }
    }
}