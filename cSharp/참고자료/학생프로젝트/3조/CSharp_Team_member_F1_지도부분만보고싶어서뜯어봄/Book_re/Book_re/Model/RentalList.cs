using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{
    class RentalList
    {
        public RentalList(string rentDate, string returnDate, string bName, string isbn, string pid)
        {
            this.rentDate = rentDate;
            this.returnDate = returnDate;
            this.bName = bName;
            this.isbn = isbn;
            this.pid = pid;
        }

        public RentalList()
        {

        }

        public string rentDate { get; set; }
        public string returnDate { get; set; }
        public string bName { get; set; }
        public string isbn { get; set; }
        public string pid { get; set; }
    }
}
