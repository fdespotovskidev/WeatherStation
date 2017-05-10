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
            this.label3 = new System.Windows.Forms.Label();
            this.lblSunSet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            this.tbEnterCity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbFiveDay = new System.Windows.Forms.ListBox();
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
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "City:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(45, 26);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 13);
            this.lblCity.TabIndex = 3;
            // 
            // lblSunRise
            // 
            this.lblSunRise.AutoSize = true;
            this.lblSunRise.Location = new System.Drawing.Point(66, 49);
            this.lblSunRise.Name = "lblSunRise";
            this.lblSunRise.Size = new System.Drawing.Size(0, 13);
            this.lblSunRise.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sun rise:";
            // 
            // lblSunSet
            // 
            this.lblSunSet.AutoSize = true;
            this.lblSunSet.Location = new System.Drawing.Point(66, 74);
            this.lblSunSet.Name = "lblSunSet";
            this.lblSunSet.Size = new System.Drawing.Size(0, 13);
            this.lblSunSet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sun set:";
            // 
            // lblCurrentTemperature
            // 
            this.lblCurrentTemperature.AutoSize = true;
            this.lblCurrentTemperature.Location = new System.Drawing.Point(88, 119);
            this.lblCurrentTemperature.Name = "lblCurrentTemperature";
            this.lblCurrentTemperature.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentTemperature.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Temperature:";
            // 
            // lblMinTemperature
            // 
            this.lblMinTemperature.AutoSize = true;
            this.lblMinTemperature.Location = new System.Drawing.Point(107, 143);
            this.lblMinTemperature.Name = "lblMinTemperature";
            this.lblMinTemperature.Size = new System.Drawing.Size(0, 13);
            this.lblMinTemperature.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Temperature min:";
            // 
            // lblMaxTemperature
            // 
            this.lblMaxTemperature.AutoSize = true;
            this.lblMaxTemperature.Location = new System.Drawing.Point(107, 170);
            this.lblMaxTemperature.Name = "lblMaxTemperature";
            this.lblMaxTemperature.Size = new System.Drawing.Size(0, 13);
            this.lblMaxTemperature.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Temperature max:";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(68, 194);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(0, 13);
            this.lblHumidity.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Humidity:";
            // 
            // lblPressure
            // 
            this.lblPressure.AutoSize = true;
            this.lblPressure.Location = new System.Drawing.Point(69, 217);
            this.lblPressure.Name = "lblPressure";
            this.lblPressure.Size = new System.Drawing.Size(0, 13);
            this.lblPressure.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Pressure:";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(53, 240);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(0, 13);
            this.lblWind.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Wind:";
            // 
            // lblClouds
            // 
            this.lblClouds.AutoSize = true;
            this.lblClouds.Location = new System.Drawing.Point(60, 262);
            this.lblClouds.Name = "lblClouds";
            this.lblClouds.Size = new System.Drawing.Size(0, 13);
            this.lblClouds.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Clouds:";
            // 
            // lblWeatherValue
            // 
            this.lblWeatherValue.AutoSize = true;
            this.lblWeatherValue.Location = new System.Drawing.Point(69, 97);
            this.lblWeatherValue.Name = "lblWeatherValue";
            this.lblWeatherValue.Size = new System.Drawing.Size(0, 13);
            this.lblWeatherValue.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Weather:";
            // 
            // lblLastUpdated
            // 
            this.lblLastUpdated.AutoSize = true;
            this.lblLastUpdated.Location = new System.Drawing.Point(88, 285);
            this.lblLastUpdated.Name = "lblLastUpdated";
            this.lblLastUpdated.Size = new System.Drawing.Size(0, 13);
            this.lblLastUpdated.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 285);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Last updated:";
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
            // lbFiveDay
            // 
            this.lbFiveDay.FormattingEnabled = true;
            this.lbFiveDay.Location = new System.Drawing.Point(578, 12);
            this.lbFiveDay.Name = "lbFiveDay";
            this.lbFiveDay.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbFiveDay.Size = new System.Drawing.Size(594, 316);
            this.lbFiveDay.TabIndex = 30;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnUpdateWeather;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 361);
            this.Controls.Add(this.lbFiveDay);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEnterCity);
            this.Controls.Add(this.lblLastUpdated);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSunRise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateWeather);
            this.Name = "Form1";
            this.Text = "Weather Station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdateWeather;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSunRise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSunSet;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbEnterCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbFiveDay;
    }
}

