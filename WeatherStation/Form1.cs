using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WeatherStation
{
    public partial class Form1 : Form
    {

        private WeatherMap CurrentWeather;


        public Form1()
        {
            InitializeComponent();
            
            CurrentWeather = new WeatherMap();

            if (CurrentWeather.LoadLastMeasurement())
            {
                UpdateView();
            } else
            {
                CurrentWeather = new WeatherMap();
                MessageBox.Show("Error! Load of measurement data failed!", "Error loading measurement data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateView()
        {
            lblCity.Text = CurrentWeather.Measurement.City;
            lblSunRise.Text = CurrentWeather.Measurement.SunRise.ToLocalTime().ToShortTimeString();
            lblSunSet.Text = CurrentWeather.Measurement.SunSet.ToLocalTime().ToShortTimeString();
            lblWeatherValue.Text = CurrentWeather.Measurement.WeatherValue;
            lblCurrentTemperature.Text = CurrentWeather.Measurement.TemperatureCurrent.ToString() + (CurrentWeather.Units == "metric" ? " C" : CurrentWeather.Measurement.TemperatureUnit);
            lblMinTemperature.Text = CurrentWeather.Measurement.TemperatureMin.ToString() + (CurrentWeather.Units == "metric" ? " C" : CurrentWeather.Measurement.TemperatureUnit);
            lblMaxTemperature.Text = CurrentWeather.Measurement.TemperatureMax.ToString() + (CurrentWeather.Units == "metric" ? " C" : CurrentWeather.Measurement.TemperatureUnit);
            lblHumidity.Text = CurrentWeather.Measurement.Humidity.ToString() + "%";
            lblPressure.Text = string.Format("{0} {1}", CurrentWeather.Measurement.Pressure, CurrentWeather.Measurement.PressureUnit);
            lblWind.Text = string.Format("{0}, {1} km/h, {2}", CurrentWeather.Measurement.WindName, CurrentWeather.Measurement.WindSpeed, CurrentWeather.Measurement.WindDirection);
            lblClouds.Text = string.Format("{0}, {1}%", CurrentWeather.Measurement.CloudsName, CurrentWeather.Measurement.CloudsValue);
            lblLastUpdated.Text = string.Format("{0}, {1}", CurrentWeather.Measurement.LastUpdate.ToLongDateString(), CurrentWeather.Measurement.LastUpdate.ToLocalTime().ToShortTimeString());
            lbFiveDay.Items.Clear();
            foreach(ShortWeatherMeasurement swm in CurrentWeather.FiveDayMeasurements)
            {
                lbFiveDay.Items.Add(swm.ToString());
            }
        }
        private void btnUpdateWeather_Click(object sender, EventArgs e)
        {
            //CurrentWeather.UpdateMeasurement();
            if (tbEnterCity.Text.Trim().Length > 0)
            {
                CurrentWeather.City = tbEnterCity.Text;
                if (CurrentWeather.UpdateMeasurement())
                {
                    UpdateView();
                }
                else
                {
                    MessageBox.Show("Error! Please enter valid information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter a city!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
