namespace WeatherStation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpdateWeather = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSunRise = new System.Windows.Forms.Label();
            this.lblSunSet = new System.Windows.Forms.Label();
            this.lblCurrentTemperature = new System.Windows.Forms.Label();
            this.lblMinTemperature = new System.Windows.Forms.Label();
            this.lblMaxTemperature = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblWindName = new System.Windows.Forms.Label();
            this.lblClouds = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblWeatherValue = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.tbEnterCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlFiveDayWeather = new System.Windows.Forms.FlowLayoutPanel();
            this.gbUnits = new System.Windows.Forms.GroupBox();
            this.rbMetric = new System.Windows.Forms.RadioButton();
            this.rbImperial = new System.Windows.Forms.RadioButton();
            this.gbWindPressure = new System.Windows.Forms.GroupBox();
            this.pbWind = new System.Windows.Forms.PictureBox();
            this.pbSunset = new System.Windows.Forms.PictureBox();
            this.pbSunrise = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbHumidity = new System.Windows.Forms.PictureBox();
            this.pbTempMax = new System.Windows.Forms.PictureBox();
            this.pbTempMin = new System.Windows.Forms.PictureBox();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            this.gbUnits.SuspendLayout();
            this.gbWindPressure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSunset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSunrise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateWeather
            // 
            this.btnUpdateWeather.Location = new System.Drawing.Point(12, 326);
            this.btnUpdateWeather.Name = "btnUpdateWeather";
            this.btnUpdateWeather.Size = new System.Drawing.Size(560, 23);
            this.btnUpdateWeather.TabIndex = 1;
            this.btnUpdateWeather.Text = "Update Weather";
            this.btnUpdateWeather.UseVisualStyleBackColor = true;
            this.btnUpdateWeather.Click += new System.EventHandler(this.btnUpdateWeather_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(18, 15);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(164, 39);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "cityName";
            // 
            // lblSunRise
            // 
            this.lblSunRise.AutoSize = true;
            this.lblSunRise.Location = new System.Drawing.Point(55, 250);
            this.lblSunRise.Name = "lblSunRise";
            this.lblSunRise.Size = new System.Drawing.Size(91, 13);
            this.lblSunRise.TabIndex = 5;
            this.lblSunRise.Text = "sunRiseDateTime";
            // 
            // lblSunSet
            // 
            this.lblSunSet.AutoSize = true;
            this.lblSunSet.Location = new System.Drawing.Point(55, 283);
            this.lblSunSet.Name = "lblSunSet";
            this.lblSunSet.Size = new System.Drawing.Size(86, 13);
            this.lblSunSet.TabIndex = 7;
            this.lblSunSet.Text = "sunSetDateTime";
            // 
            // lblCurrentTemperature
            // 
            this.lblCurrentTemperature.AutoSize = true;
            this.lblCurrentTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentTemperature.Location = new System.Drawing.Point(371, 19);
            this.lblCurrentTemperature.Name = "lblCurrentTemperature";
            this.lblCurrentTemperature.Size = new System.Drawing.Size(104, 55);
            this.lblCurrentTemperature.TabIndex = 9;
            this.lblCurrentTemperature.Text = "-- C";
            // 
            // lblMinTemperature
            // 
            this.lblMinTemperature.AutoSize = true;
            this.lblMinTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinTemperature.Location = new System.Drawing.Point(567, 54);
            this.lblMinTemperature.Name = "lblMinTemperature";
            this.lblMinTemperature.Size = new System.Drawing.Size(34, 20);
            this.lblMinTemperature.TabIndex = 11;
            this.lblMinTemperature.Text = "-- C";
            // 
            // lblMaxTemperature
            // 
            this.lblMaxTemperature.AutoSize = true;
            this.lblMaxTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxTemperature.Location = new System.Drawing.Point(567, 24);
            this.lblMaxTemperature.Name = "lblMaxTemperature";
            this.lblMaxTemperature.Size = new System.Drawing.Size(34, 20);
            this.lblMaxTemperature.TabIndex = 13;
            this.lblMaxTemperature.Text = "-- C";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHumidity.Location = new System.Drawing.Point(567, 84);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(37, 20);
            this.lblHumidity.TabIndex = 15;
            this.lblHumidity.Text = "-- %";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPressure.Location = new System.Drawing.Point(122, 57);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(43, 16);
            this.lblPressure.TabIndex = 17;
            this.lblPressure.Text = "-- hPa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pressure:";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWindSpeed.Location = new System.Drawing.Point(411, 84);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(48, 20);
            this.lblWindSpeed.TabIndex = 19;
            this.lblWindSpeed.Text = "-- m/s";
            // 
            // lblWindName
            // 
            this.lblWindName.AutoSize = true;
            this.lblWindName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWindName.Location = new System.Drawing.Point(6, 19);
            this.lblWindName.Name = "lblWindName";
            this.lblWindName.Size = new System.Drawing.Size(42, 16);
            this.lblWindName.TabIndex = 18;
            this.lblWindName.Text = "Wind:";
            // 
            // lblClouds
            // 
            this.lblClouds.AutoSize = true;
            this.lblClouds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClouds.Location = new System.Drawing.Point(67, 210);
            this.lblClouds.Name = "lblClouds";
            this.lblClouds.Size = new System.Drawing.Size(92, 20);
            this.lblClouds.TabIndex = 21;
            this.lblClouds.Text = "cloudsDesc";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Clouds:";
            // 
            // lblWeatherValue
            // 
            this.lblWeatherValue.AutoSize = true;
            this.lblWeatherValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWeatherValue.Location = new System.Drawing.Point(191, 182);
            this.lblWeatherValue.Name = "lblWeatherValue";
            this.lblWeatherValue.Size = new System.Drawing.Size(103, 20);
            this.lblWeatherValue.TabIndex = 23;
            this.lblWeatherValue.Text = "weatherDesc";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastUpdated.Location = new System.Drawing.Point(21, 63);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(165, 20);
            this.lblLastUpdated.TabIndex = 25;
            this.lblLastUpdated.Text = "lastUpdatedDateTime";
            // 
            // tbEnterCity
            // 
            this.tbEnterCity.Location = new System.Drawing.Point(432, 300);
            this.tbEnterCity.Name = "tbEnterCity";
            this.tbEnterCity.Size = new System.Drawing.Size(140, 20);
            this.tbEnterCity.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Enter city:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(679, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "5 Day Forecast";
            // 
            // pnlFiveDayWeather
            // 
            this.pnlFiveDayWeather.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiveDayWeather.BackColor = System.Drawing.Color.White;
            this.pnlFiveDayWeather.Location = new System.Drawing.Point(676, 12);
            this.pnlFiveDayWeather.Name = "pnlFiveDayWeather";
            this.pnlFiveDayWeather.Size = new System.Drawing.Size(496, 316);
            this.pnlFiveDayWeather.TabIndex = 34;
            // 
            // gbUnits
            // 
            this.gbUnits.Controls.Add(this.rbMetric);
            this.gbUnits.Controls.Add(this.rbImperial);
            this.gbUnits.Location = new System.Drawing.Point(576, 278);
            this.gbUnits.Name = "gbUnits";
            this.gbUnits.Size = new System.Drawing.Size(94, 71);
            this.gbUnits.TabIndex = 39;
            this.gbUnits.TabStop = false;
            this.gbUnits.Text = "Units";
            // 
            // rbMetric
            // 
            this.rbMetric.AutoSize = true;
            this.rbMetric.Checked = true;
            this.rbMetric.Location = new System.Drawing.Point(6, 42);
            this.rbMetric.Name = "rbMetric";
            this.rbMetric.Size = new System.Drawing.Size(54, 17);
            this.rbMetric.TabIndex = 1;
            this.rbMetric.TabStop = true;
            this.rbMetric.Text = "Metric";
            this.rbMetric.UseVisualStyleBackColor = true;
            this.rbMetric.CheckedChanged += new System.EventHandler(this.rbUnits_CheckedChanged);
            // 
            // rbImperial
            // 
            this.rbImperial.AutoSize = true;
            this.rbImperial.Location = new System.Drawing.Point(6, 19);
            this.rbImperial.Name = "rbImperial";
            this.rbImperial.Size = new System.Drawing.Size(61, 17);
            this.rbImperial.TabIndex = 0;
            this.rbImperial.Text = "Imperial";
            this.rbImperial.UseVisualStyleBackColor = true;
            this.rbImperial.CheckedChanged += new System.EventHandler(this.rbUnits_CheckedChanged);
            // 
            // gbWindPressure
            // 
            this.gbWindPressure.Controls.Add(this.lblWindName);
            this.gbWindPressure.Controls.Add(this.lblPressure);
            this.gbWindPressure.Controls.Add(this.label9);
            this.gbWindPressure.Location = new System.Drawing.Point(204, 215);
            this.gbWindPressure.Name = "gbWindPressure";
            this.gbWindPressure.Size = new System.Drawing.Size(368, 85);
            this.gbWindPressure.TabIndex = 36;
            this.gbWindPressure.TabStop = false;
            this.gbWindPressure.Text = "Wind and Pressure";
            // 
            // pbWind
            // 
            this.pbWind.Image = global::WeatherStation.Properties.Resources.wind_48x48;
            this.pbWind.Location = new System.Drawing.Point(381, 80);
            this.pbWind.Name = "pbWind";
            this.pbWind.Size = new System.Drawing.Size(24, 24);
            this.pbWind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWind.TabIndex = 41;
            this.pbWind.TabStop = false;
            // 
            // pbSunset
            // 
            this.pbSunset.Image = global::WeatherStation.Properties.Resources.sunset_48x48;
            this.pbSunset.Location = new System.Drawing.Point(19, 276);
            this.pbSunset.Name = "pbSunset";
            this.pbSunset.Size = new System.Drawing.Size(24, 24);
            this.pbSunset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSunset.TabIndex = 38;
            this.pbSunset.TabStop = false;
            // 
            // pbSunrise
            // 
            this.pbSunrise.Image = global::WeatherStation.Properties.Resources.sunrise_48x48;
            this.pbSunrise.Location = new System.Drawing.Point(19, 243);
            this.pbSunrise.Name = "pbSunrise";
            this.pbSunrise.Size = new System.Drawing.Size(24, 24);
            this.pbSunrise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSunrise.TabIndex = 37;
            this.pbSunrise.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherStation.Properties.Resources.temperature_128x128;
            this.pictureBox1.Location = new System.Drawing.Point(25, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pbHumidity
            // 
            this.pbHumidity.Image = global::WeatherStation.Properties.Resources.drop_48x48;
            this.pbHumidity.Location = new System.Drawing.Point(537, 80);
            this.pbHumidity.Name = "pbHumidity";
            this.pbHumidity.Size = new System.Drawing.Size(24, 24);
            this.pbHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHumidity.TabIndex = 33;
            this.pbHumidity.TabStop = false;
            // 
            // pbTempMax
            // 
            this.pbTempMax.Image = global::WeatherStation.Properties.Resources.arrow_up_48x48;
            this.pbTempMax.Location = new System.Drawing.Point(537, 20);
            this.pbTempMax.Name = "pbTempMax";
            this.pbTempMax.Size = new System.Drawing.Size(24, 24);
            this.pbTempMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTempMax.TabIndex = 32;
            this.pbTempMax.TabStop = false;
            // 
            // pbTempMin
            // 
            this.pbTempMin.Image = global::WeatherStation.Properties.Resources.arrow_down_48x48;
            this.pbTempMin.Location = new System.Drawing.Point(537, 50);
            this.pbTempMin.Name = "pbTempMin";
            this.pbTempMin.Size = new System.Drawing.Size(24, 24);
            this.pbTempMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTempMin.TabIndex = 31;
            this.pbTempMin.TabStop = false;
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(195, 15);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(164, 164);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 40;
            this.picWeatherIcon.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUpdateWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.gbUnits);
            this.Controls.Add(this.pbWind);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.pbSunset);
            this.Controls.Add(this.pbSunrise);
            this.Controls.Add(this.gbWindPressure);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlFiveDayWeather);
            this.Controls.Add(this.pbHumidity);
            this.Controls.Add(this.pbTempMax);
            this.Controls.Add(this.pbTempMin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEnterCity);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.lblWeatherValue);
            this.Controls.Add(this.lblClouds);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblMaxTemperature);
            this.Controls.Add(this.lblMinTemperature);
            this.Controls.Add(this.lblCurrentTemperature);
            this.Controls.Add(this.lblSunSet);
            this.Controls.Add(this.lblSunRise);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnUpdateWeather);
            this.Controls.Add(this.picWeatherIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Weather Station";
            this.gbUnits.ResumeLayout(false);
            this.gbUnits.PerformLayout();
            this.gbWindPressure.ResumeLayout(false);
            this.gbWindPressure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSunset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSunrise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateWeather;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSunRise;
        private System.Windows.Forms.Label lblSunSet;
        private System.Windows.Forms.Label lblCurrentTemperature;
        private System.Windows.Forms.Label lblMinTemperature;
        private System.Windows.Forms.Label lblMaxTemperature;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblWindName;
        private System.Windows.Forms.Label lblClouds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblWeatherValue;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.TextBox tbEnterCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbTempMin;
        private System.Windows.Forms.PictureBox pbTempMax;
        private System.Windows.Forms.PictureBox pbHumidity;
        private System.Windows.Forms.FlowLayoutPanel pnlFiveDayWeather;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbWindPressure;
        private System.Windows.Forms.PictureBox pbSunrise;
        private System.Windows.Forms.PictureBox pbSunset;
        private System.Windows.Forms.GroupBox gbUnits;
        private System.Windows.Forms.RadioButton rbMetric;
        private System.Windows.Forms.RadioButton rbImperial;
        private System.Windows.Forms.PictureBox picWeatherIcon;
        private System.Windows.Forms.PictureBox pbWind;
    }
}

