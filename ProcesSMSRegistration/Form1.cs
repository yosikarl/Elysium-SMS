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

            Team t;
            if ((t = Teams.FindByNumber(currMatch.B1)) != null)
                ProcesSMSRegistration.SendSMS.Send(currMatch.Blue1(),
                                                   t.PhoneNumbers, radioButtonSendSMS.Checked);
            if ((t = Teams.FindByNumber(currMatch.B2)) != null)
                ProcesSMSRegistration.SendSMS.Send(currMatch.Blue2(),
                                                   t.PhoneNumbers, radioButtonSendSMS.Checked);
            if ((t = Teams.FindByNumber(currMatch.B3)) != null)
                ProcesSMSRegistration.SendSMS.Send(currMatch.Blue3(),
                                                   t.PhoneNumbers, radioButtonSendSMS.Checked);
            if ((t = Teams.FindByNumber(currMatch.R1)) != null)
                ProcesSMSRegistration.SendSMS.Send(currMatch.Red1(),
                                                   t.PhoneNumbers, radioButtonSendSMS.Checked);
            if ((t = Teams.FindByNumber(currMatch.R2)) != null)
                ProcesSMSRegistration.SendSMS.Send(currMatch.Red2(),
                                                   t.PhoneNumbers, radioButtonSendSMS.Checked);
            if ((t = Teams.FindByNumber(currMatch.R3)) != null)
                ProcesSMSRegistration.SendSMS.Send(currMatch.Red3(),
                                                   t.PhoneNumbers, radioButtonSendSMS.Checked);

            currMatch.SMSSent = true;
        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Hello, World!");

            openScheduleFileDialog.Filter = "Qualification Schedule|*Quals.csv|Any CSV File|*.csv";
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

                    if (!headerFound)
                    {
                        headerFound = true;
                        continue;
                    }
                    // skip all the header line
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

            foreach (Match match in Matches)
                if (match.OriginalTimeAsDateTime >= DateTime.Now)
                    match.MinutesDelay = currDelay.ToString();
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
                        thisTeam.PhoneNumbers = "";
                        Teams.TheTeams.Add(thisTeam);
                    }

                    for (int i = 4; i < fields.Length; i += 2)
                        thisTeam.AddPhoneNumber(fields[i]);
                }
            }

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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Match round = new Match();
            MessageBox.Show(round.Red1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcesSMSRegistration.SendSMS.Send(txtMessage.Text, txtRecipients.Text, radioButtonSendSMS.Checked);
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

                for (int i = e.RowIndex; i < MatchSchedule.RowCount-1; i++)
                {
                    MatchSchedule.Rows[i].Cells[e.ColumnIndex].Value = value;
                    Matches[i].MinutesDelay = minutesDelay;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int advanceTime = 15;
            int.TryParse(txtAdvanceTimeForSMS.Text, out advanceTime);

            for (int i=0; i< Matches.Count; i++)
            {
                if (!Matches[i].SMSSent &&
                    Matches[i].CorectedTimeAsDateTime >= DateTime.Now.AddMinutes(advanceTime-1) &&
                    Matches[i].CorectedTimeAsDateTime < DateTime.Now.AddMinutes(advanceTime))
                {
                    SendSMSForMatches(i);
                }
            }
        }
    }
}
