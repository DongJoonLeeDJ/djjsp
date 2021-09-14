using System;
using ATM.Common;
using ATM.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UCP_Transaction_history : UserControl
    {
        Transaction ts = new Transaction();
        List<TsHistory> list = new List<TsHistory>();
        string bank;
        string name;
        string acc_num;

        Form1 parentForm;
        public UCP_Transaction_history(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            this.name = parentForm.getName();
            this.bank = parentForm.getBank();
            this.acc_num = parentForm.getUserAccount();
                       
            Name_label.Text = name+" 님의 거래 내역";
            //김준석
            //거래 내역 조회 해서 데이터 그리드에 출력
            dataGridView1.DataSource = ts.TsHistory(acc_num, bank); ;
        }

        private void button_back_Click_1(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }
    }
}
