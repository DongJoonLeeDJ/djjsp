using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form2 : Form
    {
        enum enumBook
        {
            Isbn, Name, Publisher, Page, UserId, isBorrowed, BorrowedAt
        }
        public Form2()
        {
            InitializeComponent();
            Text = "도서 관리";

            //dataGridView_book.DataSource = DataManager.Books;
            selectQuery();
        }

        private void selectQuery(string Isbn = "")
        {
            if (Isbn == "")
            {
                DBHelper.selectQuery_BookForm();
                dataGridView_book.DataSource = DBHelper.ds;
                dataGridView_book.DataMember = "BookTable";

            }
            else
            {
                DBHelper.selectQuery_BookForm(Isbn);
            }

            //conn.Close(); //연결 해제
        }

        private void insertQuery()
        {
            try
            {
                DBHelper.insertQuery_BookForm(textBox_isbn.Text, textBox_bookName.Text, textBox_publisher.Text, textBox_page.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                //해당 isbn 데이터가 존재하는지 체크(중복도서체크)
                selectQuery(textBox_isbn.Text);

                if (DBHelper.dt_book.Rows.Count > 0)
                {
                    MessageBox.Show("이미 존재하는 도서입니다.");
                }
                else
                {
                    int.TryParse(textBox_page.Text, out int page);
                    if(page <= 0)
                    {
                        MessageBox.Show("Page 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    insertQuery();
                    selectQuery();
                }
            }
            catch(Exception exception)
            {

            }
        }

        private void updateQuery()
        {
            try
            {
                DBHelper.updateQuery_BookForm(textBox_bookName.Text, textBox_publisher.Text, textBox_page.Text, textBox_isbn.Text);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }
        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(textBox_page.Text, out int page);
                if (page <= 0)
                {
                    MessageBox.Show("Page 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                    return;
                }

                //해당 isbn 데이터가 존재하는지 체크(중복도서체크)
                selectQuery(textBox_isbn.Text);

                if (DBHelper.dt_book.Rows.Count == 0)
                {
                    MessageBox.Show("존재하지 않는 도서입니다.");
                }
                else
                {
                    updateQuery();
                    selectQuery();
                }
            }
            catch(Exception ex)
            {
            }

        }

        private void deleteQuery()
        {
            try
            {
                DBHelper.deleteQuery_BookForm(textBox_isbn.Text);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                //해당 isbn 데이터가 존재하는지 체크(중복도서체크)
                selectQuery(textBox_isbn.Text);

                if (DBHelper.dt_book.Rows.Count == 0)
                {
                    MessageBox.Show("존재하지 않는 도서입니다.");
                }
                else
                {
                    deleteQuery();
                    selectQuery();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("존재하지 않는 도서입니다.");
            }
        }

        private void dataGridView_book_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var book = dataGridView_book.CurrentRow;
                textBox_isbn.Text = book.Cells[(int)enumBook.Isbn].Value.ToString();
                textBox_bookName.Text = book.Cells[(int)enumBook.Name].Value.ToString();
                textBox_publisher.Text = book.Cells[(int)enumBook.Publisher].Value.ToString();
                textBox_page.Text = book.Cells[(int)enumBook.Page].Value.ToString();
            }
            catch(Exception eee)
            {

            }

        }
    }
}
