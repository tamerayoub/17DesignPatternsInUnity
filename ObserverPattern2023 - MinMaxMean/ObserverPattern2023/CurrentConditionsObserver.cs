// Written By John
// 1/12/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSpring2023
{
    public class CurrentConditionsObserver: IObserver1
    {
        // class Variables
        private double temperature = 0.0;
        private double humidity = 0.0;
        private double pressure = 0.0;
        private ITemperature temperatureConverter = new Celsius();
       
        public CurrentConditionsObserver(ITemperature anITemperature)

        {
            this.temperatureConverter = anITemperature;
        }

        public void SetTemperatureUnits(ITemperature anITemperature)
        {
            this.temperatureConverter = anITemperature;

        }
        


        // gets and sets
        public double Temperature
        {
            get { return this.temperatureConverter.Convert(this.temperature); }
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

        // Constructors
        public CurrentConditionsObserver()
        {

        }
       

        // Methods
        // This is updating the retrieved result from Iobserver to all the observers subscribed (which got its functionality from weather station) to display the result with the Update heartbeat
        public void Update(double aTemperature, double aPressure, double aHumidity)
        {
            this.Temperature = aTemperature;
            this.Pressure = aPressure;
            this.Humidity = aHumidity;
        }
        public override string ToString()
        {
            string message = "";
            message = message + "The Current Conditions w/ Stradegy Pattern: \n\n";
            message = message + "The Current Temperature in Celsius is: " + this.Temperature + "\n";
            message = message + "The Current Pressure is: " + this.Pressure + "\n";
            message = message + "The Current Humidity is: " + this.Humidity + "\n";
            return message;
        }
    }
}
