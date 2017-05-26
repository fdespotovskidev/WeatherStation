namespace WeatherStation
{
    partial class AutoUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoUpdate));
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUpdateOnSatrtup = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.cbEnableAutoUpdate = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // nudMinutes
            // 
            this.nudMinutes.Enabled = false;
            this.nudMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudMinutes.Location = new System.Drawing.Point(189, 48);
            this.nudMinutes.Maximum = new decimal(new int[] {
            10080,
            0,
            0,
            0});
            this.nudMinutes.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(75, 26);
            this.nudMinutes.TabIndex = 2;
            this.nudMinutes.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time interval (minutes):";
            // 
            // cbUpdateOnSatrtup
            // 
            this.cbUpdateOnSatrtup.AutoSize = true;
            this.cbUpdateOnSatrtup.Enabled = false;
            this.cbUpdateOnSatrtup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbUpdateOnSatrtup.Location = new System.Drawing.Point(16, 88);
            this.cbUpdateOnSatrtup.Name = "cbUpdateOnSatrtup";
            this.cbUpdateOnSatrtup.Size = new System.Drawing.Size(157, 24);
            this.cbUpdateOnSatrtup.TabIndex = 4;
            this.cbUpdateOnSatrtup.Text = "Update on startup";
            this.cbUpdateOnSatrtup.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(282, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(201, 131);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbEnableAutoUpdate
            // 
            this.cbEnableAutoUpdate.AutoSize = true;
            this.cbEnableAutoUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbEnableAutoUpdate.Location = new System.Drawing.Point(16, 12);
            this.cbEnableAutoUpdate.Name = "cbEnableAutoUpdate";
            this.cbEnableAutoUpdate.Size = new System.Drawing.Size(173, 24);
            this.cbEnableAutoUpdate.TabIndex = 7;
            this.cbEnableAutoUpdate.Text = "Enable Auto Update";
            this.cbEnableAutoUpdate.UseVisualStyleBackColor = true;
            this.cbEnableAutoUpdate.CheckedChanged += new System.EventHandler(this.cbEnableAutoUpdate_CheckedChanged);
            // 
            // AutoUpdate
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(369, 167);
            this.Controls.Add(this.cbEnableAutoUpdate);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbUpdateOnSatrtup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMinutes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AutoUpdate";
            this.Text = "Auto Update Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbUpdateOnSatrtup;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbEnableAutoUpdate;
    }
}