using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "도서관 관리";

            refreshStatus();

            //데이터 그리드 설정
            dataGridView_BookManager.DataSource = DataManager.Books;
            dataGridView_UserManager.DataSource = DataManager.Users;
            dataGridView_BookManager.CurrentCellChanged += DataGridView_BookManager_CurrentCellChanged;
        }

        private void refreshStatus()
        {

            //전체 도서 수
            label_allBookCount.Text = DataManager.Books.Count.ToString();
            //사용자 수
            label_allUserCount.Text = DataManager.Users.Count.ToString();
            //대출중인 도서의 수
            label_allBorrowedBook.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            //연체중인 도서의 수
            label_allDelayedBook.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();
        }

        private void DataGridView_BookManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Book book = dataGridView_BookManager.CurrentRow.DataBoundItem as Book;
                //Book book2 = (Book)dataGridView_BookManager.CurrentRow.DataBoundItem;
                textBox_isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_UserManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                User user = dataGridView_UserManager.CurrentRow.DataBoundItem as User;
                textBox_id.Text = user.Id.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void button_Borrow_Click(object sender, EventArgs e)
        {
            if (textBox_isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요.");
            }
            else if (textBox_id.Text.Trim() == "")
            {
                MessageBox.Show("사용자 Id를 입력해주세요.");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    }
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox_id.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView_BookManager.DataSource = null;
                        dataGridView_BookManager.DataSource = DataManager.Books;
                        DataManager.Save();

                        MessageBox.Show("\"" + book.Name + "\"이/가\"" + user.Name + "\"님께 대여되었습니다.");
                        refreshStatus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if (textBox_isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요.");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                    if (book.isBorrowed)
                    {
                        DateTime oldDay = book.BorrowedAt;
                        book.UserId = null;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        dataGridView_BookManager.DataSource = null;
                        dataGridView_BookManager.DataSource = DataManager.Books;
                        DataManager.Save();

                        TimeSpan timeDiff = DateTime.Now - oldDay;
                        int diffDays = timeDiff.Days;

                        if (diffDays > 7)
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 연체 상태로 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 반납되었습니다.");
                        }
                        refreshStatus();
                    }
                    else
                    {
                        MessageBox.Show("대여상태가 아닙니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }

            }

        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //new Form2().ShowDialog();
                Form2 temp = new Form2();
                temp.ShowDialog();
                DataManager.Load();
                dataGridView_BookManager.DataSource = null;
                dataGridView_BookManager.DataSource = DataManager.Books;
                refreshStatus();

            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Form3().ShowDialog();
                DataManager.Load();
                dataGridView_UserManager.DataSource = null;
                dataGridView_UserManager.DataSource = DataManager.Users;
                dataGridView_BookManager.DataSource = null;
                dataGridView_BookManager.DataSource = DataManager.Books;
                refreshStatus();

            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }

        }

    }
}
