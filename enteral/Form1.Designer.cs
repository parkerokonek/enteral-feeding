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

        #region Windows Form save generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.FeedRateDisplay = new System.Windows.Forms.Label();
            this.dailyVolumeDisplay = new System.Windows.Forms.Label();
            this.feedTypeDisplay = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedRateTag = new System.Windows.Forms.Label();
            this.dailyVolumeTag = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.loadFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gapStop = new System.Windows.Forms.ComboBox();
            this.gapStart = new System.Windows.Forms.ComboBox();
            this.AddGap = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MaxRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.DailyVolumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.feedTypeCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dailyStartCombo = new System.Windows.Forms.ComboBox();
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
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyVolumeNumeric)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.FeedRateDisplay);
            this.panel1.Controls.Add(this.dailyVolumeDisplay);
            this.panel1.Controls.Add(this.feedTypeDisplay);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.FeedRateTag);
            this.panel1.Controls.Add(this.dailyVolumeTag);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 122);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(378, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "Change Name";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FeedRateDisplay
            // 
            this.FeedRateDisplay.AutoSize = true;
            this.FeedRateDisplay.Location = new System.Drawing.Point(155, 83);
            this.FeedRateDisplay.Name = "FeedRateDisplay";
            this.FeedRateDisplay.Size = new System.Drawing.Size(45, 13);
            this.FeedRateDisplay.TabIndex = 15;
            this.FeedRateDisplay.Text = "(not set)";
            // 
            // dailyVolumeDisplay
            // 
            this.dailyVolumeDisplay.AutoSize = true;
            this.dailyVolumeDisplay.Location = new System.Drawing.Point(153, 60);
            this.dailyVolumeDisplay.Name = "dailyVolumeDisplay";
            this.dailyVolumeDisplay.Size = new System.Drawing.Size(45, 13);
            this.dailyVolumeDisplay.TabIndex = 14;
            this.dailyVolumeDisplay.Text = "(not set)";
            // 
            // feedTypeDisplay
            // 
            this.feedTypeDisplay.AutoSize = true;
            this.feedTypeDisplay.Location = new System.Drawing.Point(153, 38);
            this.feedTypeDisplay.Name = "feedTypeDisplay";
            this.feedTypeDisplay.Size = new System.Drawing.Size(45, 13);
            this.feedTypeDisplay.TabIndex = 13;
            this.feedTypeDisplay.Text = "(not set)";
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
            // FeedRateTag
            // 
            this.FeedRateTag.AutoSize = true;
            this.FeedRateTag.Location = new System.Drawing.Point(24, 83);
            this.FeedRateTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FeedRateTag.Name = "FeedRateTag";
            this.FeedRateTag.Size = new System.Drawing.Size(124, 13);
            this.FeedRateTag.TabIndex = 12;
            this.FeedRateTag.Text = "Maximum Feeding Rate: ";
            // 
            // dailyVolumeTag
            // 
            this.dailyVolumeTag.AutoSize = true;
            this.dailyVolumeTag.Location = new System.Drawing.Point(24, 61);
            this.dailyVolumeTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dailyVolumeTag.Name = "dailyVolumeTag";
            this.dailyVolumeTag.Size = new System.Drawing.Size(98, 13);
            this.dailyVolumeTag.TabIndex = 11;
            this.dailyVolumeTag.Text = "Total Daily Volume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Feeding Type: ";
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(8, 181);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(76, 23);
            this.loadFile.TabIndex = 24;
            this.loadFile.Text = "Load Info";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(85, 181);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(76, 23);
            this.saveFile.TabIndex = 23;
            this.saveFile.Text = "Save Info";
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.gapStop);
            this.panel2.Controls.Add(this.gapStart);
            this.panel2.Controls.Add(this.AddGap);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 118);
            this.panel2.TabIndex = 1;
            // 
            // gapStop
            // 
            this.gapStop.AllowDrop = true;
            this.gapStop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gapStop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gapStop.FormattingEnabled = true;
            this.gapStop.Items.AddRange(new object[] {
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
            "11:00 PM",
            "12:00 AM",
            "1:00 AM",
            "2:00 AM",
            "3:00 AM",
            "4:00 AM",
            "5:00 AM"});
            this.gapStop.Location = new System.Drawing.Point(12, 86);
            this.gapStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gapStop.Name = "gapStop";
            this.gapStop.Size = new System.Drawing.Size(90, 21);
            this.gapStop.TabIndex = 29;
            // 
            // gapStart
            // 
            this.gapStart.AllowDrop = true;
            this.gapStart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.gapStart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gapStart.FormattingEnabled = true;
            this.gapStart.Items.AddRange(new object[] {
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
            "11:00 PM",
            "12:00 AM",
            "1:00 AM",
            "2:00 AM",
            "3:00 AM",
            "4:00 AM",
            "5:00 AM"});
            this.gapStart.Location = new System.Drawing.Point(12, 46);
            this.gapStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gapStart.Name = "gapStart";
            this.gapStart.Size = new System.Drawing.Size(90, 21);
            this.gapStart.TabIndex = 24;
            // 
            // AddGap
            // 
            this.AddGap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddGap.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGap.Location = new System.Drawing.Point(124, 46);
            this.AddGap.Name = "AddGap";
            this.AddGap.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.AddGap.Size = new System.Drawing.Size(62, 58);
            this.AddGap.TabIndex = 25;
            this.AddGap.Text = "+";
            this.AddGap.UseVisualStyleBackColor = true;
            this.AddGap.Click += new System.EventHandler(this.AddGap_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Feed Stop:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Feed Resume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hours Missed:";
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.Color.White;
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.button2);
            this.settingsPanel.Controls.Add(this.loadFile);
            this.settingsPanel.Controls.Add(this.button1);
            this.settingsPanel.Controls.Add(this.MaxRateNumeric);
            this.settingsPanel.Controls.Add(this.saveFile);
            this.settingsPanel.Controls.Add(this.DailyVolumeNumeric);
            this.settingsPanel.Controls.Add(this.label4);
            this.settingsPanel.Controls.Add(this.label5);
            this.settingsPanel.Controls.Add(this.label9);
            this.settingsPanel.Controls.Add(this.feedTypeCombo);
            this.settingsPanel.Controls.Add(this.label10);
            this.settingsPanel.Controls.Add(this.dailyStartCombo);
            this.settingsPanel.Location = new System.Drawing.Point(508, 42);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(168, 214);
            this.settingsPanel.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(103, 108);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.MaxRateNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaxRateNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxRateNumeric.Name = "MaxRateNumeric";
            this.MaxRateNumeric.Size = new System.Drawing.Size(90, 20);
            this.MaxRateNumeric.TabIndex = 19;
            // 
            // DailyVolumeNumeric
            // 
            this.DailyVolumeNumeric.Location = new System.Drawing.Point(8, 108);
            this.DailyVolumeNumeric.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DailyVolumeNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DailyVolumeNumeric.Name = "DailyVolumeNumeric";
            this.DailyVolumeNumeric.Size = new System.Drawing.Size(90, 20);
            this.DailyVolumeNumeric.TabIndex = 21;
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
            this.feedTypeCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.feedTypeCombo.Name = "feedTypeCombo";
            this.feedTypeCombo.Size = new System.Drawing.Size(145, 21);
            this.feedTypeCombo.TabIndex = 11;
            this.feedTypeCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
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
            this.dailyStartCombo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dailyStartCombo.Name = "dailyStartCombo";
            this.dailyStartCombo.Size = new System.Drawing.Size(145, 21);
            this.dailyStartCombo.TabIndex = 13;
            this.dailyStartCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.SystemColors.Control;
            this.SettingsButton.Location = new System.Drawing.Point(508, 15);
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
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(231, 283);
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
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Current Time:";
            // 
            // dailyStart
            // 
            this.dailyStart.AutoSize = true;
            this.dailyStart.Location = new System.Drawing.Point(358, 283);
            this.dailyStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dailyStart.Name = "dailyStart";
            this.dailyStart.Size = new System.Drawing.Size(62, 13);
            this.dailyStart.TabIndex = 15;
            this.dailyStart.Text = "(not yet set)";
            this.dailyStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(358, 310);
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
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 283);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(68, 42);
            this.button3.TabIndex = 30;
            this.button3.Text = "Clear Hours";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 511);
            this.Controls.Add(this.button3);
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
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DailyVolumeNumeric)).EndInit();
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
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox feedTypeCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox dailyStartCombo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown MaxRateNumeric;
        private System.Windows.Forms.Label dailyVolumeTag;
        private System.Windows.Forms.Label FeedRateTag;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label rateOutput;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown DailyVolumeNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label missedOutput;
        private System.Windows.Forms.Label dailyStart;
        private System.Windows.Forms.Label currentTime;
        private System.Windows.Forms.Timer currentTimer;
        private System.Windows.Forms.Label feedTypeDisplay;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.Label dailyVolumeDisplay;
        private System.Windows.Forms.Label FeedRateDisplay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddGap;
        private System.Windows.Forms.ComboBox gapStop;
        private System.Windows.Forms.ComboBox gapStart;
        private System.Windows.Forms.Button button3;
    }
}

