using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class MongoDB : IStrategy
    {
        public string doOperation()
        {
            return $"i'm the connection of {GetType()}";
        }
    }
}
