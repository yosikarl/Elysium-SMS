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
        public Form1()
        {
            InitializeComponent();
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
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(OutPutFileName,false,Encoding.UTF8))
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

        private const string infoForYouUserName = "frc";
        private const string infoForYouPWD = "elysium1937";

        private void button2_Click(object sender, EventArgs e)
        {
            WS_SendSMS.SendMessageSoapClient SendSMS = new WS_SendSMS.SendMessageSoapClient();
            String Result = SendSMS.SendSmsDetailed(infoForYouUserName, infoForYouPWD,
                                                    txtMessage.Text,
                                                    "","", "","",
                                                    txtRecipients.Text,
                                                    "","",0,
                                                    new DateTime(1900, 01, 01, 00, 00, 00),
                                                    "Elysium1937",
                                                    "0000", 0);
            MessageBox.Show(Result);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Match round = new Match();
            MessageBox.Show(round.Red1());
        }
    }
}
