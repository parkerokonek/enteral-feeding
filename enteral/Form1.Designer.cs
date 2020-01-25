namespace enteral
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.missedCounter = new System.Windows.Forms.NumericUpDown();
            this.addTimeGap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.missedOutput = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rateOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dailyStart = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.currentTimer = new System.Windows.Forms.Timer(this.components);
            this.saveSettings = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missedCounter)).BeginInit();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 122);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient #1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Maximum Feeding Rate:     (not set)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 61);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Total Daily Volume:            (not set)";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Feeding Type:                    (not set)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.missedCounter);
            this.panel2.Controls.Add(this.addTimeGap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 66);
            this.panel2.TabIndex = 1;
            // 
            // missedCounter
            // 
            this.missedCounter.Location = new System.Drawing.Point(12, 32);
            this.missedCounter.Margin = new System.Windows.Forms.Padding(2);
            this.missedCounter.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.missedCounter.Name = "missedCounter";
            this.missedCounter.Size = new System.Drawing.Size(118, 20);
            this.missedCounter.TabIndex = 22;
            // 
            // addTimeGap
            // 
            this.addTimeGap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTimeGap.Location = new System.Drawing.Point(147, 14);
            this.addTimeGap.Name = "addTimeGap";
            this.addTimeGap.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.addTimeGap.Size = new System.Drawing.Size(39, 41);
            this.addTimeGap.TabIndex = 1;
            this.addTimeGap.Text = "+";
            this.addTimeGap.UseVisualStyleBackColor = true;
            this.addTimeGap.Click += new System.EventHandler(this.addTimeGap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Add Hours Missed:";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.saveSettings);
            this.settingsPanel.Controls.Add(this.button2);
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Controls.Add(this.numericUpDown2);
            this.settingsPanel.Controls.Add(this.numericUpDown3);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.comboBox3);
            this.settingsPanel.Controls.Add(this.label10);
            this.settingsPanel.Controls.Add(this.comboBox4);
            this.settingsPanel.Location = new System.Drawing.Point(454, 42);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(168, 225);
            this.settingsPanel.TabIndex = 3;
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
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(8, 150);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown2.TabIndex = 19;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(8, 108);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown3.TabIndex = 21;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
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
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.AllowDrop = true;
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Nasogastic (NG Tube)",
            "Nasojejunal (NJ Tube)",
            "Percutaneous Endoscopic Gastronomy (PEG Tube)",
            "Jejunostomy (J Tube)"});
            this.comboBox3.Location = new System.Drawing.Point(8, 67);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(145, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
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
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.AllowDrop = true;
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
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
            this.comboBox4.Location = new System.Drawing.Point(8, 25);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(145, 21);
            this.comboBox4.TabIndex = 13;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Location = new System.Drawing.Point(454, 15);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(109, 23);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Edit Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Recommended Rate";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Daily Start Time: ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.missedOutput);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.rateOutput);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(233, 151);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 118);
            this.panel3.TabIndex = 13;
            // 
            // missedOutput
            // 
            this.missedOutput.AutoSize = true;
            this.missedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.missedOutput.Location = new System.Drawing.Point(138, 82);
            this.missedOutput.Name = "missedOutput";
            this.missedOutput.Size = new System.Drawing.Size(50, 22);
            this.missedOutput.TabIndex = 24;
            this.missedOutput.Text = "####";
            this.missedOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label14.Location = new System.Drawing.Point(3, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 18);
            this.label14.TabIndex = 23;
            this.label14.Text = "Total Hours Missed:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // rateOutput
            // 
            this.rateOutput.AutoSize = true;
            this.rateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.rateOutput.Location = new System.Drawing.Point(70, 45);
            this.rateOutput.Name = "rateOutput";
            this.rateOutput.Size = new System.Drawing.Size(65, 29);
            this.rateOutput.TabIndex = 6;
            this.rateOutput.Text = "####";
            this.rateOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rateOutput.Click += new System.EventHandler(this.label13_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Time:";
            // 
            // dailyStart
            // 
            this.dailyStart.AutoSize = true;
            this.dailyStart.Location = new System.Drawing.Point(137, 228);
            this.dailyStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dailyStart.Name = "dailyStart";
            this.dailyStart.Size = new System.Drawing.Size(62, 13);
            this.dailyStart.TabIndex = 15;
            this.dailyStart.Text = "(not yet set)";
            this.dailyStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dailyStart.Click += new System.EventHandler(this.dailystart_Click);
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(137, 256);
            this.currentTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(62, 13);
            this.currentTime.TabIndex = 16;
            this.currentTime.Text = "(not yet set)";
            this.currentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentTimer
            // 
            this.currentTimer.Enabled = true;
            this.currentTimer.Interval = 1000;
            this.currentTimer.Tick += new System.EventHandler(this.currentTimer_Tick);
            // 
            // saveSettings
            // 
            this.saveSettings.Location = new System.Drawing.Point(84, 190);
            this.saveSettings.Name = "saveSettings";
            this.saveSettings.Size = new System.Drawing.Size(75, 23);
            this.saveSettings.TabIndex = 22;
            this.saveSettings.Text = "Save";
            this.saveSettings.UseVisualStyleBackColor = true;
            this.saveSettings.Click += new System.EventHandler(this.saveSettings_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 277);
            this.Controls.Add(this.currentTime);
            this.Controls.Add(this.dailyStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Enteral Feeding Rate Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.missedCounter)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addTimeGap;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label rateOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown missedCounter;
        private System.Windows.Forms.Label missedOutput;
        private System.Windows.Forms.Label dailyStart;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Button saveSettings;
    }
}

