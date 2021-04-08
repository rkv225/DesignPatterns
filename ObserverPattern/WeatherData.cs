using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        public IList<IObserver> Observers { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            Observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (IObserver observer in Observers)
                observer.Update(this.Temperature, this.Humidity, this.Pressure);
        }

        public void MeasurementsChanged()
        {
            this.NotifyObserver();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperature = temperature;
            this.Humidity = humidity;
            this.Pressure = pressure;
            this.MeasurementsChanged();
        }
    }
}
