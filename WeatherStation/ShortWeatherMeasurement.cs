using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    [Serializable]
    public class ShortWeatherMeasurement
    {
        public DateTime Date { get; set; }
        private string temperatureUnit;
        public string TemperatureUnit
        {
            get
            {
                if(temperatureUnit.ToLower() == "imperial")
                {
                    return "°F";
                }
                else if(temperatureUnit.ToLower() == "metric")
                {
                    return "°C";
                }
                else
                {
                    return "°K";
                }
            }
            set
            {
                temperatureUnit = value;
            }
        }
        public float TemperatureDay { get; set; }
        public float TemperatureMin { get; set; }
        public float TemperatureMax { get; set; }
        public float TemperatureNight { get; set; }

        public int CloudsValue { get; set; }
        public string CloudsName { get; set; }

        public override string ToString()
        {
            return string.Format("From: {0}, Temperature: Day {1:0.00} {2} Min {3:0.00} {2} Max {4:0.00} {2} Night {5:0.00} {2} Clouds: {6}, {7}%", Date.ToLocalTime().ToShortDateString(), TemperatureDay, TemperatureUnit == "metric" ? "C" : "F", TemperatureMin, TemperatureMax, TemperatureNight, CloudsName, CloudsValue);
        }
    }
}
