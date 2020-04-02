using Factory.Enums;
using Factory.Interfaces;
using System;
using Factory_And_AbstractFactory.ObjectsOfRest;

namespace Factory_And_AbstractFactory.Factories
{
    public class RestfulFactory : IAbstractFactory
    {
        public IConnectionDB GetDB(EnumConnectionDB db)
        {
            throw new NotImplementedException();
        }

        public IConnectionREST GetRest(string service)
        {
            if (service == "Buy")
                return new ConnectionRestBuy();
            
            return new ConnectionRestNoChoose();
        }
    }
}
