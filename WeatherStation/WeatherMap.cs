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

        private string FiveDayMeasurementSourceAddress;
        private XmlDocument FiveDayWeatherData;
        public List<ShortWeatherMeasurement> FiveDayMeasurements;

        public WeatherMap()
        {
            Units = "metric";
            City = null;
            API_KEY = "078cad657bca5d19cc379ea68c5e5f26";
            WeatherData = new XmlDocument();
            FiveDayWeatherData = new XmlDocument();
            FiveDayMeasurements = new List<ShortWeatherMeasurement>();
        }

        private void parseFloat(string source, out float target)
        {
            string[] parts = source.Split('.');
            int whole, frac;
            int.TryParse(parts[0], out whole);
            if(parts.Length == 2)
            {
                int.TryParse(parts[1], out frac);
                if(frac<10)
                {
                    frac *= 10;
                }
                target = whole + frac / 100.0f;
            }
            else
            {
                target = whole;
            }
            
        }

        public bool LoadLastMeasurement()
        {
            try
            {
                System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                using (FileStream fs = new FileStream("LastMeasurement.me", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    Measurement = fmt.Deserialize(fs) as WeatherMeasurement;
                    FiveDayMeasurements = fmt.Deserialize(fs) as List<ShortWeatherMeasurement>;
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
            parseFloat(node.Attributes[0].Value, out WindSpeed);
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

            //Five day forecast update

            FiveDayMeasurementSourceAddress = "http://api.openweathermap.org/data/2.5/forecast/daily?q=" + City + "&mode=xml&units=" + Units + "&APPID=" + API_KEY;
            
            try
            {
                FiveDayWeatherData.Load(FiveDayMeasurementSourceAddress);
            }
            catch(Exception e)
            {
                return false;
            }

            FiveDayMeasurements.Clear();

            foreach(XmlNode time_node in FiveDayWeatherData.SelectNodes("//time"))
            {
                ShortWeatherMeasurement cur = new ShortWeatherMeasurement();
                cur.Date = DateTime.Parse(time_node.Attributes[0].Value);
                node = time_node.SelectSingleNode("temperature");

                float dayTemp, minTemp, maxTemp, nightTemp;
                parseFloat(node.Attributes[0].Value, out dayTemp);
                parseFloat(node.Attributes[1].Value, out minTemp);
                parseFloat(node.Attributes[2].Value, out maxTemp);
                parseFloat(node.Attributes[3].Value, out nightTemp);

                cur.TemperatureDay = dayTemp;
                cur.TemperatureMin = minTemp;
                cur.TemperatureMax = maxTemp;
                cur.TemperatureNight = nightTemp;

                cur.TemperatureUnit = Units;

                node = time_node.SelectSingleNode("clouds");
                cur.CloudsName = node.Attributes[0].Value;
                int.TryParse(node.Attributes[1].Value, out CloudsValue);
                cur.CloudsValue = CloudsValue;
                FiveDayMeasurements.Add(cur);
            }

            //saving measurement to file
            System.Runtime.Serialization.IFormatter fmt = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (FileStream fs = new FileStream("LastMeasurement.me", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                fmt.Serialize(fs, Measurement);
                fmt.Serialize(fs, FiveDayMeasurements);
            }

            return true;
        }
    }
}
