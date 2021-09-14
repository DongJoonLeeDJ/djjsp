using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookManager
{
    class DataManager
    {
        public static List<Book> Books = new List<Book>();
        public static List<User> Users = new List<User>();

        static DataManager()
        {
            Load();
        }

        public static void Load()
        {
            try
            {

                //select 문으로 해당 테이블의 전체 데이터들을 가져옴
                DBHelper.selectQuery_Book();
                Books.Clear(); //새로 조회할 때마다 Clear 해줘야 함
                foreach (DataRow item in DBHelper.dt_book.Rows)
                {
                    Book book = new Book();
                    book.Isbn = item["Isbn"].ToString();
                    book.Name = item["Name"].ToString();
                    book.Publisher = item["Publisher"].ToString();
                    book.Page = int.Parse(item["Page"].ToString());
                    book.BorrowedAt = item["BorrowedAt"].ToString() == "" ? new DateTime() : DateTime.Parse(item["BorrowedAt"].ToString());
                    book.isBorrowed = bool.Parse(item["isBorrowed"].ToString());
                    if(item["UserId"].ToString() == "")
                    {
                        book.UserId = null;
                    }
                    else
                    {
                        book.UserId = int.Parse(item["UserId"].ToString());
                    }
                    book.UserName = item["UserName"].ToString();
                    Books.Add(book);
                }

                DBHelper.selectQuery_User();
                Users.Clear();
                foreach (DataRow item in DBHelper.dt_user.Rows)
                {
                    User user = new User();
                    user.Id = int.Parse(item["Id"].ToString());
                    user.Name = item["Name"].ToString();
                    Users.Add(user);

                }
            }
            catch (Exception e)
            {
            }
        }

        //Save할 때 마다 리스트에 있는 걸 다 읽어와서 파일에 덮어쓰는 방식.
        //이 방식을 DB에서도 그대로 적용할 것
        //즉 해당 테이블을 모두 비워버린 후, Insert into 로 채워넣는다.
        public static void Save()
        {
            //부모테이블에 해당하는 UserTable을 먼저 리셋한다.
            DBHelper.allDeleteTable("UserTable");
            foreach (var item in Users)
            {
                DBHelper.allInsertIntoUserTable(item.Id, item.Name);
            }

            DBHelper.allDeleteTable("BookTable");

            foreach (var item in Books)
            {
                DBHelper.allInsertIntoBookTable(item.Isbn, item.Name, item.Publisher, item.Page, item.UserId, item.UserName, item.isBorrowed, item.BorrowedAt);
            }


            //string booksOutput = "";
            //booksOutput += "<books>\n";
            
            //foreach (var item in Books)
            //{
            //    booksOutput += "<book>\n";
            //    booksOutput = booksOutput + " <isbn>" + item.Isbn + "</isbn>\n";
            //    booksOutput += " <name>" + item.Name + "</name>\n";
            //    booksOutput += " <publisher>" + item.Publisher + "</publisher>\n";
            //    booksOutput += " <page>" + item.Page + "</page>\n";
            //    booksOutput += " <borrowedAt>" + item.BorrowedAt + "</borrowedAt>\n";
            //    booksOutput += " <isBorrowed>" + (item.isBorrowed ? 1 : 0) + "</isBorrowed>\n";
            //    booksOutput += " <userId>" + item.UserId + "</userId>\n";
            //    booksOutput += " <userName>" + item.UserName + "</userName>\n";
            //    booksOutput += "</book>\n";
            //}
            //booksOutput += "</books>";

            //string usersOutput = "";
            //usersOutput += "<users>\n";
            //foreach(var item in Users)
            //{
            //    usersOutput += "<user>\n";
            //    usersOutput += " <id>" + item.Id + "</id>\n";
            //    usersOutput += " <name>" + item.Name + "</name>\n";
            //    usersOutput += "</user>\n";
            //}
            //usersOutput += "</users>";

            //File.WriteAllText(@"./Books.xml", booksOutput);
            //File.WriteAllText(@"./Users.xml", usersOutput);
        }


    }
}
