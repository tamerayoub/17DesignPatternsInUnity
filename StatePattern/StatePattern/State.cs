using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
namespace StatePattern
{
    public abstract class State
    {
        public abstract void InsertCoin(VendingMachine context);


        public abstract void EjectCoin(VendingMachine context);


        public abstract void SelectItem(VendingMachine context);


        public abstract void DispenseItem(VendingMachine context);
        
    }
}
// abstact classses and methods cannot be created again, only child classes can be created , you must override them
// just a industry standard 