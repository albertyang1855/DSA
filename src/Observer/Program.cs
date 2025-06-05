using Observer.domain.Impl;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();

        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

        weatherData.SetMeasurements(22.5f, 65f, 1013.1f);
        weatherData.SetMeasurements(23.0f, 70f, 1012.5f);
    }
}
