using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCalculatorStradegyPattern
{
    public class LightProduct: IShippingCalculator
    {
        public string Shipping()
        {
            return "This is Light Product";
        }
    }
}
