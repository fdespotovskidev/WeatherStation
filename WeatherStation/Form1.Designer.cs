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
            this.btnUpdateWeather = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSunRise = new System.Windows.Forms.Label();
            this.lblSunSet = new System.Windows.Forms.Label();
            this.lblCurrentTemperature = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinTemperature = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaxTemperature = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPressure = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblClouds = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblWeatherValue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblLastUpdated = new System.Windows.Forms.Label();
            this.tbEnterCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlFiveDayWeather = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbHumidity = new System.Windows.Forms.PictureBox();
            this.pbTempMax = new System.Windows.Forms.PictureBox();
            this.pbTempMin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMin)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "City:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(12, 9);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(164, 39);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "cityName";
            // 
            // lblSunRise
            // 
            this.lblSunRise.AutoSize = true;
            this.lblSunRise.Location = new System.Drawing.Point(63, 243);
            this.lblSunRise.Name = "lblSunRise";
            this.lblSunRise.Size = new System.Drawing.Size(91, 13);
            this.lblSunRise.TabIndex = 5;
            this.lblSunRise.Text = "sunRiseDateTime";
            // 
            // lblSunSet
            // 
            this.lblSunSet.AutoSize = true;
            this.lblSunSet.Location = new System.Drawing.Point(63, 268);
            this.lblSunSet.Name = "lblSunSet";
            this.lblSunSet.Size = new System.Drawing.Size(86, 13);
            this.lblSunSet.TabIndex = 7;
            this.lblSunSet.Text = "sunSetDateTime";
            // 
            // lblCurrentTemperature
            // 
            this.lblCurrentTemperature.AutoSize = true;
            this.lblCurrentTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentTemperature.Location = new System.Drawing.Point(12, 122);
            this.lblCurrentTemperature.Name = "lblCurrentTemperature";
            this.lblCurrentTemperature.Size = new System.Drawing.Size(104, 55);
            this.lblCurrentTemperature.TabIndex = 9;
            this.lblCurrentTemperature.Text = "-- C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Temperature:";
            // 
            // lblMinTemperature
            // 
            this.lblMinTemperature.AutoSize = true;
            this.lblMinTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinTemperature.Location = new System.Drawing.Point(49, 177);
            this.lblMinTemperature.Name = "lblMinTemperature";
            this.lblMinTemperature.Size = new System.Drawing.Size(34, 20);
            this.lblMinTemperature.TabIndex = 11;
            this.lblMinTemperature.Text = "-- C";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Temperature min:";
            // 
            // lblMaxTemperature
            // 
            this.lblMaxTemperature.AutoSize = true;
            this.lblMaxTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxTemperature.Location = new System.Drawing.Point(153, 177);
            this.lblMaxTemperature.Name = "lblMaxTemperature";
            this.lblMaxTemperature.Size = new System.Drawing.Size(34, 20);
            this.lblMaxTemperature.TabIndex = 13;
            this.lblMaxTemperature.Text = "-- C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Temperature max:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHumidity.Location = new System.Drawing.Point(258, 177);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(37, 20);
            this.lblHumidity.TabIndex = 15;
            this.lblHumidity.Text = "-- %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Humidity:";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPressure.Location = new System.Drawing.Point(251, 284);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(70, 25);
            this.lblPressure.TabIndex = 17;
            this.lblPressure.Text = "-- hPa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(201, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pressure:";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWind.Location = new System.Drawing.Point(243, 259);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(78, 25);
            this.lblWind.TabIndex = 19;
            this.lblWind.Text = "-- km/h";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 268);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Wind:";
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
            this.lblWeatherValue.Location = new System.Drawing.Point(15, 90);
            this.lblWeatherValue.Name = "lblWeatherValue";
            this.lblWeatherValue.Size = new System.Drawing.Size(103, 20);
            this.lblWeatherValue.TabIndex = 23;
            this.lblWeatherValue.Text = "weatherDesc";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(326, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Weather:";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLastUpdated.Location = new System.Drawing.Point(15, 58);
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
            this.pnlFiveDayWeather.Location = new System.Drawing.Point(578, 12);
            this.pnlFiveDayWeather.Name = "pnlFiveDayWeather";
            this.pnlFiveDayWeather.Size = new System.Drawing.Size(594, 316);
            this.pnlFiveDayWeather.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeatherStation.Properties.Resources.temperature_128x128;
            this.pictureBox1.Location = new System.Drawing.Point(189, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pbHumidity
            // 
            this.pbHumidity.Image = global::WeatherStation.Properties.Resources.drop_48x48;
            this.pbHumidity.Location = new System.Drawing.Point(228, 173);
            this.pbHumidity.Name = "pbHumidity";
            this.pbHumidity.Size = new System.Drawing.Size(24, 24);
            this.pbHumidity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHumidity.TabIndex = 33;
            this.pbHumidity.TabStop = false;
            // 
            // pbTempMax
            // 
            this.pbTempMax.Image = global::WeatherStation.Properties.Resources.arrow_up_48x48;
            this.pbTempMax.Location = new System.Drawing.Point(122, 173);
            this.pbTempMax.Name = "pbTempMax";
            this.pbTempMax.Size = new System.Drawing.Size(24, 24);
            this.pbTempMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTempMax.TabIndex = 32;
            this.pbTempMax.TabStop = false;
            // 
            // pbTempMin
            // 
            this.pbTempMin.Image = global::WeatherStation.Properties.Resources.arrow_down_48x48;
            this.pbTempMin.Location = new System.Drawing.Point(19, 173);
            this.pbTempMin.Name = "pbTempMin";
            this.pbTempMin.Size = new System.Drawing.Size(24, 24);
            this.pbTempMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTempMin.TabIndex = 31;
            this.pbTempMin.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUpdateWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 361);
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
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblClouds);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPressure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMaxTemperature);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMinTemperature);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCurrentTemperature);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblSunSet);
            this.Controls.Add(this.lblSunRise);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateWeather);
            this.Name = "Form1";
            this.Text = "Weather Station";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTempMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSunRise;
        private System.Windows.Forms.Label lblSunSet;
        private System.Windows.Forms.Label lblCurrentTemperature;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinTemperature;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaxTemperature;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPressure;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblClouds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblWeatherValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblLastUpdated;
        private System.Windows.Forms.TextBox tbEnterCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbTempMin;
        private System.Windows.Forms.PictureBox pbTempMax;
        private System.Windows.Forms.PictureBox pbHumidity;
        private System.Windows.Forms.FlowLayoutPanel pnlFiveDayWeather;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

