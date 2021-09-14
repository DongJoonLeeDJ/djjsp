using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    class DataManaer
    {
        static List<Book> Books = new List<Book>();
        static List<User> Users = new List<User>();

        static DataManaer()
        {
            Load();
        }

        public static void Load()
        {

        }

        public static void Save()
        {
            // 도서 XML 생성
            string outputBook = "";
            outputBook += "<books>";
            foreach (var item in Books)
            {
                outputBook += "<book>";
                outputBook += "  <isbn></isbn>";
                outputBook += "  <name></name>";
                outputBook += "  <page></page>";
                outputBook += "  <userId></userId>";
                outputBook += "  <borrowedAt></borrowedAt>";
                outputBook += "  <returnedAt></returnedAt>";
                outputBook += "  <createdAt></createdAt>";
                outputBook += "</book>";
            }
            outputBook += "</books>";

            // 사용자 XML 생성
            string
        }
    }
}
