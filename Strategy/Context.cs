using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Context : IStrategy
    {
        private IStrategy strategy;
          
        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string doOperation()
        {
            return strategy.doOperation();
        }

    }
}
