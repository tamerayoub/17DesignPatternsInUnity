// written by John
// 1/12/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverSpring2023
{
    public interface IObserver1 // iObserver host alot of the observers which is initialized in the main program using Subscribe, the current conditions and minmaxmean displays are listening here.
    {
        public void Update(double aTemperature, double aPressure, double aHumidity);
    }
}
