using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class SQLServer : IConnectionDB
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
