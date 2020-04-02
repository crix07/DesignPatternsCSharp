using Factory.Interfaces;
using System;

namespace Factory_And_AbstractFactory.ObjectsOfRest
{
    class ConnectionRestBuy : IConnectionREST
    {
        public void readURL(string URL)
        {
            Console.WriteLine($"restful service active ✌ {URL}");
        }
    }
}
