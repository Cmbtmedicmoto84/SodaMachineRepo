using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class SodaMachine
    {
        //membervariables
        public string sodaFlavors;
        public int canQuantity;
        public Coin coins;
        public double canCost;
        //private double startingPenny;
        //private double startingNickel;
        //private double startingDime;
        //private double startingQuarter;

        //constructor
        public SodaMachine()
        {
            //starting coins in internal/limited register for machine
            //pennies = 50
            //nickels = 20
            //dimes = 10
            //quarters = 20

            //starting inventory and cost
            //colaQuantity = 5
            //colaCost = .15
            //orangeQuantity = 3
            //orangeCost = .25
            //rootBeerQuantity = 10
            //rootbeerCost = .50
            
        }
        public SodaMachine(string sodaFlavor, int canQuantitys, double canCosts, Coin coin)
        {
            sodaFlavors = sodaFlavor;
            canQuantity = canQuantitys;
            canCost = canCosts;
            coins = coin;
        }

        //membermethods
        public void TakeInMoney()
        {
            //pass coin list

            //if exact change, accept and dispense

            //if not enough $, do not complete & return $

            //if too much $, accept, return from coin internal/limited register, return soda instance from internal/limited inventory

            //if $ exceeds change amount available in internal/limited register, do not complete & return $

            //if exact $ or too much $, but not sufficient soda inventory for chosen soda, do not complete & return $
        }


    }
}
