namespace WeatherStation
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLinkedInA = new System.Windows.Forms.Button();
            this.btnLinkedInF = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSourceCode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(396, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 32);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "WeatherStation 1.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filip Despotovski";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Aleksandar Despotovski";
            // 
            // btnLinkedInA
            // 
            this.btnLinkedInA.BackgroundImage = global::WeatherStation.Properties.Resources.linkedin_128x128;
            this.btnLinkedInA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLinkedInA.Location = new System.Drawing.Point(288, 81);
            this.btnLinkedInA.Name = "btnLinkedInA";
            this.btnLinkedInA.Size = new System.Drawing.Size(48, 48);
            this.btnLinkedInA.TabIndex = 6;
            this.btnLinkedInA.UseVisualStyleBackColor = true;
            this.btnLinkedInA.Click += new System.EventHandler(this.btnLinkedInA_Click);
            // 
            // btnLinkedInF
            // 
            this.btnLinkedInF.BackgroundImage = global::WeatherStation.Properties.Resources.linkedin_128x128;
            this.btnLinkedInF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLinkedInF.Location = new System.Drawing.Point(288, 19);
            this.btnLinkedInF.Name = "btnLinkedInF";
            this.btnLinkedInF.Size = new System.Drawing.Size(48, 48);
            this.btnLinkedInF.TabIndex = 5;
            this.btnLinkedInF.UseVisualStyleBackColor = true;
            this.btnLinkedInF.Click += new System.EventHandler(this.btnLinkedInF_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Project Source Code:";
            // 
            // btnSourceCode
            // 
            this.btnSourceCode.BackgroundImage = global::WeatherStation.Properties.Resources.github_128x128;
            this.btnSourceCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSourceCode.Location = new System.Drawing.Point(300, 215);
            this.btnSourceCode.Name = "btnSourceCode";
            this.btnSourceCode.Size = new System.Drawing.Size(48, 48);
            this.btnSourceCode.TabIndex = 8;
            this.btnSourceCode.UseVisualStyleBackColor = true;
            this.btnSourceCode.Click += new System.EventHandler(this.btnSourceCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLinkedInF);
            this.groupBox1.Controls.Add(this.btnLinkedInA);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 144);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Developers";
            // 
            // AboutForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::WeatherStation.Properties.Resources.weather_station_512x512;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(484, 271);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSourceCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "About WeatherStation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLinkedInF;
        private System.Windows.Forms.Button btnLinkedInA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSourceCode;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}