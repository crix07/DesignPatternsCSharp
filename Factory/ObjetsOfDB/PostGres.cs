using System;

namespace Factory
{
    class PostGres : IConnectionDB
    {
        public void Connect()
        {
            Console.WriteLine($"connect ${GetType()}");
        }

        public void Disconnect()
        {
            Console.WriteLine($"desconnect ${GetType()}");
        }
    }
}
