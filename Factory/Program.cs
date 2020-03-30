using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------FACTORY PATTERN ----------------


            ConnectDBFactory connection = new ConnectDBFactory();


            IConnectionDB db = connection.GetConnection(EnumConnection.MONGODB);

            db.Connect();

            db.Disconnect();

        }
    }
}
