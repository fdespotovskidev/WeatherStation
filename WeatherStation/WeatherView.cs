using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void UpdateView()
        {
            if (Measurement == null)
            {
                ResetView();
            }
            else
            {
                lblDate.Text = Measurement.Date.ToShortDateString();
                lblCloudsDescription.Text = Measurement.CloudsName;
                lblMinimumTemperature.Text = string.Format("{0}{1}", Measurement.TemperatureMin, Measurement.TemperatureUnit);
                lblMaximumTemperature.Text = string.Format("{0}{1}", Measurement.TemperatureMax, Measurement.TemperatureUnit);
            }
        }
    }
}
