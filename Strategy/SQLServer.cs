using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class SQLServer : IStrategy
    {
        public string doOperation()
        {
            return $"I'M the connection of sqlserver {GetType()}";
        }
    }
}
