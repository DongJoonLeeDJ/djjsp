using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book_re
{
    public partial class BookSearcher : Form
    {
        public string userid;
        public BookSearcher()
        {
            InitializeComponent();
            lb_RentDate.Text = DateTime.Now.ToLongDateString();
            lb_ReturnPlanDate.Text = DateTime.Now.AddDays(14).ToLongDateString();
        }
        public BookSearcher(List<SearchBook> searchBooks, string Id)
        {
            InitializeComponent(); 
            //if (DesignMode) return;
            dataGridView1.DataSource = null;
            // 오류 수정
            if(searchBooks.Count>0)
                dataGridView1.DataSource = searchBooks;
            lb_RentDate.Text = DateTime.Now.ToLongDateString();
            lb_ReturnPlanDate.Text = DateTime.Now.AddDays(14).ToLongDateString();
            userid = Id;
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Dispose();

        }


        DataManager instances = new DataManager();

        //상세정보
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string toremove = "span";
                string bname = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                label_isbn.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                label_bname.Text = bname.Replace(toremove, "");
                label_publisher.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                label_pyear.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                label_writer.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
            }
        }

        //검색
        private void bt_search_Click(object sender, EventArgs e)
        {
            DataManager instances = new DataManager();
            instances.Load(txt_search.Text);
            // 오류 수정
            dataGridView1.DataSource = null;
            if (DataManager.searchbooks.Count > 0)
                dataGridView1.DataSource = DataManager.searchbooks;
        }


        // 대여
        private void bt_borrow_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(userid))
            {
                MessageBox.Show("로그인 후 이용해주세요.");
            }
            else
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                instances.Rent(userid, dataGridView1.Rows[rowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[rowIndex].Cells[1].Value.ToString());
            }
            
            
        }
    }
    
}
