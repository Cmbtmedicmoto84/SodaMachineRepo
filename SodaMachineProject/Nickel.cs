using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Nickel : Coin
    {

        public Nickel(double value)
        {
            this.value = value;
            value = 0.05;
            
        }
    }
}
