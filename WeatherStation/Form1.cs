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
        private bool ConstructorCheckedChanged;
        private WeatherMap CurrentWeather;
        // Needed for animations
        private Color currentBackgroundColor;
        private Color targetBackgroundColor;
        private ColorIncrement backgroundColorIncrement;
        private Image weatherIcon;
        private Point targetIconPosition;
        private PointF iconPositionIncrement;
        private PointF iconPosition;
        private int totalSteps = 0;
        private int currentSteps = 0;
        private short CheckedCounter;

        private bool AutoUpdateEnabled;
        private bool UpdateOnStartup;
        private string OldCity;
        private bool UsedOldCity;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ConstructorCheckedChanged = true;
            pnlFiveDayWeather.BackColor = Color.FromArgb(50, Color.DarkGray);
            menuStrip1.BackColor = Color.FromArgb(50, Color.DarkGray);
            btnUpdateWeather.BackColor = Color.FromArgb(50, Color.DarkGray);
            btnUpdateWeather.FlatAppearance.MouseOverBackColor = Color.FromArgb(90, Color.DarkGray);
            btnUpdateWeather.FlatAppearance.MouseDownBackColor = Color.FromArgb(70, Color.DarkGray);
            btnUpdateWeather.FlatAppearance.BorderColor = Color.FromArgb(0, Color.White);
            CheckedCounter = 0;
            targetIconPosition = picWeatherIcon.Location;

            CurrentWeather = new WeatherMap();
            pnlFiveDayWeather.AutoScroll = true;
            pnlFiveDayWeather.WrapContents = false;
            pnlFiveDayWeather.FlowDirection = FlowDirection.TopDown;
            AutoUpdateTimer.Interval = 60000 * 10;

            if (!LoadAutoUpdateSettings())
            {
                AutoUpdateEnabled = false;
                AutoUpdateTimer.Enabled = false;
                UpdateOnStartup = false;
            }

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

                if (AutoUpdateEnabled && UpdateOnStartup)
                {
                    UpdateWeather();
                }
                else
                {
                    UpdateView();
                }
                
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
            ConstructorCheckedChanged = false;
            OldCity = null;
            UsedOldCity = false;
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
                return Color.Lime;
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
            lblWindName.Text = string.Format("{0}, {1}", CurrentWeather.Measurement.WindName, CurrentWeather.Measurement.WindDirection);
            lblWindSpeed.Text = string.Format("{0:00.0} {1}", CurrentWeather.Measurement.WindSpeed, CurrentWeather.Units.ToLower() == "metric" ? "m/s" : "mph");
            lblClouds.Text = string.Format("{0}, {1}%", CurrentWeather.Measurement.CloudsName, CurrentWeather.Measurement.CloudsValue);
            lblLastUpdated.Text = string.Format("{0}, {1}", CurrentWeather.Measurement.LastUpdate.ToShortDateString(), CurrentWeather.Measurement.LastUpdate.ToLocalTime().ToShortTimeString());
            
            if (CurrentWeather.Measurement.WeatherValue.ToLower().Contains("cloud"))
            {
                weatherIcon = Resources.clouds_256x256;
                targetBackgroundColor = Color.SlateGray;
            }
            else if (CurrentWeather.Measurement.WeatherValue.ToLower().Contains("clear"))
            {
                weatherIcon = Resources.sun_256x256;
                targetBackgroundColor = Color.SkyBlue;
            }
            else if (CurrentWeather.Measurement.WeatherValue.ToLower().Contains("storm"))
            {
                weatherIcon = Resources.storm_256x256;
                targetBackgroundColor = Color.SteelBlue;
            }
            else if (CurrentWeather.Measurement.WeatherValue.ToLower().Contains("snow"))
            {
                weatherIcon = Resources.snow_256x256;
                targetBackgroundColor = Color.AliceBlue;
            }
            else if (CurrentWeather.Measurement.WeatherValue.ToLower().Contains("rain") || CurrentWeather.Measurement.WeatherValue.ToLower().Contains("drizzle"))
            {
                weatherIcon = Resources.rain_256x256;
                targetBackgroundColor = Color.Lavender;
            }
            else if (CurrentWeather.Measurement.WeatherValue.ToLower().Contains("mist") || CurrentWeather.Measurement.WeatherValue.ToLower().Contains("haze"))
            {
                weatherIcon = Resources.mist_256x256;
                targetBackgroundColor = Color.LightGray;
            }

            pnlFiveDayWeather.Controls.Clear();
            foreach(ShortWeatherMeasurement swm in CurrentWeather.FiveDayMeasurements)
            {
                pnlFiveDayWeather.Controls.Add(new WeatherView(swm));
            }
            Animate();
        }
        private void UpdateWeather()
        {
            if (CurrentWeather.UpdateMeasurement())
            {
                UpdateView();
                if(UsedOldCity)
                {
                    tbEnterCity.Clear();
                }
            }
            else
            {
                MessageBox.Show("Error! Something went wrong!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (UsedOldCity)
                {
                    CurrentWeather.City = OldCity;
                }
            }
            if(UsedOldCity)
            {
                OldCity = null;
                UsedOldCity = false;
            }
        }

        private void btnUpdateWeather_Click(object sender, EventArgs e)
        {
            if (tbEnterCity.Text.Trim().Length > 0)
            {
                OldCity = CurrentWeather.City;
                CurrentWeather.City = tbEnterCity.Text;
                UsedOldCity = true;
            }
            UpdateWeather();
        }

        private void rbUnits_CheckedChanged(object sender, EventArgs e)
        {
            if (!ConstructorCheckedChanged)
            {
                CheckedCounter++;
            }
            
            if (rbMetric.Checked == true)
            {
                CurrentWeather.Units = "metric";
            }
            else
            {
                CurrentWeather.Units = "imperial";
            }
            if (!ConstructorCheckedChanged && CheckedCounter == 1)
            {
                UpdateWeather();
            }
            else if (!ConstructorCheckedChanged && CheckedCounter == 2)
            {
                CheckedCounter = 0;
            }
        }

        private void Animate()
        {
            currentBackgroundColor = this.BackColor;
            totalSteps = 1000 / transitionTimer.Interval;
            currentSteps = 0;
            backgroundColorIncrement = new ColorIncrement((targetBackgroundColor.R - currentBackgroundColor.R) / totalSteps,
                (targetBackgroundColor.G - currentBackgroundColor.G) / totalSteps, 
                (targetBackgroundColor.B - currentBackgroundColor.B) / totalSteps);
            
            iconPositionIncrement = new PointF(50.0f / totalSteps, 0f);
            picWeatherIcon.Image = null;
            picWeatherIcon.Location = new Point(targetIconPosition.X - 50, targetIconPosition.Y);
            iconPosition = new PointF(picWeatherIcon.Location.X, picWeatherIcon.Location.Y);
            transitionTimer.Start();
        }

        private void transitionTimer_Tick(object sender, EventArgs e)
        {
            if(currentSteps == totalSteps)
            {
                this.BackColor = targetBackgroundColor;
                this.picWeatherIcon.Image = Utilities.ChangeImageOpacity(weatherIcon, 1);
                this.picWeatherIcon.Location = targetIconPosition;
                weatherIcon.Dispose();
                transitionTimer.Stop();
            }
            else
            {
                // Update background color
                currentBackgroundColor = Color.FromArgb(currentBackgroundColor.R + backgroundColorIncrement.R,
                    currentBackgroundColor.G + backgroundColorIncrement.G,
                    currentBackgroundColor.B + backgroundColorIncrement.B);
                this.BackColor = currentBackgroundColor;
                // Update weather icon
                iconPosition = new PointF(iconPosition.X + iconPositionIncrement.X,
                    iconPosition.Y + iconPositionIncrement.Y);
                picWeatherIcon.Location = new Point((int)iconPosition.X, (int)iconPosition.Y);
                picWeatherIcon.Image = Utilities.ChangeImageOpacity(weatherIcon, currentSteps / (float)totalSteps);
                currentSteps++;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void autoUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutoUpdate au = new AutoUpdate();
            au.UpdateControls(AutoUpdateEnabled, AutoUpdateTimer.Interval / 60000, UpdateOnStartup);
            if(au.ShowDialog() == DialogResult.OK)
            {
                AutoUpdateEnabled = au.AutoUpdateEnabled;
                UpdateOnStartup = au.UpdateOnStartup;
                if (AutoUpdateEnabled)
                {
                    AutoUpdateTimer.Interval = 60000 * au.UpdateInterval;
                    if (!AutoUpdateTimer.Enabled)
                    {
                        AutoUpdateTimer.Enabled = true;
                    }
                    
                }
                else
                {
                    AutoUpdateTimer.Interval = 60000 * 10;
                    if (AutoUpdateTimer.Enabled)
                    {
                        AutoUpdateTimer.Enabled = false;
                    }
                }
                SaveAutoUpdateSettings();
            }
            
        }

        private void AutoUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateWeather();
        }

        private void SaveAutoUpdateSettings()
        {
            System.Runtime.Serialization.IFormatter ift = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

            using (FileStream fs = new FileStream("WeatherStationSettings.ws", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                ift.Serialize(fs, AutoUpdateEnabled);
                ift.Serialize(fs, AutoUpdateTimer.Interval);
                ift.Serialize(fs, AutoUpdateTimer.Enabled);
                ift.Serialize(fs, UpdateOnStartup);
            }
        }

        private bool LoadAutoUpdateSettings()
        {
            try
            {
                System.Runtime.Serialization.IFormatter ift = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                using (FileStream fs = new FileStream("WeatherStationSettings.ws", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    AutoUpdateEnabled = (bool)ift.Deserialize(fs);
                    AutoUpdateTimer.Interval = (int)ift.Deserialize(fs);
                    AutoUpdateTimer.Enabled = (bool)ift.Deserialize(fs);
                    UpdateOnStartup = (bool)ift.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        private void tbEnterCity_TextChanged(object sender, EventArgs e)
        {
            btnUpdateWeather.Text = (tbEnterCity.Text.Trim().Length == 0 && CurrentWeather.City != null) ? "Update Weather" : "Get Weather";
        }
    }
}
