namespace PizzaRestaurant.model.entity;

public class Wealth
{
    public int CashReserve { get; set; }

    public Wealth(int cash)
    {
        CashReserve = cash;
    }
    
}