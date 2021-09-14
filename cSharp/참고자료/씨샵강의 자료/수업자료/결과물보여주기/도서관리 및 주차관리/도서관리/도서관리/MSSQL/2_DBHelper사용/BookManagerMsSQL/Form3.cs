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
    public partial class Form3 : Form
    {
        enum enumUser
        {
            UserId, UserName
        }

        public Form3()
        {
            InitializeComponent();
            Text = "사용자관리";

            selectQuery();

            //=> 람다 
            button_Add.Click += (sender, e) =>
            {
                try
                {
                    int.TryParse(textBox_ID.Text, out int id);
                    if (id <= 0)
                    {
                        MessageBox.Show("Id 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    //해당 id 데이터가 존재하는지 체크(중복유저체크)
                    selectQuery(id);

                    if (DBHelper.dt_user.Rows.Count > 0)
                    {
                        MessageBox.Show("이미 등록된 사용자입니다.");
                    }
                    else
                    {
                        insertQuery();
                        selectQuery();
                    }
                }
                catch (Exception)
                {

                }
            };

            button_Modify.Click += (sender, e) =>
            {
                try
                {

                    int.TryParse(textBox_ID.Text, out int id);
                    if (id <= 0)
                    {
                        MessageBox.Show("Id 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    //해당 id 데이터가 존재하는지 체크(중복유저체크)
                    selectQuery(id);

                    if (DBHelper.dt_user.Rows.Count == 0)
                    {
                        MessageBox.Show("등록되지 않은 사용자입니다.");
                    }
                    else
                    {
                        //BookTable의 UserName도 UserTable 값에 맞추기
                        updateQuery_Book();

                        //설정한 이름으로 변경
                        updateQuery_User();

                        selectQuery();
                    }
                }
                catch (Exception exception)
                {

                }
            };

            button_Delete.Click += (sender, e) =>
            {
                try
                {
                    int.TryParse(textBox_ID.Text, out int id);
                    if (id <= 0)
                    {
                        MessageBox.Show("Id 값이 잘못되었습니다. 0 이상의 숫자를 입력하여 주십시오.");
                        return;
                    }
                    //해당 id 데이터가 존재하는지 체크(중복유저체크)
                    selectQuery(id);

                    if (DBHelper.dt_user.Rows.Count == 0)
                    {
                        MessageBox.Show("등록되지 않은 사용자입니다.");
                    }
                    else
                    {
                        bool isRemove = true;
                        updateQuery_Book(isRemove);
                        deleteQuery();
                        selectQuery();
                    }
                }
                catch (Exception)
                {
                }
            };

        }

        private void selectQuery(int id = -1)
        {
            if (id < 0)
            {
                DBHelper.selectQuery_User();
                dataGridView_Users.DataSource = DBHelper.ds;
                dataGridView_Users.DataMember = "UserTable";

            }
            else
            {
                DBHelper.selectQuery_User(id);
            }
        }

        private void insertQuery()
        {

            try
            {
                DBHelper.insertQuery_User_UserForm(textBox_ID.Text, textBox_Name.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
            }
        }

        private void updateQuery_Book(bool isRemove = false)
        {
            try
            {
                DBHelper.updateQuery_Book_UserForm(textBox_ID.Text, textBox_Name.Text, isRemove);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }

        private void updateQuery_User()
        {
            try
            {
                DBHelper.updateQuery_User_UserForm(textBox_Name.Text, textBox_ID.Text);
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }
        }
        private void deleteQuery()
        {
            try
            {
                DBHelper.deleteQuery_UserForm(textBox_ID.Text);
            }
            catch (Exception eee)
            {
                //MessageBox.Show(eee.Message);
            }

        }
        private void DataGridView_Users_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var user = dataGridView_Users.CurrentRow;
                textBox_ID.Text = user.Cells[(int)enumUser.UserId].Value.ToString();
                textBox_Name.Text = user.Cells[(int)enumUser.UserName].Value.ToString();
            }
            catch (Exception ee)
            {

            }
        }
    }
}
