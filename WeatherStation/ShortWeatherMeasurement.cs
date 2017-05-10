using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    [Serializable]
    class ShortWeatherMeasurement
    {
        public DateTime Date { get; set; }
        public string TemperatureUnit { get; set; }
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
