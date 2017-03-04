using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcesSMSRegistration
{
    class Match
    {
        private int R1=4567;
        private int R2=675;
        private int R3=9567;
        private int B1=1345;
        private int B2=3567;
        private int B3=3856;
        private int time=1035;
        public Match ()//int R1, int R2, int R3, int B1, int B2, int B3, int time)
        {/*
            this.R1 = R1;
            this.R2 = R2;
            this.R3 = R3;
            this.B1 = B1;
            this.B2 = B2;
            this.B3 = B3;
            this.time = time;*/
        }
        public void setR1(int team)
        { this.R1 = team; }
        public void SetR2(int team)
        { this.R2 = team; }
        public void SetR3(int team)
        { this.R3 = team; }
        public void SetB1(int team)
        { this.B1 = team; }
        public void SetB2(int team)
        { this.B2 = team; }
        public void SetB3(int team)
        { this.B3 = team; }
        public void SetTime(int time)
        { this.time = time; }
        public string Red1(/*int R2, int R3, int B1, int B2, int B3, int time*/)
        {
            return "Team " + R1 + " your match is at" + time + " with the teams " + R2 + "," + R3 + " in red."+" against " + B1 + "," + B2 + "," + B3;
        }
        public string Red2(/*int R1, int R3, int B1, int B2, int B3, int time*/)
        {
            return "Team " + R2 + " your match is at" + time + " with the teams " + R1 + "," + R3 + " in red." + " against " + B1 + "," + B2 + "," + B3;
        }
        public string Red3(/*int R1, int R2, int B1, int B2, int B3, int time*/)
        {
            return "Team " + R3 + " your match is at" + time + " with the teams " + R1 + "," + R2+ " in red." + " against " + B1 + "," + B2 + "," + B3;
        }
        public string Blue1(/*int B2, int B3, int R1, int R2, int R3, int time*/)
        {
            return "Team " + B1 + " your match is at" + time + " with the teams " + B2 + "," + B3 + " in blue." + " against " + R1 + "," + R2 + "," + R3;
        }
        public string Blue2(/*int B1, int B3, int R1, int R2, int R3, int time*/)
        {
            return "Team " + B2 + " your match is at" + time + " with the teams " + B1 + "," + B3 + " in red." + " against " + R1 + "," + R2 + "," + R3;
        }
        public string Blue3(/*int B1, int B2, int R1, int R2, int R3, int time*/)
        {
            return "Team " + B3 + " your match is at" + time + " with the teams " + B1 + "," + B2 + " in red." + " against " + R1 + "," + R2 + "," + R3;
        }
    }
}
