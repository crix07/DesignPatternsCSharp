using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Connection
    {

        private static Connection instance = null;

        private Connection()
        {

        }


        public static Connection GetInstance()
        {
            if (instance == null)
                instance = new Connection();

            return instance;
        }

        public void Confirm()
        {
            Console.WriteLine("call from the instance");
        }

    }
}
