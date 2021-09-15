using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAPI
{
    class Daegu
    {
        public string address { get; set; }
        public string attractname { get; set; }
        public string tel { get; set; }

        public Daegu(string address, string attractname, string tel)
        {
            this.address = address;
            this.attractname = attractname;
            this.tel = tel;
        }
    }
}
