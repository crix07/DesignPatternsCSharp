using Factory.Interfaces;
using System;

namespace Factory.Models
{
    public class MongoDB : IConnectionDB
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
