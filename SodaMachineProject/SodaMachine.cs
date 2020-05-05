using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineProject
{
    class SodaMachine
    {
        //membervariables
        public string soda;
        public int canQuantity;
        public Coin coin;
        public double canCost;
        public List<Coin> register;  //internal-limited variable
        List<string> sodaType;


        //constructor
        public SodaMachine()
        {
            //call register
            register = new List<Coin>();
            priceForCola = 0.25;
            priceForRootBeer = 0.35;
            priceForOrangeSoda = 0.20;
        }          
        
        public SodaMachine(string sodas, int canQuantitys, double canCosts, Coin coins)
        {
            soda = sodas;
            canQuantity = canQuantitys;
            canCost = canCosts;
            coin = coins;
        }

        public void InternalRegister(List<Coin> register)
        {
            this.register = register;
        }

        //membermethods
        public void TakeInMoney(List<Coin> register) //list as parameter
        {
            //pass coin list

            if (insertedValue == valueOfSoda)  //if exact change, accept and dispense
            {
                dispenseSodaToCustomer;
            }
            else if (insertedValue < valueOfSoda)  //if not enough $, do not complete & return $
            {
                Console.WriteLine("Not enough to purchase.");
                refundBackInsertedChange;

            }
            else if (insertedValue > valueOfSoda) //if too much $, accept, return from coin internal/limited register, return soda instance from internal/limited inventory
            {
                Console.WriteLine("Your change due is " + leftOverValue);
                dispenseSodaToCustomer;
                dispenseLeftoverValue;

            }  
            else if (insertedValue > availableChangeInRegister)  //if $ exceeds change amount available in internal/limited register, do not complete & return $
            {
                Console.WriteLine("Not able to provide adequate change.");
                refundBackInsertedChange;
            }
            else if (insertedValue >= valueOfSoda && selectedSoda > sodaInventory)
            {
                Console.WriteLine("Out of stock! Please try your transaction again");
                refundBackInsertedChange;
            }



            

                //if exact $ or too much $, but not sufficient soda inventory for chosen soda, do not complete & return $
        }


    }
}
