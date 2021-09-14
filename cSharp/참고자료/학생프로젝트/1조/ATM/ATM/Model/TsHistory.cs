using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    public class TsHistory
    {
        public string trans_date { get; set; }
        public string name { get; set; }
        public string amount { get; set; }
        public double balance { get; set; }
        public string type { get; set; }

    }
}
