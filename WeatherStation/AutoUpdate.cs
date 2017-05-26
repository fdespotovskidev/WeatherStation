using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class AutoUpdate : Form
    {
        public bool AutoUpdateEnabled { get; set; }
        public int UpdateInterval { get; set; }
        public bool UpdateOnStartup { get; set; }

        public AutoUpdate()
        {
            InitializeComponent();
        }

        private void cbEnableAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            nudMinutes.Enabled = !nudMinutes.Enabled;
            label1.Enabled = !label1.Enabled;
            cbUpdateOnSatrtup.Enabled = !cbUpdateOnSatrtup.Enabled;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            AutoUpdateEnabled = cbEnableAutoUpdate.Checked;
            UpdateInterval = (int) nudMinutes.Value;
            UpdateOnStartup = cbUpdateOnSatrtup.Checked;
            DialogResult = DialogResult.OK;
        }
        public void UpdateControls(bool AutoUpdateEnabled, int UpdateInterval, bool UpdateOnStartup)
        {
            cbEnableAutoUpdate.Checked = AutoUpdateEnabled;
            cbUpdateOnSatrtup.Enabled = AutoUpdateEnabled;
            nudMinutes.Enabled = AutoUpdateEnabled;
            nudMinutes.Value = UpdateInterval;
            cbUpdateOnSatrtup.Checked = UpdateOnStartup;
            this.AutoUpdateEnabled = AutoUpdateEnabled;
            this.UpdateInterval = UpdateInterval;
            this.UpdateOnStartup = UpdateOnStartup;
        }
    }
}
