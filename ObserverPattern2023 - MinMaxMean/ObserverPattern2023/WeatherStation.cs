// Written By John
// 1/12/2023
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSpring2023
{
    public class WeatherStation : IObserveable1 //  takes the functions subscribe, unsubscribe and notify from iobserveable subject
    {
        private double temperature = 0.0;
        private double humidity = 0.0;
        private double pressure = 0.0;

        // List of Observers
        List<IObserver1> listOfObservers = new List<IObserver1>(); // initializes the list of observers

        // Gets and Sets, which is used to get and set and notify the notify function ot add the new results to the list
        public double Temperature 
        {
            get { return this.temperature; }
            set { 
                    this.temperature = value;
                    this.Notify(this.Temperature, this.Pressure, this.Humidity); // we get the temperature, and then we set it to the notify function to add it to the list
                }
        }

      

        public double Humidity
        {
            get { return this.humidity; }
            set { 
                    this.humidity = value;
                    this.Notify(this.Temperature, this.Pressure, this.Humidity);
            }
        }

        public double Pressure
        {
            get { return this.pressure; }
            set { 
                    this.pressure = value;
                    this.Notify(this.Temperature, this.Pressure, this.Humidity);
            }
        }

        // Constructor
        public WeatherStation(): this(0.0, 0.0, 0.0)
        {

        }

        public WeatherStation(double aTemperature, double aPressure, double aHumidity)
        {
            this.Temperature = aTemperature; // calls the top functions to assign these variables being delivers from the main program 
            this.Pressure = aPressure;
            this.Humidity = aHumidity;
        }
        // Methods

        // *****************************************************
        // Assume these three methods are triggered by sensors, if you want to manually set from the main program 
        // *****************************************************
        public void SetTemperature(double aTemperature)
        {
            this.Temperature = aTemperature; 
        }
        public void SetHumidity(double aHumidity)
        {
            this.Humidity = aHumidity;
        }
        public void SetPressure(double aPressure)
        {
            this.Pressure = aPressure;
        }

        // *****************************************************
        // *****************************************************
        // *****************************************************

        // an observer is basically a substitutional parameter that is being called and added that could be anObserver1, anObserver2 or 3, depending on the call from the main program and who to subscribe.
        public void Subscribe(IObserver1 anObserver)
        {
            listOfObservers.Add(anObserver);
        }

        public void UnSubscribe(IObserver1 anObserver)
        {
            listOfObservers.Remove(anObserver);
        }

        public void Notify(double aTemperature, double aPressure, double aHumidity)
        {
            foreach(var o in listOfObservers)
            {
                o.Update(aTemperature, aPressure, aHumidity); // this updates each obser in the list with the new sensor updates or regular weather station calls
            }
        }
    }
}
