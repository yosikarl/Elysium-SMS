using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesSMSRegistration
{
    class Teams
    {
        public static BindingList<Team> TheTeams = new BindingList<Team>();

        /// <summary>
        /// return the Team matching teamNumber, or null
        /// </summary>
        /// <param name="teamNumber"></param>
        /// <returns></returns>
        public static Team FindByNumber(string teamNumber)
        {
            return TheTeams.FirstOrDefault(t => t.Number == teamNumber);
        }
    }
}
