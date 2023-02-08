using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSpring2023
{
    public class CelsiusObserver: IObserver1
    {

        // class Variables
        private double temperature = 0.0;
        private double humidity = 0.0;
        private double pressure = 0.0;


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

        // Constructors
        public CelsiusObserver() : this(0.0, 0.0, 0.0) // basic constructor here
        {

        }
        public CelsiusObserver(double aTemperature, double aPressure, double aHumidity)
        // this is basically setting the variables to what is currently in the main program initialization of 0.0 0.0 0.0
        {
            this.Temperature = aTemperature; // calling the fuction at the top to get and set
            this.Pressure = aPressure;
            this.Humidity = aHumidity;
        }

        // Methods
        // This is updating the retrieved result from Iobserver to all the observers subscribed (which got its functionality from weather station) to display the result with the Update heartbeat
        public void Update(double aTemperature, double aPressure, double aHumidity)
        {
            this.Temperature =(aTemperature - 32) * 5 / 9;
            this.Pressure = aPressure;
            this.Humidity = aHumidity;


        }
        public override string ToString()
        {
            string message = "";
            message = message + "The Current Conditions w/ Celsius Observer: \n\n";
            message = message + "The Temperature in Celsius: " + this.Temperature + "\n";
            message = message + "The Pressure: " + this.Pressure + "\n";
            message = message + "The Humidity: " + this.Humidity + "\n";
            return message;
        }


    }
}
