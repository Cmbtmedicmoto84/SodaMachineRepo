using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Penny : Coin
    {
        public Penny(double value)
        {
            this.value = value;
            value = 0.01;
        }
    }
}
