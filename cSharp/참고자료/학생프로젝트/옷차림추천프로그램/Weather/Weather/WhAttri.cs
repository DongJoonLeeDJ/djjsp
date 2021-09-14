using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class WhAttri
    {
        private string date;
        private int hightem;
        private int lowtem;
        private string strsummary;

        public WhAttri(string date, int hightem, int lowtem, string strsummary)
        {
            this.date = date;
            this.hightem = hightem;
            this.lowtem = lowtem;
            this.strsummary = strsummary;
        }

        public string Date { get => date; set => date = value; }
        public int Hightem { get => hightem; set => hightem = value; }
        public int Lowtem { get => lowtem; set => lowtem = value; }
        public string Strsummary { get => strsummary; set => strsummary = value; }
    }
}
