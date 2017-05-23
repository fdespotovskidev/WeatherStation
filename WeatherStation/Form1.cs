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
using WeatherStation.Properties;

namespace WeatherStation
{
    public partial class Form1 : Form
    {

        private WeatherMap CurrentWeather;


        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;

            CurrentWeather = new WeatherMap();
            pnlFiveDayWeather.AutoScroll = true;
            pnlFiveDayWeather.WrapContents = false;
            pnlFiveDayWeather.FlowDirection = FlowDirection.TopDown;

            if (CurrentWeather.LoadLastMeasurement())
            {
                if (CurrentWeather.Units == "metric")
                {
                    rbMetric.Checked = true;
                }
                else
                {
                    rbImperial.Checked = true;
                }
                UpdateView();
            } else
            {
                CurrentWeather = new WeatherMap();
                MessageBox.Show("Error! Load of measurement data failed!", "Error loading measurement data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (rbMetric.Checked == true)
                {
                    CurrentWeather.Units = "metric";
                }
                else
                {
                    CurrentWeather.Units = "imperial";
                }
            }

        }

        private Color GetTemperatureColor(float temperature, string unit)
        {
            if(unit == "imperial")
            {
                temperature = Utilities.ToCelsius(temperature);
            }

            if (temperature > 30)
            {
                return Color.Red;
            }
            else if (temperature > 20)
            {
                return Color.Yellow;
            }
            else if (temperature > 10)
            {
                return Color.LightGreen;
            }
            else if (temperature > 0)
            {
                return Color.LightBlue;
            }
            return Color.Blue;
        }

        private void UpdateView()
        {
            lblCity.Text = CurrentWeather.Measurement.City;
            lblSunRise.Text = CurrentWeather.Measurement.SunRise.ToLocalTime().ToShortTimeString();
            lblSunSet.Text = CurrentWeather.Measurement.SunSet.ToLocalTime().ToShortTimeString();
            lblWeatherValue.Text = CurrentWeather.Measurement.WeatherValue;
            lblCurrentTemperature.Text = string.Format("{0:00.0}{1}", CurrentWeather.Measurement.TemperatureCurrent, CurrentWeather.Measurement.TemperatureUnit);
            lblCurrentTemperature.ForeColor = GetTemperatureColor(CurrentWeather.Measurement.TemperatureCurrent, CurrentWeather.Units.ToLower());
            lblMinTemperature.Text = string.Format("{0:00.0}{1}", CurrentWeather.Measurement.TemperatureMin, CurrentWeather.Measurement.TemperatureUnit);
            lblMaxTemperature.Text = string.Format("{0:00.0}{1}", CurrentWeather.Measurement.TemperatureMax, CurrentWeather.Measurement.TemperatureUnit);
            lblHumidity.Text = CurrentWeather.Measurement.Humidity.ToString() + "%";
            lblPressure.Text = string.Format("{0} {1}", CurrentWeather.Measurement.Pressure, CurrentWeather.Measurement.PressureUnit);
            lblWindName.Text = CurrentWeather.Measurement.WindName;
            lblWindSpeed.Text = string.Format("{0:0.00} km/h {1}", CurrentWeather.Measurement.WindSpeed, CurrentWeather.Measurement.WindDirection);
            lblClouds.Text = string.Format("{0}, {1}%", CurrentWeather.Measurement.CloudsName, CurrentWeather.Measurement.CloudsValue);
            lblLastUpdated.Text = string.Format("{0}, {1}", CurrentWeather.Measurement.LastUpdate.ToShortDateString(), CurrentWeather.Measurement.LastUpdate.ToLocalTime().ToShortTimeString());
            pnlFiveDayWeather.Controls.Clear();
            foreach(ShortWeatherMeasurement swm in CurrentWeather.FiveDayMeasurements)
            {
                pnlFiveDayWeather.Controls.Add(new WeatherView(swm));
            }
        }
        private void UpdateWeather()
        {
            if (CurrentWeather.UpdateMeasurement())
            {
                UpdateView();
            }
            else
            {
                MessageBox.Show("Error! Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateWeather_Click(object sender, EventArgs e)
        {
            //CurrentWeather.UpdateMeasurement();
            if (tbEnterCity.Text.Trim().Length > 0)
            {
                CurrentWeather.City = tbEnterCity.Text;
                /*if (CurrentWeather.UpdateMeasurement())
                {
                    UpdateView();
                }
                else
                {
                    MessageBox.Show("Error! Please enter valid information.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
                UpdateWeather();

            }
            else
            {
                MessageBox.Show("Please enter a city!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void rbUnits_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMetric.Checked == true)
            {
                CurrentWeather.Units = "metric";
            }
            else
            {
                CurrentWeather.Units = "imperial";
            }
            UpdateWeather();
        }
    }
}
