using System;
using System.Collections.Generic;
using System.Text;

namespace Clone
{
    class Account : IClone
    {
        public int mount;
        public string type;
        public Account(int mount, string type)
        {
            this.mount = mount;
            this.type = type;
        }


        public IClone Clone()
        {
            return this;
        }

    }
}
