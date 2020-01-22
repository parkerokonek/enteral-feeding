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
            missedOutput.Text = "0";
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
            //TimeList.Items.Add("" + num_gaps);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Daily start time set to: " + comboBox4.Text);
            label8.Text = "Daily Start Time:                 " + comboBox4.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Feeding type set to: " + comboBox3.Text);
            label7.Text = "Feeding Type:                    " + comboBox3.Text;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingsPanel.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

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

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
