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
        public double value;


        public Nickel()
        {
            name = "nickel";
            value = 0.05;  
        }
    }
}
