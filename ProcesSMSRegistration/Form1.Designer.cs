﻿namespace ProcesSMSRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnLoadSchedule = new System.Windows.Forms.Button();
            this.openScheduleFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.MatchSchedule = new System.Windows.Forms.DataGridView();
            this.tabControlTest = new System.Windows.Forms.TabControl();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageTeams = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeamsList = new System.Windows.Forms.DataGridView();
            this.btnLoadTeams = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecipients = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.radioButtonSendSMS = new System.Windows.Forms.RadioButton();
            this.radioButtonShowMessage = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdvanceTimeForSMS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.OriginalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SendSMS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SMSSent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Delay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctedTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumbersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MatchSchedule)).BeginInit();
            this.tabControlTest.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            this.tabPageTeams.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsList)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnLoadSchedule
            // 
            this.btnLoadSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadSchedule.Location = new System.Drawing.Point(1035, 6);
            this.btnLoadSchedule.Name = "btnLoadSchedule";
            this.btnLoadSchedule.Size = new System.Drawing.Size(133, 23);
            this.btnLoadSchedule.TabIndex = 6;
            this.btnLoadSchedule.Text = "Load Schedule ...";
            this.btnLoadSchedule.UseVisualStyleBackColor = true;
            this.btnLoadSchedule.Click += new System.EventHandler(this.btnLoadSchedule_Click);
            // 
            // openScheduleFileDialog
            // 
            this.openScheduleFileDialog.Title = "Select Schedule file (.csv)";
            // 
            // MatchSchedule
            // 
            this.MatchSchedule.AutoGenerateColumns = false;
            this.MatchSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MatchSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatchSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OriginalTime,
            this.Delay,
            this.correctedTimeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.b1DataGridViewTextBoxColumn,
            this.b2DataGridViewTextBoxColumn,
            this.b3DataGridViewTextBoxColumn,
            this.r1DataGridViewTextBoxColumn,
            this.r2DataGridViewTextBoxColumn,
            this.r3DataGridViewTextBoxColumn,
            this.AutoSend,
            this.SendSMS,
            this.SMSSent});
            this.MatchSchedule.DataSource = this.matchBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MatchSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.MatchSchedule.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MatchSchedule.Location = new System.Drawing.Point(3, 35);
            this.MatchSchedule.Name = "MatchSchedule";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MatchSchedule.RowTemplate.Height = 24;
            this.MatchSchedule.Size = new System.Drawing.Size(1168, 510);
            this.MatchSchedule.TabIndex = 5;
            this.MatchSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatchSchedule_CellContentClick);
            this.MatchSchedule.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatchSchedule_CellValueChanged);
            // 
            // tabControlTest
            // 
            this.tabControlTest.Controls.Add(this.tabPageSchedule);
            this.tabControlTest.Controls.Add(this.tabPageTeams);
            this.tabControlTest.Controls.Add(this.tabPage1);
            this.tabControlTest.Controls.Add(this.tabSettings);
            this.tabControlTest.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlTest.Location = new System.Drawing.Point(0, 39);
            this.tabControlTest.Name = "tabControlTest";
            this.tabControlTest.SelectedIndex = 0;
            this.tabControlTest.Size = new System.Drawing.Size(1182, 577);
            this.tabControlTest.TabIndex = 7;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.label4);
            this.tabPageSchedule.Controls.Add(this.txtDelay);
            this.tabPageSchedule.Controls.Add(this.label3);
            this.tabPageSchedule.Controls.Add(this.MatchSchedule);
            this.tabPageSchedule.Controls.Add(this.btnLoadSchedule);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(1174, 548);
            this.tabPageSchedule.TabIndex = 0;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "minutes";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(109, 6);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(43, 22);
            this.txtDelay.TabIndex = 8;
            this.txtDelay.Text = "0";
            this.txtDelay.TextChanged += new System.EventHandler(this.txtDelay_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Delay:";
            // 
            // tabPageTeams
            // 
            this.tabPageTeams.Controls.Add(this.panel1);
            this.tabPageTeams.Controls.Add(this.btnLoadTeams);
            this.tabPageTeams.Controls.Add(this.button1);
            this.tabPageTeams.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeams.Name = "tabPageTeams";
            this.tabPageTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeams.Size = new System.Drawing.Size(1149, 548);
            this.tabPageTeams.TabIndex = 1;
            this.tabPageTeams.Text = "Teams";
            this.tabPageTeams.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TeamsList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 483);
            this.panel1.TabIndex = 9;
            // 
            // TeamsList
            // 
            this.TeamsList.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeamsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TeamsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeamsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneNumbersDataGridViewTextBoxColumn});
            this.TeamsList.DataSource = this.teamBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TeamsList.DefaultCellStyle = dataGridViewCellStyle5;
            this.TeamsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TeamsList.Location = new System.Drawing.Point(0, 0);
            this.TeamsList.Name = "TeamsList";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TeamsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.TeamsList.RowTemplate.Height = 24;
            this.TeamsList.Size = new System.Drawing.Size(1143, 483);
            this.TeamsList.TabIndex = 8;
            this.TeamsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.a);
            this.TeamsList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeamsList_CellValueChanged);
            this.TeamsList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TeamsList_DataError);
            // 
            // btnLoadTeams
            // 
            this.btnLoadTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTeams.Location = new System.Drawing.Point(1010, 6);
            this.btnLoadTeams.Name = "btnLoadTeams";
            this.btnLoadTeams.Size = new System.Drawing.Size(133, 23);
            this.btnLoadTeams.TabIndex = 7;
            this.btnLoadTeams.Text = "Load Teams ...";
            this.btnLoadTeams.UseVisualStyleBackColor = true;
            this.btnLoadTeams.Click += new System.EventHandler(this.btnLoadTeams_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1066, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtRecipients);
            this.tabPage1.Controls.Add(this.txtMessage);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1149, 548);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1038, 35);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "teamR1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recipients:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Message:";
            // 
            // txtRecipients
            // 
            this.txtRecipients.Location = new System.Drawing.Point(5, 83);
            this.txtRecipients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipients.Name = "txtRecipients";
            this.txtRecipients.Size = new System.Drawing.Size(275, 22);
            this.txtRecipients.TabIndex = 6;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(5, 26);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(641, 22);
            this.txtMessage.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1061, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "SendSMS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.label6);
            this.tabSettings.Controls.Add(this.txtAdvanceTimeForSMS);
            this.tabSettings.Controls.Add(this.label5);
            this.tabSettings.Controls.Add(this.radioButtonShowMessage);
            this.tabSettings.Controls.Add(this.radioButtonSendSMS);
            this.tabSettings.Location = new System.Drawing.Point(4, 25);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(1149, 548);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendSMS
            // 
            this.radioButtonSendSMS.AutoSize = true;
            this.radioButtonSendSMS.Checked = true;
            this.radioButtonSendSMS.Location = new System.Drawing.Point(9, 6);
            this.radioButtonSendSMS.Name = "radioButtonSendSMS";
            this.radioButtonSendSMS.Size = new System.Drawing.Size(95, 21);
            this.radioButtonSendSMS.TabIndex = 0;
            this.radioButtonSendSMS.TabStop = true;
            this.radioButtonSendSMS.Text = "Send SMS";
            this.radioButtonSendSMS.UseVisualStyleBackColor = true;
            // 
            // radioButtonShowMessage
            // 
            this.radioButtonShowMessage.AutoSize = true;
            this.radioButtonShowMessage.Location = new System.Drawing.Point(9, 35);
            this.radioButtonShowMessage.Name = "radioButtonShowMessage";
            this.radioButtonShowMessage.Size = new System.Drawing.Size(124, 21);
            this.radioButtonShowMessage.TabIndex = 1;
            this.radioButtonShowMessage.Text = "Show Message";
            this.radioButtonShowMessage.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Advance time to send SMS";
            // 
            // txtAdvanceTimeForSMS
            // 
            this.txtAdvanceTimeForSMS.Location = new System.Drawing.Point(193, 95);
            this.txtAdvanceTimeForSMS.Name = "txtAdvanceTimeForSMS";
            this.txtAdvanceTimeForSMS.Size = new System.Drawing.Size(62, 22);
            this.txtAdvanceTimeForSMS.TabIndex = 3;
            this.txtAdvanceTimeForSMS.Text = "15";
            this.txtAdvanceTimeForSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "minutes";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OriginalTime
            // 
            this.OriginalTime.DataPropertyName = "OriginalTime";
            this.OriginalTime.FillWeight = 35.97479F;
            this.OriginalTime.HeaderText = "Original";
            this.OriginalTime.MinimumWidth = 55;
            this.OriginalTime.Name = "OriginalTime";
            // 
            // AutoSend
            // 
            this.AutoSend.FillWeight = 0.2368719F;
            this.AutoSend.HeaderText = "Auto";
            this.AutoSend.MinimumWidth = 25;
            this.AutoSend.Name = "AutoSend";
            this.AutoSend.ToolTipText = "If checked, send SMS automatically about this match";
            // 
            // SendSMS
            // 
            this.SendSMS.FillWeight = 41.81691F;
            this.SendSMS.HeaderText = "SMS";
            this.SendSMS.MinimumWidth = 85;
            this.SendSMS.Name = "SendSMS";
            this.SendSMS.Text = "Send SMS";
            this.SendSMS.ToolTipText = "Send SMS to all teams about this match NOW";
            this.SendSMS.UseColumnTextForButtonValue = true;
            // 
            // SMSSent
            // 
            this.SMSSent.DataPropertyName = "SMSSent";
            this.SMSSent.HeaderText = "SMS Sent";
            this.SMSSent.Name = "SMSSent";
            this.SMSSent.ReadOnly = true;
            // 
            // Delay
            // 
            this.Delay.DataPropertyName = "MinutesDelay";
            this.Delay.FillWeight = 51.62643F;
            this.Delay.HeaderText = "Delay";
            this.Delay.MinimumWidth = 45;
            this.Delay.Name = "Delay";
            this.Delay.ToolTipText = "Match delay in minutes";
            // 
            // correctedTimeDataGridViewTextBoxColumn
            // 
            this.correctedTimeDataGridViewTextBoxColumn.DataPropertyName = "CorrectedTime";
            this.correctedTimeDataGridViewTextBoxColumn.FillWeight = 74.13279F;
            this.correctedTimeDataGridViewTextBoxColumn.HeaderText = "Corrected";
            this.correctedTimeDataGridViewTextBoxColumn.MinimumWidth = 55;
            this.correctedTimeDataGridViewTextBoxColumn.Name = "correctedTimeDataGridViewTextBoxColumn";
            this.correctedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 627.81F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 200;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // b1DataGridViewTextBoxColumn
            // 
            this.b1DataGridViewTextBoxColumn.DataPropertyName = "B1";
            this.b1DataGridViewTextBoxColumn.FillWeight = 6.015922F;
            this.b1DataGridViewTextBoxColumn.HeaderText = "Blue 1";
            this.b1DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.b1DataGridViewTextBoxColumn.Name = "b1DataGridViewTextBoxColumn";
            // 
            // b2DataGridViewTextBoxColumn
            // 
            this.b2DataGridViewTextBoxColumn.DataPropertyName = "B2";
            this.b2DataGridViewTextBoxColumn.FillWeight = 6.696256F;
            this.b2DataGridViewTextBoxColumn.HeaderText = "Blue 2";
            this.b2DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.b2DataGridViewTextBoxColumn.Name = "b2DataGridViewTextBoxColumn";
            // 
            // b3DataGridViewTextBoxColumn
            // 
            this.b3DataGridViewTextBoxColumn.DataPropertyName = "B3";
            this.b3DataGridViewTextBoxColumn.FillWeight = 9.189623F;
            this.b3DataGridViewTextBoxColumn.HeaderText = "Blue 3";
            this.b3DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.b3DataGridViewTextBoxColumn.Name = "b3DataGridViewTextBoxColumn";
            // 
            // r1DataGridViewTextBoxColumn
            // 
            this.r1DataGridViewTextBoxColumn.DataPropertyName = "R1";
            this.r1DataGridViewTextBoxColumn.FillWeight = 335.0254F;
            this.r1DataGridViewTextBoxColumn.HeaderText = "Red 1";
            this.r1DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.r1DataGridViewTextBoxColumn.Name = "r1DataGridViewTextBoxColumn";
            // 
            // r2DataGridViewTextBoxColumn
            // 
            this.r2DataGridViewTextBoxColumn.DataPropertyName = "R2";
            this.r2DataGridViewTextBoxColumn.FillWeight = 5.745171F;
            this.r2DataGridViewTextBoxColumn.HeaderText = "Red 2";
            this.r2DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.r2DataGridViewTextBoxColumn.Name = "r2DataGridViewTextBoxColumn";
            // 
            // r3DataGridViewTextBoxColumn
            // 
            this.r3DataGridViewTextBoxColumn.DataPropertyName = "R3";
            this.r3DataGridViewTextBoxColumn.FillWeight = 5.729855F;
            this.r3DataGridViewTextBoxColumn.HeaderText = "Red 3";
            this.r3DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.r3DataGridViewTextBoxColumn.Name = "r3DataGridViewTextBoxColumn";
            // 
            // matchBindingSource
            // 
            this.matchBindingSource.DataSource = typeof(ProcesSMSRegistration.Match);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneNumbersDataGridViewTextBoxColumn
            // 
            this.phoneNumbersDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneNumbersDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumbers";
            this.phoneNumbersDataGridViewTextBoxColumn.HeaderText = "PhoneNumbers";
            this.phoneNumbersDataGridViewTextBoxColumn.Name = "phoneNumbersDataGridViewTextBoxColumn";
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(ProcesSMSRegistration.Team);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 616);
            this.Controls.Add(this.tabControlTest);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Elysium 1937: SMS system";
            ((System.ComponentModel.ISupportInitialize)(this.MatchSchedule)).EndInit();
            this.tabControlTest.ResumeLayout(false);
            this.tabPageSchedule.ResumeLayout(false);
            this.tabPageSchedule.PerformLayout();
            this.tabPageTeams.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeamsList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.matchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.BindingSource matchBindingSource;
        private System.Windows.Forms.Button btnLoadSchedule;
        private System.Windows.Forms.OpenFileDialog openScheduleFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView MatchSchedule;
        private System.Windows.Forms.TabControl tabControlTest;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private System.Windows.Forms.TabPage tabPageTeams;
        private System.Windows.Forms.Button btnLoadTeams;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecipients;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TeamsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.RadioButton radioButtonShowMessage;
        private System.Windows.Forms.RadioButton radioButtonSendSMS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdvanceTimeForSMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delay;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctedTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn r1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn r2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn r3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AutoSend;
        private System.Windows.Forms.DataGridViewButtonColumn SendSMS;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SMSSent;
    }
}

