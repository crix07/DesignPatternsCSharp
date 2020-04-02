using Factory.Interfaces;
using Factory_And_AbstractFactory.Factories;
using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------FACTORY PATTERN ----------------


            //ConnectDBFactory connection = new ConnectDBFactory();


            //IConnectionDB db = connection.GetConnection(EnumConnection.MONGODB);

            //db.Connect();

            //db.Disconnect();



            //------------------------ABSTRACT FACTORY---------------

            IAbstractFactory abstractFactory = FactoryProducer.GetFactory("REST");

            var resultobject = abstractFactory.GetRest("Buy");
            resultobject.readURL("https://google.com");


        }
    }
}
