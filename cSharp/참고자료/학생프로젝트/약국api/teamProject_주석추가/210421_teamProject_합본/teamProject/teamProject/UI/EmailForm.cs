using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teamProject.model;

namespace teamProject.UI
{
    partial class EmailForm : Form
    {
        Email mail = new Email("본인메일주소");
        DrugOrder order; 

        public EmailForm(DrugOrder order)
        {
            InitializeComponent();
            this.order = order;
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            string toAddress = this.toAddress_textBox.Text;
            string subject = this.subject_textBox.Text;
            string body = this.body_textBox.Text;
            if (toAddress=="")
            {
                MessageBox.Show("받을 메일을 입력해 주세요!");
            }
            if (subject=="")
            {
                MessageBox.Show("메일 제목을 입력해주세요");
            }
            if (body=="")
            {
                MessageBox.Show("메일 내용을 입력해 주세요");
            }
            mail.SetToAddress(toAddress);
            MessageBox.Show(mail.SendEmail(subject,body));
        }

        private void EmailForm_Load(object sender, EventArgs e)
        {
            toAddress_textBox.Text = order.entp.entpEmail;
            subject_textBox.Text = order.drug.MedName;
            body_textBox.Text = order.count.ToString();
        }
    }
}
