using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCalculatorStradegyPattern
{
    class Car: Vehicle
    {
        public IShippingCalculator vehicleShipping = new LightProduct();

      

        public Car(string modelType, string modelYear) // contstructor parameratized 
        {
            ModelYear = modelYear;
            ModelType = modelType;
            ModelWeight = vehicleShipping.Shipping();
        }


    }
}
