using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    public class Coin  //for inheritance?
    {
        public string coinName;
        public double value;
        public int quantity;
        
        
        public Coin(string coinNames, int machineQuantity)
        {
            coinName = coinNames;
            quantity = machineQuantity;
        }

     




    }
}
