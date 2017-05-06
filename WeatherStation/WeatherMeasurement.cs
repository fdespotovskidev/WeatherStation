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
        public int TemperatureCurrent { get; set; }
        public int TemperatureMin { get; set; }
        public int TemperatureMax { get; set; }
        public string TemperatureUnit { get; set; }
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
