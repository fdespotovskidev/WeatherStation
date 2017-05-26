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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLinkedInF_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/filip-despotovski-438751121/");
        }

        private void btnLinkedInA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/aleksandardespotovski/");
        }

        private void btnSourceCode_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/fdespotovskidev/WeatherStation");
        }
    }
}
