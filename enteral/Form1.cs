using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace enteral
{
    public partial class Form1 : Form
    {
        private Decimal missedHoursTotal = 0;
        private Decimal totalVol = 0;
        private Decimal maxRate = -1;
        private PatientInfo patientData = new PatientInfo("0", FeedType.J, 1, 0);
        private int num_gaps = 0;

        public Form1()
        {
            InitializeComponent();
            rateOutput.Text = "0";
            missedOutput.Text = missedHoursTotal.ToString();
            if (Properties.Settings.Default.feedingType != "" && feedTypeCombo.Items.Contains(Properties.Settings.Default.feedingType))
            {
                feedTypeDisplay.Text = Properties.Settings.Default.feedingType;
                feedTypeCombo.SelectedItem = Properties.Settings.Default.feedingType;
            }
            if (!Properties.Settings.Default.rateOverride.Equals(-1)) {
                MaxRateNumeric.Value = Properties.Settings.Default.rateOverride;
            }
            if (Properties.Settings.Default.timeReset != -1) {
                dailyStartCombo.SelectedIndex = Properties.Settings.Default.timeReset;
            }
            if (Properties.Settings.Default.dailyVolume != -1) {
                DailyVolumeNumeric.Value = Properties.Settings.Default.dailyVolume;
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
            MessageBox.Show("Daily start time set to: " + dailyStartCombo.Text);
            dailyStart.Text = dailyStartCombo.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {   
            MessageBox.Show("Feeding type set to: " + feedTypeCombo.Text);
            feedTypeDisplay.Text = feedTypeCombo.Text;
            switch (feedTypeCombo.SelectedIndex)
            {
                case 0:
                    patientData.set_feed(FeedType.NG);
                    break;
                case 1:
                    patientData.set_feed(FeedType.NJ);
                    break;
                case 2:
                    patientData.set_feed(FeedType.PEG);
                    break;
                case 3:
                    patientData.set_feed(FeedType.J);
                    break;
                default:
                    return;
            }
            if (feedTypeCombo.SelectedIndex % 2 == 0)
            {
                maxRate = 150;
                MaxRateNumeric.Value = 240;
            }
            else {
                maxRate = 240;
                MaxRateNumeric.Value = 150;
            }

            //MessageBox.Show("Maximum feeding rate set to: " + numericUpDown2.Value);
            FeedRateDisplay.Text = "" + MaxRateNumeric.Value;
            maxRate = MaxRateNumeric.Value;

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
            MessageBox.Show("Maximum feeding rate set to: " + MaxRateNumeric.Value);
            FeedRateDisplay.Text = "" + MaxRateNumeric.Value + "     \n(WARNING! This value may differ from the recommended max.)";
            maxRate = MaxRateNumeric.Value;
            patientData.set_max_rate((double)MaxRateNumeric.Value);

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
            MessageBox.Show("Total daily volume set to: " + DailyVolumeNumeric.Value);
            dailyVolumeTag.Text = "Total Daily Volume:            " + DailyVolumeNumeric.Value;
            totalVol = DailyVolumeNumeric.Value;
            patientData.set_volume((double)DailyVolumeNumeric.Value);

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
            if (feedTypeCombo.SelectedItem.ToString() != "") {
                Properties.Settings.Default.feedingType = feedTypeCombo.SelectedItem.ToString();
            }
            if (dailyStartCombo.SelectedItem.ToString() != "") {
                Properties.Settings.Default.timeReset = dailyStartCombo.SelectedIndex;
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

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            Stream fs;
            SaveFileDialog savedFile = new SaveFileDialog();
            savedFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            savedFile.FilterIndex = 2;
            savedFile.RestoreDirectory = true;

            if (savedFile.ShowDialog() == DialogResult.OK)
            {
                    if ((fs = savedFile.OpenFile()) != null || (fs = File.Create(savedFile.FileName)) != null)
                    {
                        // Code to write the stream goes here.
                        string data = patientData.to_string(DateTime.Now.Date.AddHours(Properties.Settings.Default.timeReset));
                    byte[] info = new UTF8Encoding(true).GetBytes(data);
                        fs.Write(info,0,info.Length);
                        fs.Close();
                    }
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileToSave = new OpenFileDialog();
            //fileToSave.FileName = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //fileToSave.FilterIndex = 2;
            fileToSave.RestoreDirectory = true;
            var fileContent = string.Empty;

            if (fileToSave.ShowDialog() == DialogResult.OK) {
                var fs = fileToSave.OpenFile();
                using (StreamReader reader = new StreamReader(fs)) {
                    fileContent = reader.ReadToEnd();
                }

                DateTime resetTime = DateTime.Now.Date.AddHours(Properties.Settings.Default.timeReset);
                patientData = new PatientInfo(fileContent, resetTime);
                sync_ui();
            }


            
        }

        private void sync_ui() {
            this.DailyVolumeNumeric.Value = (decimal)this.patientData.get_volume();
            this.feedTypeCombo.SelectedIndex = (int)this.patientData.get_feed_type();
            this.MaxRateNumeric.Value = (decimal)this.patientData.get_maxrate();
            this.label1.Text = this.patientData.get_id();
            this.dailyVolumeDisplay.Text = ""+this.patientData.get_volume();
            this.FeedRateDisplay.Text = "" + this.patientData.get_maxrate();
            this.feedTypeDisplay.Text = this.feedTypeCombo.Text;

            display_feed_rate();
        }

        private void display_feed_rate() {
            this.rateOutput.Text = String.Format("{000}",this.patientData.get_feed_rate_ml())+" ml";
            this.missedOutput.Text = "" + this.patientData.hours_missed();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void feedTypeDisplay_Click(object sender, EventArgs e)
        {

        }

        private void dailyVolumeDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
