using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingCalculatorStradegyPattern
{
    public class Vehicle 
    {
        private string modelYear = "n/a";
        private string modelType = "n/a";
        private string modelWeight = "n/a";

        public string ModelYear
            {  get { return modelYear; } set { modelYear = value; } }

        public string ModelType
        { get { return modelType; } set { modelType = value; } }

        public string ModelWeight
        { get { return modelWeight; } set { modelWeight = value; } }


        public Vehicle() // contstructor 
        {

        }

        public Vehicle(string modelType, string modelYear) // contstructor parameratized 
        {
            ModelYear = modelYear;
            ModelType = modelType; 
       
        }

        public void Display()
        {
            Console.WriteLine("Model type:" + ModelType);
            Console.WriteLine("Model year:" + ModelYear);
            Console.WriteLine("Model weight:" + ModelWeight);
            
        }
      


    }
        
}
