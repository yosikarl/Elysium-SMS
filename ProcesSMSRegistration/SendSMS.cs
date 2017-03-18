using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcesSMSRegistration
{
    class SendSMS
    {
        private const string infoForYouUserName = "frc";
        private const string infoForYouPWD = "elysium1937";

        private static System.IO.StreamWriter logFile = new System.IO.StreamWriter("SendSMS.log", true, Encoding.UTF8);
        /// <summary>
        /// Send an SMS message to one or more recipients
        /// </summary>
        /// <param name="message"></param>
        /// <param name="recipients"></param>
        public static string Send(string message, string recipients, bool doSend)
        {
            WS_SendSMS.SendMessageSoapClient SendSMS = new WS_SendSMS.SendMessageSoapClient();
            String Result = "";

            if (doSend)
            {
                Result = SendSMS.SendSmsDetailed(infoForYouUserName, infoForYouPWD,
                                                    message,
                                                    "", "", "", "",
                                                    recipients,
                                                    "", "", 0,
                                                    new DateTime(1900, 01, 01, 00, 00, 00),
                                                    "Elysium1937",
                                                    "0000", 0);
            }
            else
            {
                Result = "SMS to:\n\t" + recipients + "\n" +
                                "Message:\n\t" + message;
                MessageBox.Show(Result);
            }
                        
            logFile.WriteLine("{0},\"{1}\",\"{2}\",{3}",
                              DateTime.Now.ToString("yyyy -MM-dd HH:mm:ss"),
                              Result,
                              message,
                              recipients);
            logFile.Flush();
            //MessageBox.Show(Result);

            return Result;
        }
    }
}
