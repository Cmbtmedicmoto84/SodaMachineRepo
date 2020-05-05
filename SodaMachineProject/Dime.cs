using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Dime : Coin
    {
        public double value;
        public Dime()
        {
            name = "dime";
            value = 0.10;
        }
    }
}
