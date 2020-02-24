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
        private Decimal missedHoursTotal = 0;
        private Decimal totalVol = 0;
        private Decimal maxRate = -1;
        private int num_gaps = 0;

        public Form1()
        {
            InitializeComponent();
            rateOutput.Text = "0";
            missedOutput.Text = missedHoursTotal.ToString();
            if (Properties.Settings.Default.feedingType != "" && comboBox3.Items.Contains(Properties.Settings.Default.feedingType))
            {
                feedTypeDisplay.Text = Properties.Settings.Default.feedingType;
                comboBox3.SelectedItem = Properties.Settings.Default.feedingType;
            }
            if (!Properties.Settings.Default.rateOverride.Equals(-1)) {
                numericUpDown2.Value = Properties.Settings.Default.rateOverride;
            }
            if (Properties.Settings.Default.timeReset != -1) {
                comboBox4.SelectedIndex = Properties.Settings.Default.timeReset;
            }
            if (Properties.Settings.Default.dailyVolume != -1) {
                numericUpDown3.Value = Properties.Settings.Default.dailyVolume;
            }
        }

        private void addTimeGap_Click(object sender, EventArgs e)
        {
            Decimal val = missedCounter.Value;
            missedCounter.Value = 0;
            missedHoursTotal += val;
            missedOutput.Text = ""+missedHoursTotal;

            //update function
            if (missedHoursTotal > 23) { } else {
                Decimal rate = Math.Round(totalVol / (24 - missedHoursTotal));
                rateOutput.Text = "" + ((maxRate > 0) ? Math.Min(rate,maxRate) : rate); 
            }
        }


        private void SettingsButton_Click(object sender, EventArgs e)
        {
            bool isVis = settingsPanel.Visible;
            if (isVis)
            {
                settingsPanel.Hide();
                SettingsButton.Text = "Edit Settings";
            }
            else
            {
                settingsPanel.Show();
                SettingsButton.Text = "Close [X]";
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Daily start time set to: " + comboBox4.Text);
            dailyStart.Text = comboBox4.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {   
            MessageBox.Show("Feeding type set to: " + comboBox3.Text);
            feedTypeDisplay.Text = comboBox3.Text;
            if (comboBox3.SelectedIndex % 2 == 0)
            {
                maxRate = 150;
                numericUpDown2.Value = 240;
            }
            else {
                maxRate = 240;
                numericUpDown2.Value = 150;
            }

            //MessageBox.Show("Maximum feeding rate set to: " + numericUpDown2.Value);
            label12.Text = "Maximum Feeding Rate:     " + numericUpDown2.Value;
            maxRate = numericUpDown2.Value;

            //update function
            if (missedHoursTotal > 23) { }
            else
            {
                Decimal rate = Math.Round(totalVol / (24 - missedHoursTotal));
                rateOutput.Text = "" + ((maxRate > 0) ? Math.Min(rate, maxRate) : rate);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingsPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximum feeding rate set to: " + numericUpDown2.Value);
            label12.Text = "Maximum Feeding Rate:     " + numericUpDown2.Value + "     \n(WARNING! This value may differ from the recommended max.)";
            maxRate = numericUpDown2.Value;

            //update function
            if (missedHoursTotal > 23) { }
            else
            {
                Decimal rate = Math.Round(totalVol / (24 - missedHoursTotal));
                rateOutput.Text = "" + ((maxRate > 0) ? Math.Min(rate, maxRate) : rate);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total daily volume set to: " + numericUpDown3.Value);
            label11.Text = "Total Daily Volume:            " + numericUpDown3.Value;
            totalVol = numericUpDown3.Value;

            //update function
            if (missedHoursTotal > 23) { }
            else
            {
                Decimal rate = Math.Round(totalVol / (24 - missedHoursTotal));
                rateOutput.Text = "" + ((maxRate > 0) ? Math.Min(rate, maxRate) : rate);
            }
        }

        private void currentTimer_Tick(object sender, EventArgs e)
        {
            currentTime.Text = DateTime.Now.ToString("h:mm tt");
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() != "") {
                Properties.Settings.Default.feedingType = comboBox3.SelectedItem.ToString();
            }
            if (comboBox4.SelectedItem.ToString() != "") {
                Properties.Settings.Default.timeReset = comboBox4.SelectedIndex;
            }
            Properties.Settings.Default.Save();

            settingsPanel.Hide();
            SettingsButton.Text = "Edit Settings";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Decimal val = missedCounter.Value;
            missedCounter.Value = 0;
            missedHoursTotal -= val;
            missedOutput.Text = "" + missedHoursTotal;

            //update function
            if (missedHoursTotal > 23) { }
            else
            {
                Decimal rate = Math.Round(totalVol / (24 - missedHoursTotal));
                rateOutput.Text = "" + ((maxRate > 0) ? Math.Min(rate, maxRate) : rate);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
