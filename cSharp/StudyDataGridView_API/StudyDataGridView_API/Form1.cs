using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyDataGridView_API
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();


        }

        private void button_add_student_Click(object sender, EventArgs e)
        {
            //int age = int.Parse(textBox_age.Text);
            //int.TryParse(textBox_age.Text, out int age);
            int age = 0;
            int.TryParse(textBox_age.Text, out age);

            students.Add(new Student(textBox_name.Text, age, textBox_hakbeon.Text));

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }
    }
}
