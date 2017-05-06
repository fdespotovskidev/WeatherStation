using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace WeatherStation
{
    class WeatherMap
    {
        public WeatherMeasurement Measurement;
        public string Units;
        public string City;
        private string MeasurementSourceAddress;
        private readonly string API_KEY;
        private XmlDocument WeatherData;

        public WeatherMap()
        {
            Units = "metric";
            City = null;
            API_KEY = "078cad657bca5d19cc379ea68c5e5f26";
            WeatherData = new XmlDocument();
        }

        public bool LoadLastMeasurement()
        {
            try
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                using (FileStream fs = new FileStream("LastMeasurement.me", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    Measurement = fmt.Deserialize(fs) as WeatherMeasurement;
                }
            }
            catch(Exception e)
            {
                return false;
            }
            City = Measurement.City;

            return true;
        }
        public bool UpdateMeasurement()
        {
            MeasurementSourceAddress = "http://api.openweathermap.org/data/2.5/find?q=" + City + "&mode=xml&units=" + Units + "&APPID=" + API_KEY;
            try
            {
                WeatherData.Load(MeasurementSourceAddress);
            }
            catch(Exception e)
            {
                return false;
            }
            
            Measurement = new WeatherMeasurement();
            XmlNode node;

            node = WeatherData.SelectSingleNode("//city");
            Measurement.City = node.Attributes[1].Value;
            node = WeatherData.SelectSingleNode("//sun");
            string SunRiseDate = node.Attributes[0].Value;
            Measurement.SunRise = DateTime.Parse(SunRiseDate);
            string SunSetDate = node.Attributes[1].Value;
            Measurement.SunSet = DateTime.Parse(SunSetDate);
            node = WeatherData.SelectSingleNode("//temperature");
            int CurrentTemperature;
            int.TryParse(node.Attributes[0].Value, out CurrentTemperature);
            Measurement.TemperatureCurrent = CurrentTemperature;
            int MinTemperature;
            int.TryParse(node.Attributes[1].Value, out MinTemperature);
            Measurement.TemperatureMin = MinTemperature;
            int MaxTemperature;
            int.TryParse(node.Attributes[2].Value, out MaxTemperature);
            Measurement.TemperatureMax = MaxTemperature;
            Measurement.TemperatureUnit = node.Attributes[3].Value;
            node = WeatherData.SelectSingleNode("//humidity");
            int Humidity;
            int.TryParse(node.Attributes[0].Value, out Humidity);
            Measurement.Humidity = Humidity;
            node = WeatherData.SelectSingleNode("//pressure");
            int Pressure;
            int.TryParse(node.Attributes[0].Value, out Pressure);
            Measurement.Pressure = Pressure;
            Measurement.PressureUnit = node.Attributes[1].Value;
            node = WeatherData.SelectSingleNode("//speed");
            float WindSpeed;
            float.TryParse(node.Attributes[0].Value, out WindSpeed);
            Measurement.WindSpeed = WindSpeed;
            Measurement.WindName = node.Attributes[1].Value;
            node = WeatherData.SelectSingleNode("//direction");
            Measurement.WindDirection = node.Attributes[2].Value;
            node = WeatherData.SelectSingleNode("//clouds");
            int CloudsValue;
            int.TryParse(node.Attributes[0].Value, out CloudsValue);
            Measurement.CloudsValue = CloudsValue;
            Measurement.CloudsName = node.Attributes[1].Value;
            node = WeatherData.SelectSingleNode("//weather");
            Measurement.WeatherValue = node.Attributes[1].Value;
            node = WeatherData.SelectSingleNode("//lastupdate");
            string LastUpdate = node.Attributes[0].Value;
            Measurement.LastUpdate = DateTime.Parse(LastUpdate);

            //saving measurement to file
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (FileStream fs = new FileStream("LastMeasurement.me", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                fmt.Serialize(fs, Measurement);
            }

            return true;
        }
    }
}
