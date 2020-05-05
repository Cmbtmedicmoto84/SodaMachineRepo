using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Quarter : Coin
    {
        public Quarter(double value)
        {
            this.value = value;
            value = 0.25;
        }
    }
}
