using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class Quarter : Coin
    {
        public double value;
        
        public Quarter()
        {
            name = "quarter";
            value = 0.25;
        }
    }
}
