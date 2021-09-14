using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Text = "도서 관리";

            dataGridView_book.DataSource = DataManager.Books;
            
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                if(DataManager.Books.Exists((x) => x.Isbn == textBox_isbn.Text))
                {
                    MessageBox.Show("이미 존재하는 도서입니다.");
                }
                else
                {
                    Book book = new Book()
                    {
                        Isbn = textBox_isbn.Text,
                        Name = textBox_bookName.Text,
                        Publisher = textBox_publisher.Text,
                        Page = int.Parse(textBox_page.Text)
                    };
                    DataManager.Books.Add(book);

                    dataGridView_book.DataSource = null;
                    dataGridView_book.DataSource = DataManager.Books;
                    DataManager.Save();
                }
            }
            catch(Exception exception)
            {

            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                book.Name = textBox_bookName.Text;
                book.Publisher = textBox_publisher.Text;
                book.Page = int.Parse(textBox_page.Text);

                dataGridView_book.DataSource = null;
                dataGridView_book.DataSource = DataManager.Books;
                DataManager.Save();
            }
            catch(Exception)
            {
                MessageBox.Show("존재하지 않는 도서입니다.");
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = DataManager.Books.Single((x) => x.Isbn == textBox_isbn.Text);
                DataManager.Books.Remove(book);

                dataGridView_book.DataSource = null;
                dataGridView_book.DataSource = DataManager.Books;
                DataManager.Save();
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
                Book book = dataGridView_book.CurrentRow.DataBoundItem as Book;
                textBox_isbn.Text = book.Isbn;
                textBox_bookName.Text = book.Name;
                textBox_publisher.Text = book.Publisher;
                textBox_page.Text = book.Page.ToString();

            }
            catch(Exception eee)
            {

            }

        }
    }
}
