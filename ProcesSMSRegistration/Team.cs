using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesSMSRegistration
{
    class Team
    {
        private string _number;
        private string _name;
        private BindingList<string> _phoneNumbers;

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PhoneNumbers
        {
            get { return _phoneNumbers.Aggregate((a, b) => (a!=null&&a.Length>0 ? a + ";" : "") + b); }
            set { _phoneNumbers = new BindingList<string>(new List<string>(value.Split(';').Distinct())); }
        }

        public void AddPhoneNumber(string phoneNumber)
        {
            string adjsutedPhoneNumber = new string (phoneNumber.Where(c => c >= '0' && c <= '9').ToArray());
            if (adjsutedPhoneNumber.Length == 0)
                return;

            if (adjsutedPhoneNumber.FirstOrDefault() != '0')
                 adjsutedPhoneNumber = "0" + adjsutedPhoneNumber;
            if (!_phoneNumbers.Contains(adjsutedPhoneNumber))
                _phoneNumbers.Add(adjsutedPhoneNumber);
        }
    }
}
