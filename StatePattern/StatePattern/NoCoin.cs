using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class NoCoin : State
    {
        // we're going to access the current state of the machine through the context parameter
        public override void InsertCoin(VendingMachine context)
        {
            context.State = new CoinInserted();
            Console.WriteLine("Coin Selected pick an Item");

        }


        public override void EjectCoin(VendingMachine context)
        {

            Console.WriteLine("There is no coin to return");
        }


        public override void SelectItem(VendingMachine context)
        {
            Console.WriteLine("There is no coin to return");
        }


        public override void DispenseItem(VendingMachine context)
        {
            Console.WriteLine("There is no coin to return");
        }


    }
}


