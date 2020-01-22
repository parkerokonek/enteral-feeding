using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enteral
{
    public partial class Form1 : Form
    {
        private int num_gaps = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void addTimeGap_Click(object sender, EventArgs e)
        {
            num_gaps += 1;
            TimeList.Items.Add("" + num_gaps);
        }


        private void SettingsButton_Click(object sender, EventArgs e)
        {
            bool isVis = settingsPanel.Visible;
            if (isVis)
            {
                settingsPanel.Hide();
            }
            else
            {
                settingsPanel.Show();
            }
        }

    }
}
