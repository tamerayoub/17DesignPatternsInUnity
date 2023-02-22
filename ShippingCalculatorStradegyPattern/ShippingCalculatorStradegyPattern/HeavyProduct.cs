using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCalculatorStradegyPattern
{
    public class HeavyProduct: IShippingCalculator
    {

        public string Shipping()
        {
            return "This is Heavy Product";
        }

    }
}
