namespace PizzaRestorant.model.Utils
{
    public static partial class Utils
    {
        public static string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
