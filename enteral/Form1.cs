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
        private PatientInfo patientData = new PatientInfo("0", FeedType.J, 1, 0);

        public Form1()
        {
            InitializeComponent();
            rateOutput.Text = "0";
            missedOutput.Text = "0";
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
                this.gapStart.Items.Clear();
                this.gapStop.Items.Clear();
                this.gapStart.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));
                this.gapStop.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));
            }
            if (Properties.Settings.Default.dailyVolume != -1) {
                DailyVolumeNumeric.Value = Properties.Settings.Default.dailyVolume;
            }
        }


        private void SettingsButton_Click(object sender, EventArgs e)
        {
            if (settingsPanel.Visible)
            {
                if (feedTypeCombo.SelectedItem.ToString() != "")
                {
                    Properties.Settings.Default.feedingType = feedTypeCombo.SelectedItem.ToString();
                }
                if (dailyStartCombo.SelectedItem.ToString() != "")
                {
                    Properties.Settings.Default.timeReset = dailyStartCombo.SelectedIndex;
                }
                Properties.Settings.Default.Save();

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
            gapStart.Items.Clear();
            gapStart.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));
            gapStop.Items.Clear();
            gapStop.Items.AddRange(generate_times(dailyStartCombo.SelectedIndex));
            Properties.Settings.Default.Save();
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
            // Internally and visually set the feeding rate to the appropriate amount 
            // 240ml/hr for Gastric feeding (NG & PEG, indices 0 & 2)
            // 150ml/hr for Jejunal feeding (NJ & J, indices 1 & 3)
            if (feedTypeCombo.SelectedIndex % 2 == 0)
            {
                patientData.set_max_rate(240);
                MaxRateNumeric.Value = 240;
            }
            else {
                patientData.set_max_rate(150);
                MaxRateNumeric.Value = 150;
            }

            FeedRateDisplay.Text = "" + MaxRateNumeric.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingsPanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Maximum feeding rate set to: " + MaxRateNumeric.Value);
            FeedRateDisplay.Text = "" + MaxRateNumeric.Value + "     \n(WARNING! This value may differ from the recommended max.)";
            patientData.set_max_rate((double)MaxRateNumeric.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total daily volume set to: " + DailyVolumeNumeric.Value);
            dailyVolumeDisplay.Text = "" + DailyVolumeNumeric.Value;
            patientData.set_volume((double)DailyVolumeNumeric.Value);
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
                    try
                    {
                        fs.Write(info, 0, info.Length);
                        fs.Close();
                    }
                    catch (Exception _e)
                    {
                        MessageBox.Show("Write error when committing changes to patient info file.");
                    }
                }
                else {
                    MessageBox.Show("Could not open the file path for writing, check file path and try again.");
                }
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileToSave = new OpenFileDialog();
            fileToSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileToSave.FilterIndex = 1;
            fileToSave.RestoreDirectory = true;
            var fileContent = string.Empty;

            if (fileToSave.ShowDialog() == DialogResult.OK) {
                var fs = fileToSave.OpenFile();
                using (StreamReader reader = new StreamReader(fs)) {
                    fileContent = reader.ReadToEnd();
                }

                DateTime resetTime = DateTime.Now.Date.AddHours(Properties.Settings.Default.timeReset);
                PatientInfo patientDataTmp = new PatientInfo(fileContent, resetTime);
                if (patientDataTmp.validate())
                {
                    MessageBox.Show("ERROR: Could not load patient information check file name and path.");
                    return;
                }
                else
                {
                    if (patientDataTmp.is_trimmed()) {
                        MessageBox.Show("Warning: Times over 24 hours were present and have been removed.");
                    }
                    patientData = patientDataTmp;
                    sync_ui();
                }
            }



        }

        private void sync_ui() {
            this.DailyVolumeNumeric.Value = (decimal)this.patientData.get_volume();
            this.feedTypeCombo.SelectedIndex = (int)this.patientData.get_feed_type();
            this.MaxRateNumeric.Value = (decimal)this.patientData.get_maxrate();
            this.label1.Text = this.patientData.get_id();
            this.dailyVolumeDisplay.Text = "" + this.patientData.get_volume();
            this.FeedRateDisplay.Text = "" + this.patientData.get_maxrate();
            this.feedTypeDisplay.Text = this.feedTypeCombo.Text;

            display_feed_rate();
        }

        private void display_feed_rate() {
            this.rateOutput.Text = String.Format("{000}", this.patientData.get_feed_rate_ml()) + " ml";
            this.rateOutput.Text = String.Format("{000}", (int)this.patientData.get_feed_rate_ml()) + " ml";
            this.missedOutput.Text = "" + this.patientData.hours_missed(); 
        }
        public void changeName()
        {
            Form changeName = new Form();
            Button accept = new Button();
            Button cancel = new Button();
            TextBox newName = new TextBox();

            changeName.Text = "Set Patient Name";
            newName.Text = "Enter Patient Name.";
            accept.Text = "OK";
            cancel.Text = "Cancel";

            accept.DialogResult = System.Windows.Forms.DialogResult.OK;

            newName.Location = new Point(10, 10);
            accept.Location = new Point(newName.Left, newName.Height + newName.Top + 10);
            cancel.Location = new Point(accept.Left, accept.Height + accept.Top + 10);

            changeName.HelpButton = true;

            changeName.StartPosition = FormStartPosition.CenterParent;

            changeName.AcceptButton = accept;
            changeName.CancelButton = cancel;

            changeName.Controls.Add(newName);
            changeName.Controls.Add(accept);
            changeName.Controls.Add(cancel);

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (changeName.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                this.label1.Text = newName.Text;
                this.patientData.set_id(newName.Text);
            }
            changeName.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            changeName();
        }

        private void AddGap_Click(object sender, EventArgs e)
        {
            int previousRate = (int)this.patientData.get_feed_rate_ml();
            int gapStart = this.gapStart.SelectedIndex;
            int gapStop = this.gapStop.SelectedIndex;

            for (int i = gapStart; i < gapStop; i++)
            {
                this.patientData.setTime(i, previousRate, 0, true);
            }

            sync_ui();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.patientData.clearTimes();
            sync_ui();
        }

        private object[] generate_times(int offset) {
            string[] array = {
            "12:00 AM",
            "1:00 AM",
            "2:00 AM",
            "3:00 AM",
            "4:00 AM",
            "5:00 AM",
            "6:00 AM",
            "7:00 AM",
            "8:00 AM",
            "9:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "1:00 PM",
            "2:00 PM",
            "3:00 PM",
            "4:00 PM",
            "5:00 PM",
            "6:00 PM",
            "7:00 PM",
            "8:00 PM",
            "9:00 PM",
            "10:00 PM",
            "11:00 PM" };
            string[] output = new string[24];
            for (int i = 0; i < 24; i++) {
                output[i] = array[(i + offset) % 24];
            }
            foreach (String element in output){
                System.Diagnostics.Debug.WriteLine(element);
            }
            System.Diagnostics.Debug.WriteLine(output);
            return output;
        }

    }
}
