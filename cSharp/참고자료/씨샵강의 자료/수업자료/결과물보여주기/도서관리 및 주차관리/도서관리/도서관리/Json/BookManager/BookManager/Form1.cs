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

            // 라벨 설정
            label5.Text = DataManager.Books.Count.ToString();
            label6.Text = DataManager.Users.Count.ToString();
            label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            label8.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) > DateTime.Now;
            }).Count().ToString();

            // 데이터 그리드 설정
            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += DataGridView2_CurrentCellChanged;

            // 버튼 이벤트 설정
            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
            }
            catch (Exception exception)
            {

            }
        }

        private void DataGridView2_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                User book = dataGridView2.CurrentRow.DataBoundItem as User;
                textBox3.Text = book.Id.ToString();
            }
            catch (Exception exception)
            {

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요");
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("사용자 Id를 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    }
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox3.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();

                        MessageBox.Show("\"" + book.Name + "\"이/가 \"" + user.Name + "\"님께 대여되었습니다.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    if (book.isBorrowed)
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == book.UserId.ToString());
                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();

                        if (book.BorrowedAt.AddDays(7) > DateTime.Now)
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 연체 상태로 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("\"" + book.Name + "\"이/가 반납되었습니다.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        //도서관리 및 사용자 관리 관련 추가 설명
        //파일이 없는 상태에서 프로그램 최초 실행시 Books 및 Users 파일을 만듭니다.
        //이 때 사용자나 도서 추가를 2번 이상 한 뒤, 임의의 칸을 클릭시 아래와 같은 에러가 나타납니다.
        //에러 명 : -1 인덱스에 값이 없습니다. (혹은 에러 없이 사용하고 있던 도서관리 혹은 사용자관리 창이 꺼지기도 합니다. 이 땐 다시 이 창을 다시 띄우면 이 오류가 발생하지 않습니다.)
        //에러 원인 : 파일이 있는 상태에서는 발생하지 않습니다. 
        //          최초의 파일 생성시에는 datagridview 및 list에 데이터가 없는 상태인데 이 때 임의의 인덱스로 접근하려고 하여서 발생한 오류로 보입니다.
        // 해결 방법 : 1. 파일 생성시에 임의의 더미 데이터를 넣어줍니다.
        //            2. 더미 데이터 생성이 싫다면 사용자에게 안내를 해줘야 합니다.
        //               파일이 없는 상태에서 최초 실행 후, 사용자나 도서를 한 번만 추가한 뒤 도서관리나 사용자관리 창을 다시 열어달라고 안내해야 합니다.( 그 뒤로는 발생 안 함)
        //               그리고 최초 실행이 아닌데 파일이 없어진 것이라면 그것자체가 문제이므로, 프로그램 시작 및 종료시마다 데이터 파일을 백업하는 기능을 구현해놓아야 합니다.
        //               따라서 프로그램 시작 및 종료할 때 마다 백업하는 기능도 추가해두었습니다.
        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //new Form2().ShowDialog();
                Form2 temp = new Form2();
                temp.ShowDialog();
                DataManager.Load();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Books;
            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ee)
            {

            }
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Form3().ShowDialog();
                DataManager.Load();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Books;
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = DataManager.Users;
            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ee)
            {

            }
        }
        private void dataFileBackup(string folderName)
        {
            DirectoryInfo di = new DirectoryInfo(folderName);
            if (!di.Exists)
            {
                di.Create();
            }
            string fileName_book = "Books.json";
            string fileName_user = "Users.json";
            string sourcePath = @".";
            string targetPath = @".\" + folderName;

            string sourceFile = Path.Combine(sourcePath, fileName_book);
            string destFile = Path.Combine(targetPath, fileName_book);
            File.Copy(sourceFile, destFile, true); //덮어씁니다. 날짜나 시간별로 관리를 원할 경우 저장하는 파일명을 바꿔야 합니다.

            sourceFile = Path.Combine(sourcePath, fileName_user);
            destFile = Path.Combine(targetPath, fileName_user);
            File.Copy(sourceFile, destFile, true); //덮어씁니다. 날짜나 시간별로 관리를 원할 경우 저장하는 파일명을 바꿔야 합니다.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataFileBackup("backupWhenLoad");
            }
            catch (Exception execp)
            {

            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                dataFileBackup("backupWhenClose");
            }
            catch (Exception execp)
            {

            }
        }
    }
}
