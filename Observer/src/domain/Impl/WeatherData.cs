using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.domain.Interface;

namespace Observer.domain.Impl
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            NotifyObservers();
        }
    }

}
