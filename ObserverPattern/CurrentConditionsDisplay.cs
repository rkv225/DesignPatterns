using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public ISubject WeatherData { get; set; }

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {this.Temperature}F degrees and humidity {this.Humidity}");
        }
    }
}
