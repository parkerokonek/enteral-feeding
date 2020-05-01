﻿using System;
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

        public System.Windows.Forms.Button[] Timeline = new System.Windows.Forms.Button[24];



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
            if (!Properties.Settings.Default.rateOverride.Equals(-1))
            {
                MaxRateNumeric.Value = Properties.Settings.Default.rateOverride;
            }
            if (Properties.Settings.Default.timeReset != -1)
            {
                dailyStartCombo.SelectedIndex = Properties.Settings.Default.timeReset;
            }
            if (Properties.Settings.Default.dailyVolume != -1)
            {
                DailyVolumeNumeric.Value = Properties.Settings.Default.dailyVolume;
            }

            Timeline[0] = Timeline1;
            Timeline[1] = Timeline2;
            Timeline[2] = Timeline3;
            Timeline[3] = Timeline4;
            Timeline[4] = Timeline5;
            Timeline[5] = Timeline6;
            Timeline[6] = Timeline7;
            Timeline[7] = Timeline8;
            Timeline[8] = Timeline9;
            Timeline[9] = Timeline10;
            Timeline[10] = Timeline11;
            Timeline[11] = Timeline12;
            Timeline[12] = Timeline13;
            Timeline[13] = Timeline14;
            Timeline[14] = Timeline15;
            Timeline[15] = Timeline16;
            Timeline[16] = Timeline17;
            Timeline[17] = Timeline18;
            Timeline[18] = Timeline19;
            Timeline[19] = Timeline20;
            Timeline[20] = Timeline21;
            Timeline[21] = Timeline22;
            Timeline[22] = Timeline23;
            Timeline[23] = Timeline24;

            int time = 0;
            string timestring = "";

            for (int i = 0; i <= 23; i++)
            {
                time = Properties.Settings.Default.timeReset + i;
                if (time > 12)
                {
                    time -= 12;
                    if (time > 12)
                    {
                        time -= 12;
                        timestring = time + ":00am";
                    }
                    else
                    {
                        timestring = time + ":00pm";
                    }
                }
                else
                {
                    timestring = time + ":00am";
                }
                Timeline[i].Text = timestring;
            }
        }

        /*private void addTimeGap_Click(object sender, EventArgs e)
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
        }*/

        private void setTimeline()
        {
            int start = 0;
            int stop = 0;
            int blockNumber = 0;
            double rate = 0;
            int time = 0;
            string timestring = "";

            for (int i = 0; i <= 23; i++)
            {
                time = Properties.Settings.Default.timeReset + i;
                if (time > 12)
                {
                    time -= 12;
                    if (time > 12)
                    {
                        time -= 12;
                        timestring = time + ":00am";
                    }
                    else
                    {
                        timestring = time + ":00pm";
                    }
                }
                else
                {
                    timestring = time + ":00am";
                }
                rate = this.patientData.getTimeBlocks(start, stop, blockNumber, i);

                if(rate == 0)
                {
                    Timeline[i].Text = timestring + "\nMissed";
                }
                else if(rate == -1)
                {
                    Timeline[i].Text = timestring;
                }
                else
                {
                    Timeline[i].Text =  timestring + "\nRate: " + rate + "ml/hr";
                }
                
            }

            blockNumber++;
            stop++;
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            bool isVis = settingsPanel.Visible;
            if (isVis)
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
            if (feedTypeCombo.SelectedIndex % 2 == 0)
            {
                maxRate = 150;
                MaxRateNumeric.Value = 240;

            }
            else
            {
                maxRate = 240;
                MaxRateNumeric.Value = 150;
            }
            patientData.set_max_rate((double)MaxRateNumeric.Value);

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
            dailyVolumeDisplay.Text = "" + DailyVolumeNumeric.Value;
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

        /*private void button3_Click(object sender, EventArgs e)
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
        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            patientData.set_max_rate((double)MaxRateNumeric.Value);
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
                    fs.Write(info, 0, info.Length);
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

            if (fileToSave.ShowDialog() == DialogResult.OK)
            {
                var fs = fileToSave.OpenFile();
                using (StreamReader reader = new StreamReader(fs))
                {
                    fileContent = reader.ReadToEnd();
                }

                DateTime resetTime = DateTime.Now.Date.AddHours(Properties.Settings.Default.timeReset);
                patientData = new PatientInfo(fileContent, resetTime);
                sync_ui();
            }



        }

        private void sync_ui()
        {
            this.DailyVolumeNumeric.Value = (decimal)this.patientData.get_volume();
            this.feedTypeCombo.SelectedIndex = (int)this.patientData.get_feed_type();
            this.MaxRateNumeric.Value = (decimal)this.patientData.get_maxrate();
            this.label1.Text = this.patientData.get_id();
            this.dailyVolumeDisplay.Text = "" + this.patientData.get_volume();
            this.FeedRateDisplay.Text = "" + this.patientData.get_maxrate();
            this.feedTypeDisplay.Text = this.feedTypeCombo.Text;

            setTimeline();

            display_feed_rate();
        }

        private void display_feed_rate()
        {
            this.rateOutput.Text = String.Format("{000}", (int)this.patientData.get_feed_rate_ml()) + " ml";
            this.missedOutput.Text = "" + this.patientData.hours_missed();
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

        private void label12_Click(object sender, EventArgs e)
        {

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBlocks_Click(object sender, EventArgs e)
        {
            setTimeline();
        }

        private void Timeline1_Click(object sender, EventArgs e)
        {
        }

        private void Timeline23_Click(object sender, EventArgs e)
        {

        }

        private void Timeline22_Click(object sender, EventArgs e)
        {

        }

        private void Timeline21_Click(object sender, EventArgs e)
        {

        }

        private void Timeline20_Click(object sender, EventArgs e)
        {

        }

        private void Timeline19_Click(object sender, EventArgs e)
        {

        }

        private void Timeline18_Click(object sender, EventArgs e)
        {

        }

        private void Timeline17_Click(object sender, EventArgs e)
        {

        }

        private void Timeline16_Click(object sender, EventArgs e)
        {

        }

        private void Timeline15_Click(object sender, EventArgs e)
        {

        }

        private void Timeline14_Click(object sender, EventArgs e)
        {

        }

        private void Timeline13_Click(object sender, EventArgs e)
        {

        }

        private void Timeline12_Click(object sender, EventArgs e)
        {

        }

        private void Timeline11_Click(object sender, EventArgs e)
        {

        }

        private void Timeline10_Click(object sender, EventArgs e)
        {

        }

        private void Timeline9_Click(object sender, EventArgs e)
        {

        }

        private void Timeline8_Click(object sender, EventArgs e)
        {

        }

        private void Timeline7_Click(object sender, EventArgs e)
        {

        }

        private void Timeline6_Click(object sender, EventArgs e)
        {

        }

        private void Timeline5_Click(object sender, EventArgs e)
        {

        }

        private void Timeline4_Click(object sender, EventArgs e)
        {

        }

        private void Timeline3_Click(object sender, EventArgs e)
        {

        }

        private void Timeline2_Click(object sender, EventArgs e)
        {

        }

        private void Timeline24_Click(object sender, EventArgs e)
        {

        }
    }
}
