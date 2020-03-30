using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class MongoDB : IConnectionDB
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
