using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSpring2023
{
    public class StatisticsObserver: IObserver1
    {
        // class Variables
        private double temperature = 0.0;
        private double humidity = 0.0;
        private double pressure = 0.0;


        List<Double> Temp1 = new List<Double>();
        List<Double> Pressure1 = new List<Double>();
        List<Double> Humidity1 = new List<Double>();

        // gets and sets
        public double Temperature
        {
            get { return this.temperature; }
            set { this.temperature = value; }
        }

        public double Humidity
        {
            get { return this.humidity; }
            set { this.humidity = value; }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { this.pressure = value; }
        }

      

        public StatisticsObserver() : this(0.0, 0.0, 0.0) // basic constructor here
        {

        }

        public StatisticsObserver(double aTemperature, double aPressure, double aHumidity)
        // this is basically setting the variables to what is currently in the main program initialization of 0.0 0.0 0.0
        {
            this.Temperature = aTemperature; // calling the fuction at the top to get and set
            this.Pressure = aPressure;
            this.Humidity = aHumidity;
        }
       

        public void Update(double aTemperature, double aPressure, double aHumidity)
        {
            this.Temperature = aTemperature;
            this.Pressure = aPressure;
            this.Humidity = aHumidity;

            Temp1.Add(aTemperature);
            Pressure1.Add(aPressure);
            Humidity1.Add(aHumidity);



        }
        public string returnTemps()
        {
            return Temp1.Average() + " " + Temp1.Max() + " " + Temp1.Min();
        }



        public string returnPressure()
        {
            return Pressure1.Average() + " " + Pressure1.Max() + " " + Pressure1.Min();
        }



        public string returnHumidity()
        {
            return Humidity1.Average() + " " + Humidity1.Max() + " " + Humidity1.Min();
        }

        public override string ToString()
        {
            string message = "";
           
            message = message + "Humidity Stats Mean Max Min : " + returnHumidity() +  "\n";
            message = message + "Pressure Stats Mean Max Min : " + returnPressure() +  "\n";
            message = message + "Temps Stats Mean Max Min : " +  returnTemps() + "\n";
            return message;
        }
    }
}
