using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //https://sosobaba.tistory.com/265   //C# 탭
            DataManager.Load_Students();
            dataGridView_Students.DataSource = DataManager.Students;
            DataManager.Load_Majors();
            dataGridView_major.DataSource = DataManager.Majors;

            textBox_name.Text = DataManager.Students[0].mName;
            textBox_id.Text = DataManager.Students[0].mId;
            textBox_score.Text = DataManager.Students[0].mScore.ToString();
            textBox_grade.Text = DataManager.Students[0].mGrade.ToString();

            textBox_major_name.Text = DataManager.Majors[0].mMajorName;
            textBox_major_code.Text = DataManager.Majors[0].mMajorCode;
        }

        private void dataGridView_Students_CurrentCellChanged(object sender, EventArgs e)
        {

            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Student student = dataGridView_Students.CurrentRow.DataBoundItem as Student;

                textBox_name.Text = student.mName;
                textBox_id.Text = student.mId;
                textBox_score.Text = student.mScore.ToString();
                textBox_grade.Text = student.mGrade.ToString();
            }
            catch(Exception Except)
            {

            }
        }

        private void dataGridView_major_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // 그리드의 셀이 선택되면 텍스트박스에 글자 지정
                Major major = dataGridView_major.CurrentRow.DataBoundItem as Major;
                textBox_major_name.Text = major.mMajorName;
                textBox_major_code.Text = major.mMajorCode;
            }
            catch (Exception Except)
            {

            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if(textBox_name.Text.Trim() != "" && textBox_id.Text.Trim() != "" 
              && textBox_score.Text.Trim() != "" && textBox_grade.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Students)
                {
                    if(item.mId == textBox_id.Text)
                    {
                        isDuplicate = true; 
                        break;
                    }
                }
                if(isDuplicate)
                {
                    MessageBox.Show("해당 학번의 학생 정보는 이미 존재합니다.");
                }
                else
                {
                    try
                    {
                        Student temp = new Student();
                        temp.mName = textBox_name.Text;
                        temp.mId = textBox_id.Text;
                        double tempScore = 0.0;
                        double.TryParse(textBox_score.Text, out tempScore);
                        temp.mScore = tempScore;
                        temp.mGrade = int.Parse(textBox_grade.Text);
                        temp.RegDate = DateTime.Now;
                        DataManager.Students.Add(temp);
                        DataManager.PrintLog($"{textBox_id.Text} 학생 추가 완료");
                        dataGridView_Students.DataSource = null;
                        dataGridView_Students.DataSource = DataManager.Students;
                        DataManager.Save_Students();

                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("누락된 학생 정보가 있습니다.");
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {

            if (textBox_id.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Students)
                {
                    if (item.mId == textBox_id.Text)
                    {
                        isDuplicate = true;
                        DataManager.Students.Remove(item);
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 학생의 정보가 존재하지 않습니다.");
                }
                else
                {

                    try
                    {
                        DataManager.PrintLog($"{textBox_id.Text} 학생 정보 제거 완료");
                        dataGridView_Students.DataSource = null;
                        dataGridView_Students.DataSource = DataManager.Students;
                        DataManager.Save_Students();

                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("학번 부분이 공백입니다.");
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text.Trim() != "" && textBox_id.Text.Trim() != ""
              && textBox_score.Text.Trim() != "" && textBox_grade.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Students)
                {
                    if (item.mId == textBox_id.Text)
                    {
                        item.mName = textBox_name.Text;
                        double.TryParse(textBox_score.Text, out double tempScore);
                        item.mScore = tempScore;
                        int.TryParse(textBox_grade.Text, out int tempGrade);
                        item.mGrade = tempGrade;
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("(수정)해당 학생의 정보가 존재하지 않습니다.");
                }
                else
                {
                    try
                    {
                        DataManager.PrintLog($"{textBox_id.Text} 학생 수정 완료");
                        dataGridView_Students.DataSource = null;
                        dataGridView_Students.DataSource = DataManager.Students;
                        DataManager.Save_Students();

                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("(수정)누락된 학생 정보가 있습니다.");
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Students)
                {
                    if (item.mId == textBox_id.Text)
                    {
                        string format = $"학번이 {item.mId}인 분의 정보입니다.{Environment.NewLine}" +
                            $"이름 : {item.mName}" + Environment.NewLine +
                            $"학점 : {item.mScore}" + Environment.NewLine +
                            $"학년 : {item.mGrade}";
                        MessageBox.Show(format);
                        DataManager.PrintLog(format);
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 학생의 정보가 존재하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("(조회)학번 부분이 공백입니다.");
            }
        }

        private void button_add_major_Click(object sender, EventArgs e)
        {
            if (textBox_major_name.Text.Trim() != "" && textBox_major_code.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Majors)
                {
                    if (item.mMajorCode == textBox_major_code.Text)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    MessageBox.Show("해당 학과 정보는 이미 존재합니다.");
                }
                else
                {
                    try
                    {
                        Major temp = new Major();
                        temp.mMajorName = textBox_major_name.Text;
                        temp.mMajorCode = textBox_major_code.Text;
                        DataManager.Majors.Add(temp);
                        DataManager.PrintLog($"{textBox_major_code.Text} 학과 추가 완료");
                        dataGridView_major.DataSource = null;
                        dataGridView_major.DataSource = DataManager.Majors;
                        DataManager.Save_Majors();

                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("누락된 학과 정보가 있습니다.");
            }
        }

        private void button_modify_major_Click(object sender, EventArgs e)
        {
            if (textBox_major_name.Text.Trim() != "" && textBox_major_code.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Majors)
                {
                    if (item.mMajorCode == textBox_major_code.Text)
                    {
                        item.mMajorName = textBox_major_name.Text;
                        item.mMajorCode = textBox_major_code.Text;
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 학과 정보는 이미 존재합니다.");
                }
                else
                {
                    try
                    {
                        DataManager.PrintLog($"{textBox_major_code.Text} 학과 수정 완료");
                        dataGridView_major.DataSource = null;
                        dataGridView_major.DataSource = DataManager.Majors;
                        DataManager.Save_Majors();
                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("누락된 학과 정보가 있습니다.");
            }
        }

        private void button_del_major_Click(object sender, EventArgs e)
        {

            if (textBox_major_code.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Majors)
                {
                    if (item.mMajorCode == textBox_major_code.Text)
                    {
                        isDuplicate = true;
                        DataManager.Majors.Remove(item);
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 학과의 정보가 존재하지 않습니다.");
                }
                else
                {

                    try
                    {
                        DataManager.PrintLog($"{textBox_major_code.Text} 학과 정보 제거 완료");
                        dataGridView_major.DataSource = null;
                        dataGridView_major.DataSource = DataManager.Majors;
                        DataManager.Save_Majors();

                    }
                    catch (Exception except)
                    {
                        MessageBox.Show(except.Message);
                        DataManager.PrintLog(except.Message);
                        DataManager.PrintLog(except.StackTrace);
                    }
                }
            }
            else
            {
                MessageBox.Show("학과코드 부분이 공백입니다.");
            }
        }

        private void button_select_major_Click(object sender, EventArgs e)
        {
            if (textBox_major_code.Text.Trim() != "")
            {
                bool isDuplicate = false;
                foreach (var item in DataManager.Majors)
                {
                    if (item.mMajorCode == textBox_major_code.Text)
                    {
                        string format = $"학과코드가 {item.mMajorCode}인 학과의 정보입니다.{Environment.NewLine}" +
                            $"학과명 : {item.mMajorName}";
                        MessageBox.Show(format);
                        DataManager.PrintLog(format);
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate == false)
                {
                    MessageBox.Show("해당 학과의 정보가 존재하지 않습니다.");
                }
            }
            else
            {
                MessageBox.Show("(조회)학과코드 부분이 공백입니다.");
            }
        }
    }
}
