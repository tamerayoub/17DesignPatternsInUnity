using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCalculatorStradegyPattern
{
    class SemiTruck : Vehicle
    {

        public IShippingCalculator vehicleShipping = new HeavyProduct();



        public SemiTruck(string modelType, string modelYear) // contstructor parameratized 
        {
            ModelYear = modelYear;
            ModelType = modelType;
            ModelWeight = vehicleShipping.Shipping();
        }

    }
}
