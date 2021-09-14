using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{
    public class SearchBook
    {
        public SearchBook(string controllNum, string bName, string author, string publisher, string isbn, string category, string pYear)
        {
            this.controllNum = controllNum;
            this.bName = bName;
            this.author = author;
            this.publisher = publisher;
            this.isbn = isbn;
            this.category = category;
            this.pYear = pYear;
        }

        public SearchBook()
        {

        }

        public string controllNum { get; set; }
        public string bName { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string isbn { get; set; }
        public string category { get; set; }
        public string pYear { get; set; }
    }

    public class ExCheck
    {
        public string check { get; set; }

        public ExCheck()
        { }

        public ExCheck(string check)
        {
            this.check = check;
        }
    }
}
