using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class CoinInserted : State
    {
        public override void InsertCoin(VendingMachine context)
        {

            Console.WriteLine("You cannot input a second coin");
        }


        public override void EjectCoin(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("Coin Returned");
        }


        public override void SelectItem(VendingMachine context)
        {

            context.State = new ItemSold();
            Console.WriteLine("Your item is selected");
        }


        public override void DispenseItem(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("You must select an Item first");
        }


    }
}
