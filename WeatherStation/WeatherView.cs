using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStation.Properties;

namespace WeatherStation
{
    public partial class WeatherView : UserControl
    {

        private ShortWeatherMeasurement measurement;
        internal ShortWeatherMeasurement Measurement
        {
            get
            {
                return measurement;
            }

            set
            {
                measurement = value;
                UpdateView();
            }
        }

        public WeatherView(ShortWeatherMeasurement measurement = null)
        {
            InitializeComponent();
            Measurement = measurement;
        }

        private void ResetView()
        {
            lblDate.Text = "-";
            lblCloudsDescription.Text = "-";
            lblMaximumTemperature.Text = "-";
            lblMinimumTemperature.Text = "-";
            lblCurrentTemperature.Text = "-";
            picWeatherIcon.Image = null;
        }

        private void UpdateView()
        {
            if (Measurement == null)
            {
                ResetView();
            }
            else
            {
                if(Measurement.CloudsName.ToLower().Contains("cloud"))
                {
                    picWeatherIcon.Image = Resources.clouds_128x128;
                }
                else if (Measurement.CloudsName.ToLower().Contains("clear"))
                {
                    picWeatherIcon.Image = Resources.sun_128x128;
                }
                else if (Measurement.CloudsName.ToLower().Contains("storm"))
                {
                    picWeatherIcon.Image = Resources.storm_128x128;
                }
                else if (Measurement.CloudsName.ToLower().Contains("snow"))
                {
                    picWeatherIcon.Image = Resources.snow_128x128;
                }

                lblDate.Text = Measurement.Date.ToShortDateString();
                lblCloudsDescription.Text = Measurement.CloudsName;
                lblMinimumTemperature.Text = string.Format("{0:00.0}{1}", Measurement.TemperatureMin, Measurement.TemperatureUnit);
                lblMaximumTemperature.Text = string.Format("{0:00.0}{1}", Measurement.TemperatureMax, Measurement.TemperatureUnit);
                lblCurrentTemperature.Text = string.Format("{0:00.0}{1}", Measurement.TemperatureDay, Measurement.TemperatureUnit);
            }
        }
    }
}
