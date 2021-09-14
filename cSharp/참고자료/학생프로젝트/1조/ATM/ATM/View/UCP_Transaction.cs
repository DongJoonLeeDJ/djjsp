using ATM.Common;
using ATM.Model;
using System;
using System.Windows.Forms;

namespace ATM.Panel
{
    public partial class UCP_Transaction : UserControl
    {
        CheckAcc ca;
        Transaction ts = new Transaction();
        Form1 parentForm;
        string bank;
        double bal;
        string acc_num;
        string name;
        public UCP_Transaction(Form1 form)
        {
            InitializeComponent();
            parentForm = form;
            this.bank = parentForm.getBank();
            this.acc_num = parentForm.getUserAccount();
            this.name = parentForm.getName();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            parentForm.HomePanel();
        }

        private void transaction_Click(object sender, EventArgs e)
        {
            //김준석
            //계좌 잔액 확인
            bal = ts.checkBal(acc_num, bank);
            // 잔액이 부족하면
            if (bal < double.Parse(money_text.Text))
            {
                MessageBox.Show("잔액 부족");
            }
            else
            {
                //송금 하기전 상대방 계좌 정보 확인
                ca = ts.checkAcc(accNum_text.Text, bankName.Text);
                if (ca.Acc_check)
                {
                    DialogResult dr = MessageBox.Show("예금주 : " + ca.Name +
                                    "\n은행 : " + ca.Bank + "\n계좌번호 : " + ca.Acc_num +
                                    "\n보낼 금액 : " + money_text.Text + "원" +
                                    "\n이 계좌로 송금 하시겠습니까?"
                                    , "알림", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (dr == DialogResult.OK)
                    {
                        //확인 누르면 송금
                        ts.transaction(acc_num, bank, name, bal, ca.Acc_num, ca.Bank, ca.Name, ca.Balance, Convert.ToInt32(money_text.Text));
                        MessageBox.Show("정상적으로 송금 되었습니다.");
                    }
                    else
                    {
                        //취소하면 송금 취소
                        MessageBox.Show("취소 하였습니다");
                    }
                }
                else
                {
                    //계좌 정보가 없으면
                    MessageBox.Show("없는 계좌정보 입니다");
                }
            }
            parentForm.HomePanel();
        }
    }
}
