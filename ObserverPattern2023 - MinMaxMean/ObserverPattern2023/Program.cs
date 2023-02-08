using System;

namespace ObserverSpring2023
{

    public class Program
    {

        public static void Main(String[] args)
        {
          
            WeatherStation WeatherStation1 = new WeatherStation(90.0, 86.0,95.0);
            
            CurrentConditionsObserver anObserver1 = new CurrentConditionsObserver(); // this makes the new observer 1
            StatisticsObserver anObserver2 = new StatisticsObserver(0.0, 0.0, 0.0); // this makes the new observer 2
            CelsiusObserver anObserver3 = new CelsiusObserver(0.0, 0.0, 0.0); // this makes the new observer 3




            WeatherStation1.Subscribe(anObserver1);

            WeatherStation1.Subscribe(anObserver2);


            WeatherStation1.Subscribe(anObserver3);


            WeatherStation1.SetTemperature(100.0);

            WeatherStation1.Notify(90.0, 24.2, 24.0);
            WeatherStation1.Notify(56.0, 87.2, 31.0);
            WeatherStation1.Notify(31.0, 98.2, 50.0);
            WeatherStation1.Notify(90.0, 24.2, 24.0);
            WeatherStation1.Notify(56.0, 87.2, 31.0);
            WeatherStation1.Notify(31.0, 98.2, 50.0);
            WeatherStation1.Notify(90.0, 24.2, 24.0);
            WeatherStation1.Notify(56.0, 87.2, 31.0);
            WeatherStation1.Notify(31.0, 98.2, 50.0);



            Console.WriteLine(anObserver1.ToString());
            Console.WriteLine(anObserver2.ToString());
            Console.WriteLine(anObserver3.ToString());

            WeatherStation1.SetHumidity(20.0);

            Console.WriteLine(anObserver1.ToString());



        }

    }

}
