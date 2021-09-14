using Book_re.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_re
{
    class DataManager
    {
        public static List<BookRank> rank = new List<BookRank>();
        public static List<ExCheck> exChecks = new List<ExCheck>();
        public static List<RentalList> rentalLists = new List<RentalList>();
        public static List<SearchBook> searchbooks = new List<SearchBook>();
        public static List<Library> tb_lib = new List<Library>();       // 도서관 찾기


        public void Load(string bname)
        {
            DBHelper.SearchBname(bname);
            searchbooks.Clear();

            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                SearchBook temp = new SearchBook();
                temp.bName = item["BNAME"].ToString();
                temp.controllNum = item["CONTROLNUMBER"].ToString();
                temp.author = item["AUTHOR"].ToString();
                temp.publisher = item["PUBLISHER"].ToString();
                temp.isbn = item["ISBN"].ToString();
                temp.category = item["CATEGORY"].ToString();
                temp.pYear = item["PYEAR"].ToString();
                searchbooks.Add(temp);
            }
        }

        public void Rent(string pid, string bid, string bname)
        {
            // 반납했지만 연체가 있으면 연체기간 만큼 못 빌리게
            if (DBHelper.OverdueMember(pid) > DateTime.Now)
            {
                System.Windows.Forms.MessageBox.Show("연체된 이용자입니다.");
            }
            // 반납 안했을 때 연체된 책있으면 대여 못하게
            else if (DBHelper.CheckOverdue(pid))
            {
                System.Windows.Forms.MessageBox.Show("반환하지 않은 연체된 책이 있습니다. 책부터 반환해주세요.");
            }

            else
            {
                if(DBHelper.CheckRent(bid))
                {
                    System.Windows.Forms.MessageBox.Show("대여할 수 없는 책입니다.");
                }
                else
                {
                    DBHelper.RentBook(pid, bid, bname);//책대여
                    DBHelper.BookRnetCount(bid);//책카운트증가
                }
                

            }

        }
        public void ViewMyList(string pid)
        {
            DBHelper.ReadRentalList(pid);
            rentalLists.Clear();

            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                RentalList rentalList = new RentalList();
                rentalList.bName = item["bName"].ToString();
                rentalList.isbn = item["bid"].ToString();
                rentalList.rentDate = item["rentDate"].ToString();
                rentalList.returnDate = item["returnDate"].ToString();
                rentalList.pid = item["pid"].ToString();
                rentalLists.Add(rentalList);
            }
        }

        public void Return(string pid, string bid)
        {
            if (DateTime.Now > DBHelper.CheckOverdue(pid, bid))//늦게반납함
            {
                int dueDate = (DateTime.Now - DBHelper.CheckOverdue(pid, bid)).Days;
                DBHelper.UpdateOverDue(pid, dueDate);
            }

            DBHelper.ReturnBook(pid, bid);//책반납
            System.Windows.Forms.MessageBox.Show("반납되었습니다.");
        }

        public void Extend(string pid, string bid)
        {
            if (DBHelper.OverdueMember(pid) > DateTime.Now)
            {
                System.Windows.Forms.MessageBox.Show("책이 연체되어 연장할 수 없습니다.");
            }
            // 반납 안했을 때 연체된 책있으면 대여 못하게
            else if (DBHelper.CheckOverdue(pid))
            {
                System.Windows.Forms.MessageBox.Show("책이 연체되어 연장할 수 없습니다.");
            }
            DBHelper.ExtendDate(pid, bid);
            System.Windows.Forms.MessageBox.Show("연장되었습니다.");
        }

        public static void Load()
        {
            try
            {

                DBHelper.Query_Select();
                rank.Clear();
                foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
                {
                    BookRank temp = new BookRank();
                    temp.rank = item["순위"].ToString();
                    temp.subject = item["category"].ToString();
                    rank.Add(temp);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
      public int count_category(string query)
        {
            DBHelper.count(query);
            int count = 0;
            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                count = int.Parse(item["카테고리"].ToString());
            }
            return count;
        }
        public int count_rank(string query)
        {
            DBHelper.count(query);
            int count = 0;
            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                count = int.Parse(item["대출건수"].ToString());
            }
            return count;
        }

        //----------------------도서관 찾기-----------------------------------
        public static void LibraryLoad()
        {

            DBHelper.All();
            tb_lib.Clear();


            foreach (DataRow item in DBHelper.ds.Tables[0].Rows)
            {
                Library temp = new Library();
                temp.name = item["name"].ToString();
                temp.category = item["category"].ToString();

                tb_lib.Add(temp);
            }
        }
    }
}
