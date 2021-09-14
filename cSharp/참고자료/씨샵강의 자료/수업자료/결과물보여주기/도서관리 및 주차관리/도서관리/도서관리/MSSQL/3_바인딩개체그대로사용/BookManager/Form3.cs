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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Text = "사용자관리";

            dataGridView_Users.DataSource = DataManager.Users;
            dataGridView_Users.CurrentCellChanged += DataGridView_Users_CurrentCellChanged;

            //=> 람다 
            button_Add.Click += (sender, e) =>
            {
                try 
                {
                    if(DataManager.Users.Exists((x) => x.Id == int.Parse(textBox_ID.Text)))
                    {
                        MessageBox.Show("사용자 ID가 겹칩니다.");
                    }
                    else
                    {
                        User user = new User()
                        {
                            Id = int.Parse(textBox_ID.Text),
                            Name = textBox_Name.Text
                        };
                        DataManager.Users.Add(user);

                        dataGridView_Users.DataSource = null;
                        dataGridView_Users.DataSource = DataManager.Users;
                        DataManager.Save();
                    }
                }
                catch(Exception)
                {

                }
            };

            button_Modify.Click += (sender, e) =>
            {
                try
                {
                    User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox_ID.Text));
                    user.Name = textBox_Name.Text;

                    try
                    {
                        Book book = DataManager.Books.Single((x) => x.UserId == int.Parse(textBox_ID.Text));
                        book.UserName = textBox_Name.Text;
                    }
                    catch(Exception)
                    {

                    }

                    dataGridView_Users.DataSource = null;
                    dataGridView_Users.DataSource = DataManager.Users;
                    DataManager.Save();
                }
                catch(Exception exception)
                {
                    MessageBox.Show("존재하지 않는 사용자입니다." + Environment.NewLine +
                                     exception.GetType() + Environment.NewLine +
                                     exception.Message + Environment.NewLine +
                                     exception.StackTrace);
                    
                }
            };

            button_Delete.Click += (sender, e) => 
            {
                try
                {
                    User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox_ID.Text));
                    DataManager.Users.Remove(user);

                    try
                    {
                        Book book = DataManager.Books.Single((x) => x.UserId == int.Parse(textBox_ID.Text));
                        book.UserName = "";
                        book.UserId = null;
                        book.isBorrowed = false;
                    }
                    catch (Exception)
                    {

                    }

                    dataGridView_Users.DataSource = null;
                    dataGridView_Users.DataSource = DataManager.Users;
                    DataManager.Save();

                }
                catch(Exception)
                {
                    MessageBox.Show("존재하지 않는 사용자입니다.");
                }
            };

        }

        private void DataGridView_Users_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                User user = dataGridView_Users.CurrentRow.DataBoundItem as User;
                textBox_ID.Text = user.Id.ToString();
                textBox_Name.Text = user.Name;
            }
            catch (Exception ee)
            {

            }
        }
    }
}
