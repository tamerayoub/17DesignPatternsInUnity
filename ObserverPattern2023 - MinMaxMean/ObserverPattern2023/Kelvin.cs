using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSpring2023
{
    public class Kelvin : ITemperature
    {
        public double Convert(double aTemperature)
        {
            return aTemperature + 273.15;
        }
    }
}
