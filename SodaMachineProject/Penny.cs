using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Penny : Coin
    {
        public double value;
        
        public Penny()
        {
            name = "penny";
            value = 0.01;
        }
    }
}
