using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class DefaultConnection : IConnectionDB
    {
        public void Connect()
        {
            Console.WriteLine($"connect ${GetType()}");

        }

        public void Desconnect()
        {
            Console.WriteLine($"desconnect ${GetType()}");
        }

    }
}
