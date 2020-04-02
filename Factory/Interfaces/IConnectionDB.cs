using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Interfaces
{
    public interface IConnectionDB
    {
        void Connect();
        void Disconnect();
    }
}
