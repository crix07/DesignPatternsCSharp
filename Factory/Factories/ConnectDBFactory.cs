using Factory.Enums;
using Factory.Interfaces;
using Factory.Models;

namespace Factory.Factories
{
    class ConnectDBFactory : IAbstractFactory
    {
        public IConnectionDB GetDB(EnumConnectionDB WhatObject)
        {
            if (WhatObject == EnumConnectionDB.POSTGRES)
            {
                return new PostGres();
            }
            if (WhatObject == EnumConnectionDB.SQLSERVER)
            {
                return new SQLServer();
            }
            if (WhatObject == EnumConnectionDB.MONGODB)
            {
                return new MongoDB();
            }

            return new DefaultConnection();
        }


        public IConnectionREST GetRest(string service)
        {
            throw new System.NotImplementedException();
        }
    }
}
