using PizzaRestaurant.model.@interface;

namespace PizzaRestaurant.model.observer;

public class EventManager
{
    private Dictionary<string, List<IObserver>> Observers { get; set; }

    public EventManager()
    {
        Observers = new Dictionary<string, List<IObserver>>();
    }
    
    public EventManager(Dictionary<string, List<IObserver>> observers)
    {
        Observers = observers;
    }

    public void Subscribe(string eventType, IObserver listener)
    {
        if (Observers.TryGetValue(eventType, out var observer))
        {
            observer.Add(listener);
        }
        else
        {
            Observers.Add(eventType, new List<IObserver>{listener});
        }
       
    }
    
    public void Unsubscribe(string eventType, IObserver listener)
    {
        if (!Observers.ContainsKey(eventType)) throw new Exception("This event doesn't exist");
        
        var observers = Observers[eventType];
        if (observers.Count > 1)
        {
            observers.Remove(listener);
        }
        else
        {
            Observers.Remove(eventType);
        }
    }

    public void Notify(string eventType, List<IFinishedProduct> data)
    {
        if (!Observers.ContainsKey(eventType)) throw new Exception("This event doesn't exist");
        
        var observers = Observers[eventType];
        
        foreach (var observer in observers)
        {
            observer.Update(data);
        }
    }

}