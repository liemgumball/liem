using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class SV
    {
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string LopSH { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public double DTB { get; set; }
        public bool HB { get; set; }
        public bool Anh { get; set; }
        public bool GDQP { get; set; }
        public SV(string mSSV, string name, string lopSH, bool gender , DateTime nS, double dTB, bool hB, bool anh, bool gDQP)
        {
            MSSV = mSSV;
            Name = name;
            LopSH = lopSH;
            Gender = gender;
            NS = nS;
            DTB = dTB;
            HB = hB;
            Anh = anh;
            GDQP = gDQP;
        }
    }
}
