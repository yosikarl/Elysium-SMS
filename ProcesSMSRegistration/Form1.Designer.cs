namespace ProcesSMSRegistration
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
            this.OriginalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoSend = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SendSMS = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SMSSent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControlTest = new System.Windows.Forms.TabControl();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.chkAutoAll = new System.Windows.Forms.CheckBox();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageTeams = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLoadTeams = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalTeams = new System.Windows.Forms.TextBox();
            this.txtTotalPhoneNumbers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TeamsList = new System.Windows.Forms.DataGridView();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainerTest = new System.Windows.Forms.SplitContainer();
            this.txtRecipients = new System.Windows.Forms.TextBox();
            this.buttonSendSMS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAllTeamsForSMS = new System.Windows.Forms.Button();
            this.btnNonTeamForSMS = new System.Windows.Forms.Button();
            this.chkTeamsForSMS = new System.Windows.Forms.CheckedListBox();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdvanceTimeForSMS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonShowMessage = new System.Windows.Forms.RadioButton();
            this.radioButtonSendSMS = new System.Windows.Forms.RadioButton();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPageTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeamsList)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTest)).BeginInit();
            this.splitContainerTest.Panel1.SuspendLayout();
            this.splitContainerTest.Panel2.SuspendLayout();
            this.splitContainerTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.btnLoadSchedule.Location = new System.Drawing.Point(732, 10);
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
            this.MatchSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatchSchedule.Location = new System.Drawing.Point(0, 0);
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
            this.MatchSchedule.Size = new System.Drawing.Size(1168, 504);
            this.MatchSchedule.TabIndex = 5;
            this.MatchSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatchSchedule_CellContentClick);
            this.MatchSchedule.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.MatchSchedule_CellValueChanged);
            // 
            // OriginalTime
            // 
            this.OriginalTime.DataPropertyName = "OriginalTime";
            this.OriginalTime.FillWeight = 10F;
            this.OriginalTime.HeaderText = "Original";
            this.OriginalTime.MinimumWidth = 55;
            this.OriginalTime.Name = "OriginalTime";
            // 
            // AutoSend
            // 
            this.AutoSend.DataPropertyName = "AutoSend";
            this.AutoSend.FillWeight = 1F;
            this.AutoSend.HeaderText = "Auto";
            this.AutoSend.MinimumWidth = 25;
            this.AutoSend.Name = "AutoSend";
            this.AutoSend.ToolTipText = "If checked, send SMS automatically about this match";
            // 
            // SendSMS
            // 
            this.SendSMS.FillWeight = 8F;
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
            this.SMSSent.FillWeight = 2F;
            this.SMSSent.HeaderText = "Sent";
            this.SMSSent.MinimumWidth = 25;
            this.SMSSent.Name = "SMSSent";
            this.SMSSent.ReadOnly = true;
            // 
            // tabControlTest
            // 
            this.tabControlTest.Controls.Add(this.tabPageSchedule);
            this.tabControlTest.Controls.Add(this.tabPageTeams);
            this.tabControlTest.Controls.Add(this.tabPage1);
            this.tabControlTest.Controls.Add(this.tabSettings);
            this.tabControlTest.Controls.Add(this.tabLog);
            this.tabControlTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTest.Location = new System.Drawing.Point(0, 0);
            this.tabControlTest.Name = "tabControlTest";
            this.tabControlTest.SelectedIndex = 0;
            this.tabControlTest.Size = new System.Drawing.Size(1182, 616);
            this.tabControlTest.TabIndex = 7;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.splitContainer1);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(1174, 587);
            this.tabPageSchedule.TabIndex = 0;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnLoadSchedule);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.chkAutoAll);
            this.splitContainer1.Panel1.Controls.Add(this.txtDelay);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MatchSchedule);
            this.splitContainer1.Size = new System.Drawing.Size(1168, 581);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Delay:";
            // 
            // chkAutoAll
            // 
            this.chkAutoAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkAutoAll.AutoSize = true;
            this.chkAutoAll.Location = new System.Drawing.Point(820, 39);
            this.chkAutoAll.Name = "chkAutoAll";
            this.chkAutoAll.Size = new System.Drawing.Size(45, 21);
            this.chkAutoAll.TabIndex = 10;
            this.chkAutoAll.Text = "All";
            this.chkAutoAll.UseVisualStyleBackColor = true;
            this.chkAutoAll.CheckedChanged += new System.EventHandler(this.chkAutoAll_CheckedChanged);
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(117, 9);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(43, 22);
            this.txtDelay.TabIndex = 8;
            this.txtDelay.Text = "0";
            this.txtDelay.TextChanged += new System.EventHandler(this.txtDelay_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "minutes";
            // 
            // tabPageTeams
            // 
            this.tabPageTeams.Controls.Add(this.splitContainer2);
            this.tabPageTeams.Location = new System.Drawing.Point(4, 25);
            this.tabPageTeams.Name = "tabPageTeams";
            this.tabPageTeams.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeams.Size = new System.Drawing.Size(1174, 587);
            this.tabPageTeams.TabIndex = 1;
            this.tabPageTeams.Text = "Teams";
            this.tabPageTeams.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label7);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoadTeams);
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.txtTotalTeams);
            this.splitContainer2.Panel1.Controls.Add(this.txtTotalPhoneNumbers);
            this.splitContainer2.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.TeamsList);
            this.splitContainer2.Size = new System.Drawing.Size(1168, 581);
            this.splitContainer2.SplitterDistance = 73;
            this.splitContainer2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total";
            // 
            // btnLoadTeams
            // 
            this.btnLoadTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadTeams.Location = new System.Drawing.Point(739, 10);
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
            this.button1.Location = new System.Drawing.Point(797, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "phone #s";
            // 
            // txtTotalTeams
            // 
            this.txtTotalTeams.Location = new System.Drawing.Point(56, 9);
            this.txtTotalTeams.Name = "txtTotalTeams";
            this.txtTotalTeams.ReadOnly = true;
            this.txtTotalTeams.Size = new System.Drawing.Size(61, 22);
            this.txtTotalTeams.TabIndex = 11;
            this.txtTotalTeams.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPhoneNumbers
            // 
            this.txtTotalPhoneNumbers.Location = new System.Drawing.Point(56, 38);
            this.txtTotalPhoneNumbers.Name = "txtTotalPhoneNumbers";
            this.txtTotalPhoneNumbers.ReadOnly = true;
            this.txtTotalPhoneNumbers.Size = new System.Drawing.Size(61, 22);
            this.txtTotalPhoneNumbers.TabIndex = 13;
            this.txtTotalPhoneNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "teams";
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
            this.Count,
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
            this.TeamsList.Size = new System.Drawing.Size(1168, 504);
            this.TeamsList.TabIndex = 8;
            this.TeamsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.a);
            this.TeamsList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TeamsList_CellValueChanged);
            this.TeamsList.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.TeamsList_DataError);
            // 
            // Count
            // 
            this.Count.DataPropertyName = "Count";
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainerTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1174, 587);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainerTest
            // 
            this.splitContainerTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTest.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTest.Location = new System.Drawing.Point(3, 3);
            this.splitContainerTest.Name = "splitContainerTest";
            this.splitContainerTest.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTest.Panel1
            // 
            this.splitContainerTest.Panel1.Controls.Add(this.txtRecipients);
            this.splitContainerTest.Panel1.Controls.Add(this.buttonSendSMS);
            this.splitContainerTest.Panel1.Controls.Add(this.label1);
            this.splitContainerTest.Panel1.Controls.Add(this.label2);
            this.splitContainerTest.Panel1.Controls.Add(this.txtMessage);
            // 
            // splitContainerTest.Panel2
            // 
            this.splitContainerTest.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainerTest.Size = new System.Drawing.Size(1168, 581);
            this.splitContainerTest.SplitterDistance = 127;
            this.splitContainerTest.TabIndex = 19;
            // 
            // txtRecipients
            // 
            this.txtRecipients.Location = new System.Drawing.Point(4, 80);
            this.txtRecipients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRecipients.Name = "txtRecipients";
            this.txtRecipients.Size = new System.Drawing.Size(641, 22);
            this.txtRecipients.TabIndex = 6;
            // 
            // buttonSendSMS
            // 
            this.buttonSendSMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSendSMS.Location = new System.Drawing.Point(739, 10);
            this.buttonSendSMS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSendSMS.Name = "buttonSendSMS";
            this.buttonSendSMS.Size = new System.Drawing.Size(133, 23);
            this.buttonSendSMS.TabIndex = 5;
            this.buttonSendSMS.Text = "Send SMS";
            this.buttonSendSMS.UseVisualStyleBackColor = true;
            this.buttonSendSMS.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Individual Recipients:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(4, 23);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(641, 22);
            this.txtMessage.TabIndex = 7;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label10);
            this.splitContainer3.Panel1.Controls.Add(this.button3);
            this.splitContainer3.Panel1.Controls.Add(this.btnAllTeamsForSMS);
            this.splitContainer3.Panel1.Controls.Add(this.btnNonTeamForSMS);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.chkTeamsForSMS);
            this.splitContainer3.Size = new System.Drawing.Size(1168, 450);
            this.splitContainer3.SplitterDistance = 137;
            this.splitContainer3.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Team Recipients:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 54);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Participating";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnAllTeamsForSMS
            // 
            this.btnAllTeamsForSMS.Location = new System.Drawing.Point(8, 25);
            this.btnAllTeamsForSMS.Name = "btnAllTeamsForSMS";
            this.btnAllTeamsForSMS.Size = new System.Drawing.Size(97, 23);
            this.btnAllTeamsForSMS.TabIndex = 16;
            this.btnAllTeamsForSMS.Text = "All";
            this.btnAllTeamsForSMS.UseVisualStyleBackColor = true;
            this.btnAllTeamsForSMS.Click += new System.EventHandler(this.btnAllTeamsForSMS_Click);
            // 
            // btnNonTeamForSMS
            // 
            this.btnNonTeamForSMS.Location = new System.Drawing.Point(9, 83);
            this.btnNonTeamForSMS.Name = "btnNonTeamForSMS";
            this.btnNonTeamForSMS.Size = new System.Drawing.Size(97, 23);
            this.btnNonTeamForSMS.TabIndex = 17;
            this.btnNonTeamForSMS.Text = "None";
            this.btnNonTeamForSMS.UseVisualStyleBackColor = true;
            this.btnNonTeamForSMS.Click += new System.EventHandler(this.btnNonTeamForSMS_Click);
            // 
            // chkTeamsForSMS
            // 
            this.chkTeamsForSMS.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkTeamsForSMS.FormattingEnabled = true;
            this.chkTeamsForSMS.Location = new System.Drawing.Point(0, 0);
            this.chkTeamsForSMS.Name = "chkTeamsForSMS";
            this.chkTeamsForSMS.Size = new System.Drawing.Size(126, 450);
            this.chkTeamsForSMS.TabIndex = 15;
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
            this.tabSettings.Size = new System.Drawing.Size(1174, 587);
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
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
            // txtAdvanceTimeForSMS
            // 
            this.txtAdvanceTimeForSMS.Location = new System.Drawing.Point(193, 95);
            this.txtAdvanceTimeForSMS.Name = "txtAdvanceTimeForSMS";
            this.txtAdvanceTimeForSMS.Size = new System.Drawing.Size(62, 22);
            this.txtAdvanceTimeForSMS.TabIndex = 3;
            this.txtAdvanceTimeForSMS.Text = "15";
            this.txtAdvanceTimeForSMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // tabLog
            // 
            this.tabLog.Controls.Add(this.panel2);
            this.tabLog.Location = new System.Drawing.Point(4, 25);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(1174, 587);
            this.tabLog.TabIndex = 4;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLog);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1168, 581);
            this.panel2.TabIndex = 0;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(1168, 581);
            this.txtLog.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Delay
            // 
            this.Delay.DataPropertyName = "MinutesDelay";
            this.Delay.FillWeight = 8F;
            this.Delay.HeaderText = "Delay";
            this.Delay.MinimumWidth = 45;
            this.Delay.Name = "Delay";
            this.Delay.ToolTipText = "Match delay in minutes";
            // 
            // correctedTimeDataGridViewTextBoxColumn
            // 
            this.correctedTimeDataGridViewTextBoxColumn.DataPropertyName = "CorrectedTime";
            this.correctedTimeDataGridViewTextBoxColumn.FillWeight = 10F;
            this.correctedTimeDataGridViewTextBoxColumn.HeaderText = "Corrected";
            this.correctedTimeDataGridViewTextBoxColumn.MinimumWidth = 55;
            this.correctedTimeDataGridViewTextBoxColumn.Name = "correctedTimeDataGridViewTextBoxColumn";
            this.correctedTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 50F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 160;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // b1DataGridViewTextBoxColumn
            // 
            this.b1DataGridViewTextBoxColumn.DataPropertyName = "B1";
            this.b1DataGridViewTextBoxColumn.FillWeight = 8F;
            this.b1DataGridViewTextBoxColumn.HeaderText = "Blue 1";
            this.b1DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.b1DataGridViewTextBoxColumn.Name = "b1DataGridViewTextBoxColumn";
            // 
            // b2DataGridViewTextBoxColumn
            // 
            this.b2DataGridViewTextBoxColumn.DataPropertyName = "B2";
            this.b2DataGridViewTextBoxColumn.FillWeight = 8F;
            this.b2DataGridViewTextBoxColumn.HeaderText = "Blue 2";
            this.b2DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.b2DataGridViewTextBoxColumn.Name = "b2DataGridViewTextBoxColumn";
            // 
            // b3DataGridViewTextBoxColumn
            // 
            this.b3DataGridViewTextBoxColumn.DataPropertyName = "B3";
            this.b3DataGridViewTextBoxColumn.FillWeight = 8F;
            this.b3DataGridViewTextBoxColumn.HeaderText = "Blue 3";
            this.b3DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.b3DataGridViewTextBoxColumn.Name = "b3DataGridViewTextBoxColumn";
            // 
            // r1DataGridViewTextBoxColumn
            // 
            this.r1DataGridViewTextBoxColumn.DataPropertyName = "R1";
            this.r1DataGridViewTextBoxColumn.FillWeight = 8F;
            this.r1DataGridViewTextBoxColumn.HeaderText = "Red 1";
            this.r1DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.r1DataGridViewTextBoxColumn.Name = "r1DataGridViewTextBoxColumn";
            // 
            // r2DataGridViewTextBoxColumn
            // 
            this.r2DataGridViewTextBoxColumn.DataPropertyName = "R2";
            this.r2DataGridViewTextBoxColumn.FillWeight = 8F;
            this.r2DataGridViewTextBoxColumn.HeaderText = "Red 2";
            this.r2DataGridViewTextBoxColumn.MinimumWidth = 55;
            this.r2DataGridViewTextBoxColumn.Name = "r2DataGridViewTextBoxColumn";
            // 
            // r3DataGridViewTextBoxColumn
            // 
            this.r3DataGridViewTextBoxColumn.DataPropertyName = "R3";
            this.r3DataGridViewTextBoxColumn.FillWeight = 8F;
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPageTeams.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeamsList)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.splitContainerTest.Panel1.ResumeLayout(false);
            this.splitContainerTest.Panel1.PerformLayout();
            this.splitContainerTest.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTest)).EndInit();
            this.splitContainerTest.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecipients;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button buttonSendSMS;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.RadioButton radioButtonShowMessage;
        private System.Windows.Forms.RadioButton radioButtonSendSMS;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdvanceTimeForSMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalPhoneNumbers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalTeams;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAutoAll;
        private System.Windows.Forms.Button btnNonTeamForSMS;
        private System.Windows.Forms.Button btnAllTeamsForSMS;
        private System.Windows.Forms.CheckedListBox chkTeamsForSMS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView TeamsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumbersDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitContainerTest;
        private System.Windows.Forms.SplitContainer splitContainer3;
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

