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
            switch (comboBox3.SelectedIndex)
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
            patientData.set_max_rate((double)numericUpDown2.Value);

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
            patientData.set_volume((double)numericUpDown3.Value);

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
            this.numericUpDown3.Value = (decimal)this.patientData.get_volume();
            this.label1.Text = this.patientData.get_id();
        }
    }
}
