using System;

namespace ShippingCalculatorStradegyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        

           
            Vehicle model1 = new SemiTruck("1998","BMW" );
            Vehicle model2 = new Car("1921", "Benz");

            model1.Display();
            model2.Display();
        }
    }
}
