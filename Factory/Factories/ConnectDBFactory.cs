

namespace Factory
{
    class ConnectDBFactory
    {
        public IConnectionDB GetConnection(EnumConnection WhatObject)
        {
            if (WhatObject == EnumConnection.POSTGRES)
            {
                return new PostGres();
            }
            if (WhatObject == EnumConnection.SQLSERVER)
            {
                return new SQLServer();
            }
            if (WhatObject == EnumConnection.MONGODB)
            {
                return new MongoDB();
            }

            return new DefaultConnection();
        }
    }
}
