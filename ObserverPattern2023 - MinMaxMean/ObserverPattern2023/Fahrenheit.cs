using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSpring2023
{
    public class Fahrenheit: ITemperature
    {
        public double Convert(double aTemperature)
        {
            return (aTemperature * 1.8) + 32;
        }
    }
}
