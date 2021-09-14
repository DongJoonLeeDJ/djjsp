using System;
using System.Collections.Generic;
using System.Windows.Forms;
using teamProject.model;

namespace teamProject
{
    partial class DrugOrderForm : Form
    {
        public static List<DrugOrder> orders = new List<DrugOrder>();
        int n;

        public DrugOrderForm()
        {
            InitializeComponent();
        }

        private void DrugOrderForm_Load(object sender, EventArgs e)
        {
            foreach (var item in orders)
            {
                drugOrder_dtGridView.Rows.Add(item.drug.MedName, item.entp.entpName, item.count); // 가지고 온 정보를 drugOrder_dtGridView에 보여줌
            }
        }

        private void btn_DrugOrder_Click(object sender, EventArgs e)
        {
            foreach (var item in orders)
            {
                new UI.EmailForm(item).ShowDialog(); // orders의 item을 EmailForm으로 넘겨주기 위해 foreach 사용
            }

            foreach (var item in orders)
            {
                foreach (var item2 in DataManager.drugs)
                {
                    if (item.drug == item2) // item의 제품명과 item2의 제품명이 일치할 때
                    {
                        item2.Stock += item.count; // 재고에 주문 수량을 더해줌
                    }
                }
            }
            DataManager.Save();
            MessageBox.Show("주문 완료!!", "주문 완료");
            Close();          
        }

        private void drugOrder_dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                n = drugOrder_dtGridView.CurrentCell.RowIndex;
                DrugOrder drugorder = orders[n];
                productName_txtBox.Text = drugorder.drug.MedName;
                ProductCnt_txtBox.Text = drugorder.count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("해당 인덱스에 값이 없습니다.");
                Console.WriteLine(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btn_DrugCntEdit_Click(object sender, EventArgs e)
        {
            drugOrder_dtGridView.Rows.Clear();
            DrugOrder temp = orders[n];
            temp.drug.MedName = productName_txtBox.Text;
            temp.count = int.Parse(ProductCnt_txtBox.Text); // int로 변환하는 이유는 재고에 더해주기 위해

            try
            {
                foreach (var item in orders)
                {
                    drugOrder_dtGridView.Rows.Add(item.drug.MedName, item.entp.entpName, item.count);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("추가 불가");
            }
        }
    }
}

