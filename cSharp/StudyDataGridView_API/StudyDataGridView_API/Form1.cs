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
using System.Xml.Linq;

namespace StudyDataGridView_API
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Daegu> daegus = new List<Daegu>();
        public Form1()
        {
            InitializeComponent();

            //프로그램 시작시 xml 파일 바로 읽어들이기
            //주의사항은 xml 파일 시작하자마자 공백 있으면 안 됨
            string xmlfile = File.ReadAllText("apiexample.xml");
            XElement daegusxml = XElement.Parse(xmlfile);
            foreach(var item in daegusxml.Descendants("item"))
            {
                //xml중에서도 노드값이 attractname이랑 tel인 걸 읽어옴
                //내일은 api에서 바로 뗑겨와서 뿌리는 거 알려줄게요.
                string name = item.Element("attractname").Value;
                string tel = item.Element("tel").Value;
                Daegu d = new Daegu();
                d.name = name;
                d.tel = tel;
                daegus.Add(d);
            }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = daegus;

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

        private void button_arrange_Click(object sender, EventArgs e)
        {
            students.Sort();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in students)
            {
                //MessageBox.Show($"이름:{item.name}, 나이:{item.age}, 학번:{item.hakbeon}");
                MessageBox.Show(item.ToString());
            }
        }
    }
}
