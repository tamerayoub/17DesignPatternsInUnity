using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverSpring2023
{
    public class Celsius: ITemperature
    {
        public double Convert(double aTemperature)
        {
            return (aTemperature - 32) * 5 / 9;
        }
    }
}
