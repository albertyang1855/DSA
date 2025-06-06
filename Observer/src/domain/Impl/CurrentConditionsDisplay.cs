using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.domain.Interface;

namespace Observer.domain.Impl
{
    public class CurrentConditionsDisplay : IObserver
    {
        private float temperature;
        private float humidity;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {temperature}°C and {humidity}% humidity");
        }
    }

}
