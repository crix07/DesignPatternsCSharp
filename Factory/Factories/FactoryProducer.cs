using Factory.Factories;
using Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_And_AbstractFactory.Factories
{
    public class FactoryProducer
    {

        public static IAbstractFactory GetFactory(string typeFactory)
        {
            if (typeFactory == "DB")
                return new ConnectDBFactory();
            if (typeFactory == "REST")
                return new RestfulFactory();
            return null;
        }

    }
}
