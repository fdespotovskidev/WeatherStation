namespace WeatherStation
{
    partial class WeatherView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMinimumTemperature = new System.Windows.Forms.Label();
            this.lblMaximumTemperature = new System.Windows.Forms.Label();
            this.lblCloudsDescription = new System.Windows.Forms.Label();
            this.lblCurrentTemperature = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(3, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblMinimumTemperature
            // 
            this.lblMinimumTemperature.AutoSize = true;
            this.lblMinimumTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMinimumTemperature.ForeColor = System.Drawing.Color.Navy;
            this.lblMinimumTemperature.Location = new System.Drawing.Point(247, 64);
            this.lblMinimumTemperature.Name = "lblMinimumTemperature";
            this.lblMinimumTemperature.Size = new System.Drawing.Size(32, 20);
            this.lblMinimumTemperature.TabIndex = 2;
            this.lblMinimumTemperature.Text = "19°";
            // 
            // lblMaximumTemperature
            // 
            this.lblMaximumTemperature.AutoSize = true;
            this.lblMaximumTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaximumTemperature.Location = new System.Drawing.Point(247, 29);
            this.lblMaximumTemperature.Name = "lblMaximumTemperature";
            this.lblMaximumTemperature.Size = new System.Drawing.Size(32, 20);
            this.lblMaximumTemperature.TabIndex = 3;
            this.lblMaximumTemperature.Text = "23°";
            // 
            // lblCloudsDescription
            // 
            this.lblCloudsDescription.AutoSize = true;
            this.lblCloudsDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCloudsDescription.Location = new System.Drawing.Point(132, 9);
            this.lblCloudsDescription.Name = "lblCloudsDescription";
            this.lblCloudsDescription.Size = new System.Drawing.Size(50, 16);
            this.lblCloudsDescription.TabIndex = 4;
            this.lblCloudsDescription.Text = "Cloudy";
            // 
            // lblCurrentTemperature
            // 
            this.lblCurrentTemperature.AutoSize = true;
            this.lblCurrentTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentTemperature.Location = new System.Drawing.Point(129, 38);
            this.lblCurrentTemperature.Name = "lblCurrentTemperature";
            this.lblCurrentTemperature.Size = new System.Drawing.Size(59, 33);
            this.lblCurrentTemperature.TabIndex = 5;
            this.lblCurrentTemperature.Text = "23°";
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(7, 29);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(100, 55);
            this.picWeatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeatherIcon.TabIndex = 1;
            this.picWeatherIcon.TabStop = false;
            // 
            // WeatherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrentTemperature);
            this.Controls.Add(this.lblCloudsDescription);
            this.Controls.Add(this.lblMaximumTemperature);
            this.Controls.Add(this.lblMinimumTemperature);
            this.Controls.Add(this.picWeatherIcon);
            this.Controls.Add(this.lblDate);
            this.Name = "WeatherView";
            this.Size = new System.Drawing.Size(300, 90);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox picWeatherIcon;
        private System.Windows.Forms.Label lblMinimumTemperature;
        private System.Windows.Forms.Label lblMaximumTemperature;
        private System.Windows.Forms.Label lblCloudsDescription;
        private System.Windows.Forms.Label lblCurrentTemperature;
    }
}
