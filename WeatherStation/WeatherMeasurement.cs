using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    [Serializable]
    class WeatherMeasurement
    {
        public string City { get; set; }
        public DateTime SunRise { get; set; }
        public DateTime SunSet { get; set; }
        public float TemperatureCurrent { get; set; }
        public float TemperatureMin { get; set; }
        public float TemperatureMax { get; set; }
        public string temperatureUnit;
        public string TemperatureUnit {
            get {
                if (temperatureUnit.ToLower() == "imperial")
                {
                    return "°F";
                }
                else if (temperatureUnit.ToLower() == "metric")
                {
                    return "°C";
                }
                else
                {
                    return "°K";
                }
            }
            set {
                temperatureUnit = value;
            }
        }
        public int Humidity { get; set; }
        public int Pressure { get; set; }
        public string PressureUnit { get; set; }
        public float WindSpeed { get; set; }
        public string WindName { get; set; }
        public string WindDirection { get; set; }
        public int CloudsValue { get; set; }
        public string CloudsName { get; set; }
        public string WeatherValue { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
