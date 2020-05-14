using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace enteral
{
    public partial class patientPopUp : Form
    {
        private PatientInfo patientData = new PatientInfo("", FeedType.J, 1, 0);
        bool feed_set = false;
        bool total_set = false;
        public patientPopUp()
        {
            InitializeComponent();

            // Disable maximize and window resize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            dailyStartCombo.SelectedIndex = RegistryEdit.check_daily_start();
            this.loadMainButton.Enabled = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            // Create a new file opening dialog that automatically searches for files with a .txt extension
            OpenFileDialog fileToSave = new OpenFileDialog();
            fileToSave.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileToSave.FilterIndex = 1;
            fileToSave.RestoreDirectory = true;
            // Load all file content into here if possible
            var fileContent = string.Empty;

            // If they select OK on the dialog
            if (fileToSave.ShowDialog() == DialogResult.OK)
            {
                // Try to open the file
                var fs = fileToSave.OpenFile();
                // Try to read the whole file
                using (StreamReader reader = new StreamReader(fs))
                {
                    fileContent = reader.ReadToEnd();
                }

                // Set our reset time to today + time offset
                DateTime resetTime = DateTime.Now.Date.AddHours(Properties.Settings.Default.timeReset);
                PatientInfo patientDataTmp = new PatientInfo(fileContent, resetTime);
                if (patientDataTmp.validate())
                {
                    // If the file did not contain enough data or had invalid lines
                    MessageBox.Show("ERROR: Could not load patient information check file name and path.");
                    return;
                }
                else
                {
                    // Let a nurse know if old times were dropped (so they don't think the times just disappeared)
                    if (patientDataTmp.is_trimmed())
                    {
                        MessageBox.Show("Warning: Times over 24 hours were present and have been removed.");
                    }
                    // Save the data in our data class & sync
                    open_next_form(patientDataTmp);
                }
            }
        }

        private void open_next_form(PatientInfo patientData)
        {
            this.Hide();
            var main_form = new Form1();
            main_form.FormClosed += (s, args) => this.Close();
            main_form.Set_patient_info(patientData);
            main_form.Show();
        }

        

        private void dailyStartCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistryEdit.set_daily_start(dailyStartCombo.SelectedIndex);
        }

        private void feedTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Match each option of the combobox to one of our feeding types
            // Windows Form App has validation to ensure values are one of the form options
            // If somehow this doesn't happen, don't set any feed type
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
            else
            {
                patientData.set_max_rate(150);
                MaxRateNumeric.Value = 150;
            }
            this.feed_set = true;
            this.loadMainButton.Enabled = total_set;
        }

        private void DailyVolumeNumeric_ValueChanged(object sender, EventArgs e)
        {
            patientData.set_volume((double)DailyVolumeNumeric.Value);

            this.total_set = true;
            this.loadMainButton.Enabled = feed_set;
        }

        private void loadMainButton_Click(object sender, EventArgs e)
        {
            open_next_form(this.patientData);
        }
    }
}
