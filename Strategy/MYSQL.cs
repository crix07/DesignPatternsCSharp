
namespace Strategy
{
    public class MYSQL : IStrategy
    {
        public string doOperation()
        {
            return $"i'm the connection of {GetType()}";
        }
    }
}
