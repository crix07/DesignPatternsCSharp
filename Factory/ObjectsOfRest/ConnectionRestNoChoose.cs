using Factory_And_AbstractFactory.Interfaces;
using System;

namespace Factory_And_AbstractFactory.ObjectsOfRest
{
    class ConnectionRestNoChoose : IConnectionREST
    {
        public void readURL(string URL)
        {
            Console.WriteLine("No choose connection");
        }
    }
}
