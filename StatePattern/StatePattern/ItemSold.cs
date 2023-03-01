using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class ItemSold : State
    {
        public override void InsertCoin(VendingMachine context)
        {

            Console.WriteLine("You cannot insert another coin while the machine is dispensing");
        }


        public override void EjectCoin(VendingMachine context)
        {
            Console.WriteLine("You cannot get your money back while the machine is dispensing");
        }


        public override void SelectItem(VendingMachine context)
        {
            Console.WriteLine("You cannot select another choice while the machine is dispensing");
        }


        public override void DispenseItem(VendingMachine context)
        {
            context.State = new NoCoin();
            Console.WriteLine("Thank you for shopping! Item is being dispensed...");
        }


    }
}
