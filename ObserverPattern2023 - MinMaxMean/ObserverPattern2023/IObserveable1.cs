// Written By John
// 1/12/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSpring2023
{
    public interface IObserveable1 // the subject
    {
        void Notify(double aTemperature, double aPressure, double aHumidity);

        void Subscribe(IObserver1 anObserver); 

        void UnSubscribe(IObserver1 anObserver); 
    }
}
