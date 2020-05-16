namespace enteral
{
    partial class patientPopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.loadFile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.loadMainButton = new System.Windows.Forms.Button();
            this.DailyVolumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.feedTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dailyStartCombo = new System.Windows.Forms.ComboBox();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyVolumeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.button2);
            this.settingsPanel.Controls.Add(this.loadFile);
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Controls.Add(this.MaxRateNumeric);
            this.settingsPanel.Controls.Add(this.loadMainButton);
            this.settingsPanel.Controls.Add(this.DailyVolumeNumeric);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.feedTypeCombo);
            this.settingsPanel.Controls.Add(this.label10);
            this.settingsPanel.Controls.Add(this.dailyStartCombo);
            this.settingsPanel.Location = new System.Drawing.Point(12, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(168, 214);
            this.settingsPanel.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 20;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(8, 181);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(76, 23);
            this.loadFile.TabIndex = 24;
            this.loadFile.Text = "Load Patient";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 11;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaxRateNumeric
            // 
            this.MaxRateNumeric.Location = new System.Drawing.Point(8, 150);
            this.MaxRateNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.MaxRateNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxRateNumeric.Name = "MaxRateNumeric";
            this.MaxRateNumeric.Size = new System.Drawing.Size(90, 20);
            this.MaxRateNumeric.TabIndex = 19;
            // 
            // loadMainButton
            // 
            this.loadMainButton.Location = new System.Drawing.Point(85, 181);
            this.loadMainButton.Name = "loadMainButton";
            this.loadMainButton.Size = new System.Drawing.Size(76, 23);
            this.loadMainButton.TabIndex = 23;
            this.loadMainButton.Text = "Continue";
            this.loadMainButton.UseVisualStyleBackColor = true;
            this.loadMainButton.Click += new System.EventHandler(this.loadMainButton_Click);
            // 
            // DailyVolumeNumeric
            // 
            this.DailyVolumeNumeric.Location = new System.Drawing.Point(8, 108);
            this.DailyVolumeNumeric.Margin = new System.Windows.Forms.Padding(2);
            this.DailyVolumeNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DailyVolumeNumeric.Name = "DailyVolumeNumeric";
            this.DailyVolumeNumeric.Size = new System.Drawing.Size(90, 20);
            this.DailyVolumeNumeric.TabIndex = 21;
            this.DailyVolumeNumeric.ValueChanged += new System.EventHandler(this.DailyVolumeNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 133);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Max Rate Override (WARNING)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Daily Volume";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Feeding Type";
            // 
            // feedTypeCombo
            // 
            this.feedTypeCombo.AllowDrop = true;
            this.feedTypeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.feedTypeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.feedTypeCombo.FormattingEnabled = true;
            this.feedTypeCombo.Items.AddRange(new object[] {
            "Nasogastic (NG Tube)",
            "Nasojejunal (NJ Tube)",
            "Percutaneous Endoscopic Gastronomy (PEG Tube)",
            "Jejunostomy (J Tube)"});
            this.feedTypeCombo.Location = new System.Drawing.Point(8, 67);
            this.feedTypeCombo.Margin = new System.Windows.Forms.Padding(2);
            this.feedTypeCombo.Name = "feedTypeCombo";
            this.feedTypeCombo.Size = new System.Drawing.Size(145, 21);
            this.feedTypeCombo.TabIndex = 11;
            this.feedTypeCombo.SelectedIndexChanged += new System.EventHandler(this.feedTypeCombo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Daily Start Time";
            // 
            // dailyStartCombo
            // 
            this.dailyStartCombo.AllowDrop = true;
            this.dailyStartCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.dailyStartCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dailyStartCombo.FormattingEnabled = true;
            this.dailyStartCombo.Items.AddRange(new object[] {
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
            "11:00 PM"});
            this.dailyStartCombo.Location = new System.Drawing.Point(8, 25);
            this.dailyStartCombo.Margin = new System.Windows.Forms.Padding(2);
            this.dailyStartCombo.Name = "dailyStartCombo";
            this.dailyStartCombo.Size = new System.Drawing.Size(145, 21);
            this.dailyStartCombo.TabIndex = 13;
            this.dailyStartCombo.SelectedIndexChanged += new System.EventHandler(this.dailyStartCombo_SelectedIndexChanged);
            // 
            // patientPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 235);
            this.Controls.Add(this.settingsPanel);
            this.Name = "patientPopUp";
            this.Text = "Patient Properties";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyVolumeNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown MaxRateNumeric;
        private System.Windows.Forms.Button loadMainButton;
        private System.Windows.Forms.NumericUpDown DailyVolumeNumeric;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox feedTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dailyStartCombo;
    }
}