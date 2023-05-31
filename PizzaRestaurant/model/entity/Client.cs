using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.entity
{
    public class Client: IClient
    {
        
        public string Name { get; set; }

        public Address Address { get; set; }

        public List<IFinishedProduct> Order { get; set; }

        public int Money { get; set; }
        public Client(string name, Address address, List<IFinishedProduct> order)
        {
            Name = name;
            Address = address;
            Order = order;
        }
        public int CostOfOrder()
        {
            return Order.Sum(product => product.Price);
        }

    }
}
