using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.FileIO;

namespace ProcesSMSRegistration
{
    public partial class Form1 : Form
    {
        private BindingSource teamsBinding = new BindingSource();

        private BindingList<Match> Matches;
        private BindingSource matchesBinding = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            teamsBinding.DataSource = Teams.TheTeams;
            TeamsList.DataSource = teamsBinding;

            Matches = new BindingList<Match>();
            matchesBinding.DataSource = Matches;
            MatchSchedule.DataSource = matchesBinding;
        }

        /// <summary>
        /// Convert - Read the CSV file from the registration page, write a CSV file with a single recipient per line 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MatchSchedule_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == MatchSchedule.Columns["SendSMS"].Index && e.RowIndex >= 0)
            {
                SendSMSForMatches(e.RowIndex);
            }
        }

        private void SendSMSForMatches(int matchIndex)
        {
            //MessageBox.Show(string.Format("SMS button on row {0} clicked", e.RowIndex));
            Match currMatch = (Match)MatchSchedule.Rows[matchIndex].DataBoundItem;

            // if using messages that wait for user input, do not create too much a load.
            if (!radioButtonSendSMS.Checked)
                currMatch.SMSSent = true;
            try
            {
                Team t;
                if ((t = Teams.FindByNumber(currMatch.B1)) != null)
                    LogSending(ProcesSMSRegistration.SendSMS.Send(currMatch.Blue1(),
                                                       t.PhoneNumbers, radioButtonSendSMS.Checked));
                if ((t = Teams.FindByNumber(currMatch.B2)) != null)
                    LogSending(ProcesSMSRegistration.SendSMS.Send(currMatch.Blue2(),
                                                       t.PhoneNumbers, radioButtonSendSMS.Checked));
                if ((t = Teams.FindByNumber(currMatch.B3)) != null)
                    LogSending(ProcesSMSRegistration.SendSMS.Send(currMatch.Blue3(),
                                                       t.PhoneNumbers, radioButtonSendSMS.Checked));
                if ((t = Teams.FindByNumber(currMatch.R1)) != null)
                    LogSending(ProcesSMSRegistration.SendSMS.Send(currMatch.Red1(),
                                                       t.PhoneNumbers, radioButtonSendSMS.Checked));
                if ((t = Teams.FindByNumber(currMatch.R2)) != null)
                    LogSending(ProcesSMSRegistration.SendSMS.Send(currMatch.Red2(),
                                                       t.PhoneNumbers, radioButtonSendSMS.Checked));
                if ((t = Teams.FindByNumber(currMatch.R3)) != null)
                    LogSending(ProcesSMSRegistration.SendSMS.Send(currMatch.Red3(),
                                                       t.PhoneNumbers, radioButtonSendSMS.Checked));
            }
            finally
            {
                currMatch.SMSSent = true;
            }

        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello, World!");

            openScheduleFileDialog.Filter = "Qualification Schedule|*Quals.csv|Practice Schedule|*Practice.csv|Any CSV File|*.csv";
            openScheduleFileDialog.ShowDialog();
            string scheduleFileName = openScheduleFileDialog.FileName;

            // MessageBox.Show(scheduleFileName);

            using (TextFieldParser parser = new TextFieldParser(scheduleFileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                bool headerFound = false;

                Matches.Clear();

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();

                    // skip all the irrelevat lines at top
                    // Qualification Match Schedule,,,,,,,,
                    // ,,,,,,,,Description,,,,,,,,
                    // Matches Per Team,,10,,,,,,
                    // Time,Description,Match,Blue 1,Blue 2,Blue 3,Red 1,Red 2,Red 3
                    // Mon 10:53,Qualification 1(B),1,1927,1918,1912,1908,1939,1915
                    // ...
                    // "SURROGATE matches will be marked ... forward to subsequent MATCHES.",,,,,,,,

                    if (fields[1] == null || fields[1].Length == 0)
                        continue;

                    // skip all the header line
                    if (!headerFound)
                    {
                        headerFound = true;
                        continue;
                    }

                    // Skip break (LUNCH / DINNER etc) lines
                    if (fields[0] == null || fields[0].Length == 0)
                        continue;

                    // Time,Description,Match,Blue 1,Blue 2,Blue 3,Red 1,Red 2,Red 3

                    Matches.Add(new Match(fields[1], fields[6], fields[7], fields[8], fields[3], fields[4], fields[5], fields[0]));
                }
                matchesBinding.DataSource = Matches;
                MatchSchedule.DataSource = matchesBinding;
            }

            setScheduleColors();
        }

        private int currDelay = 0;

        private void txtDelay_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDelay.Text, out currDelay))
                MessageBox.Show("Delay must be an integer");

            for (int i = 0; i < MatchSchedule.RowCount - 1; i++)
            {
                if (Matches[i].OriginalTimeAsDateTime >= DateTime.Now)
                    Matches[i].MinutesDelay = txtDelay.Text;
            }
            MatchSchedule.Refresh();
        }

        private void btnLoadTeams_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello, World!");

            openFileDialog1.Filter = "CSV files|*.csv";
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;

            // MessageBox.Show(fileName);

            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                //skip 1st line
                parser.ReadFields();

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                    string groupNum = fields[2];

                    Team thisTeam = Teams.FindByNumber(groupNum);
                    if (thisTeam == null)
                    {
                        thisTeam = new Team();
                        thisTeam.Number = groupNum;
                        thisTeam.Name = fields[1];
                        thisTeam.PhoneNumbers = "";
                        Teams.TheTeams.Add(thisTeam);
                    }

                    for (int i = 4; i < fields.Length; i += 2)
                        thisTeam.AddPhoneNumber(fields[i]);
                }
            }

            txtTotalTeams.Text = Teams.TheTeams.Count.ToString();
            txtTotalPhoneNumbers.Text = Teams.TheTeams.Sum(t => t.PhoneNumbers.Split(';').Length).ToString();

            setScheduleColors();
        }

        private void setScheduleColors()
        {
            foreach (DataGridViewRow Row in MatchSchedule.Rows)
            {
                foreach (DataGridViewCell Cell in Row.Cells)
                {
                    if (Cell.Value == null)
                        continue;
                    if (Cell.ColumnIndex <= 3 || Cell.ColumnIndex >= 10)
                    {
                        if (Matches[Cell.RowIndex].CorectedTimeAsDateTime < DateTime.Now)
                        {
                            Cell.Style.ForeColor = Color.DarkGray;
                        }
                        else
                        {
                            Cell.Style.ForeColor = Color.Black;
                        }
                        continue;
                    }

                    Team team = Teams.FindByNumber(Cell.Value.ToString());
                    if (team != null)
                        Cell.Style.ForeColor = Color.Black;
                    else
                        Cell.Style.ForeColor = Color.DarkGray;
                }

                chkTeamsForSMS.Items.Clear();
                foreach (Team team in Teams.TheTeams)
                {
                    chkTeamsForSMS.Items.Add(team.Number);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Match round = new Match();
            MessageBox.Show(round.Red1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string recipients = txtRecipients.Text.Replace(',', ';');

            foreach (int i in chkTeamsForSMS.CheckedIndices)
            {
                string teamNumber = chkTeamsForSMS.Items[i].ToString();
                string teamPhoneNumbers = Teams.FindByNumber(teamNumber).PhoneNumbers;
                recipients += ";" + teamPhoneNumbers;
            }

            LogSending(ProcesSMSRegistration.SendSMS.Send(txtMessage.Text, recipients, radioButtonSendSMS.Checked));
        }

        private void LogSending(string sendStatus)
        {
            txtLog.Text += Environment.NewLine + DateTime.Now.ToShortTimeString() + ": " + sendStatus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello, World!");

            openFileDialog1.Filter = "CSV files|*.csv";
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;

            MessageBox.Show(fileName);

            saveFileDialog1.FileName = "SMSReceipients.csv";
            saveFileDialog1.DefaultExt = ".csv";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.InitialDirectory = openFileDialog1.InitialDirectory;
            saveFileDialog1.ShowDialog();
            string OutPutFileName = saveFileDialog1.FileName;

            MessageBox.Show(OutPutFileName);

            using (TextFieldParser parser = new TextFieldParser(fileName))
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(OutPutFileName, false, Encoding.UTF8))
                {
                    file.WriteLine("שם פרטי, טלפון סלולרי, שיוך לקבוצה");

                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(",");

                    //skip 1st line
                    parser.ReadFields();

                    while (!parser.EndOfData)
                    {
                        //Processing row
                        string[] fields = parser.ReadFields();
                        string groupNum = fields[2];
                        string Name1 = fields[3];
                        string phone1 = fields[4];
                        string Name2 = fields[5];
                        string phone2 = fields[6];
                        file.WriteLine(Name1 + "," + phone1 + "," + groupNum);
                        file.WriteLine(Name2 + "," + phone2 + "," + groupNum);
                    }
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void a(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TeamsList_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            String message = string.Format("Data Error: col {0}, row {1}\nDetails: {2}",
                            e.ColumnIndex.ToString(),
                            e.RowIndex.ToString(),
                            e.Exception.ToString());
            //MessageBox.Show(message, "DataError");
        }

        private void TeamsList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            setScheduleColors();
        }

        private void MatchSchedule_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 &&
                e.ColumnIndex == 1 /*MatchSchedule.Columns["Delay"].Index*/)
            {
                object value = MatchSchedule.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                string minutesDelay = Matches[e.RowIndex].MinutesDelay;

                for (int i = e.RowIndex; i < MatchSchedule.RowCount - 1; i++)
                {
                    Matches[i].MinutesDelay = minutesDelay;
                }
                MatchSchedule.Refresh();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int advanceTime = 15;
            int.TryParse(txtAdvanceTimeForSMS.Text, out advanceTime);

            for (int i = 0; i < Matches.Count; i++)
            {
                Match thisMatch = (Match)MatchSchedule.Rows[i].DataBoundItem;

                if (thisMatch != null &&
                    !thisMatch.SMSSent &&
                    (thisMatch.AutoSend || (MatchSchedule.Rows[i] != null &&
                                            MatchSchedule.Rows[i].Cells["AutoSend"] != null &&
                                            ((DataGridViewCheckBoxCell)MatchSchedule.Rows[i].Cells["AutoSend"]).Value != null &&
                                            (Boolean)((DataGridViewCheckBoxCell)MatchSchedule.Rows[i].Cells["AutoSend"]).Value)) &&
                    //thisMatch.AutoSend &&
                    thisMatch.CorectedTimeAsDateTime >= DateTime.Now.AddMinutes(advanceTime - 1) &&
                    thisMatch.CorectedTimeAsDateTime < DateTime.Now.AddMinutes(advanceTime))
                {
                    SendSMSForMatches(i);
                }
            }
        }

        private void chkAutoAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Matches.Count; i++)
            {
                Matches[i].AutoSend = chkAutoAll.Checked;
            }
        }

        private void btnAllTeamsForSMS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkTeamsForSMS.Items.Count; i++)
            {
                chkTeamsForSMS.SetItemChecked(i, true);
            }
        }

        private void btnNonTeamForSMS_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < chkTeamsForSMS.Items.Count; i++)
            {
                chkTeamsForSMS.SetItemChecked(i, false);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < chkTeamsForSMS.Items.Count; i++)
            {
                chkTeamsForSMS.SetItemChecked(i, false);
            }

            foreach (DataGridViewRow Row in MatchSchedule.Rows)
            {
                foreach (DataGridViewCell Cell in Row.Cells)
                {
                    if (Cell.ColumnIndex > 3 && Cell.ColumnIndex < 10)
                    {
                        if (Cell.Value != null)
                        {
                            string teamNumber = Cell.Value.ToString();
                            int listEntryIndex = chkTeamsForSMS.FindStringExact(teamNumber);
                            if (listEntryIndex >= 0)
                                chkTeamsForSMS.SetItemChecked(listEntryIndex, true);
                        }
                    }
                }
            }
        }
    }
}
