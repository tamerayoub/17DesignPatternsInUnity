using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class VendingMachine
    {

        private State state = new NoCoin();
        private int numberOfItems = 10;
        public State State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public VendingMachine() // this is a constructor 
        {
            this.state = new NoCoin();
        }

        public void InsertCoin()
        {
            // normally you would have had a bunch of long if statements in here, we are going to split these up into different objects
            this.State.InsertCoin(this);
        }

        public void EjectCoin()
        {
            this.State.EjectCoin(this);
        }

        public void SelectItem()
        {
            this.State.SelectItem(this);
            this.State.DispenseItem(this);
        }

        public void DispenseItem()
        {
            this.State.DispenseItem(this);
        }
    }
}
