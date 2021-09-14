using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using teamProject.model;

namespace teamProject
{
    partial class MainDrugs : Form
    {
        public MainDrugs()
        {
            InitializeComponent();
            //comboBox1.Text = "검색기준";
            comboBox1.SelectedIndex = 0;
        }

        private void MainDrugs_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataManager.drugs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //as 변환되면 null 값 반환, is 같지 않으면 false를 반환
            Drug drug1 = dataGridView1.CurrentRow.DataBoundItem as Drug;
            textBox2.Text = drug1.MedName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;  //데이터그리드뷰 데이터 비우고
            if (checkBox1.Checked == true) //1번 눌렀을때
            {
                checkBox2.Checked = false;
                List<Drug> temp = DataManager.drugs.OrderByDescending(x => x.Stock).ToList(); //temp에 데이터 리스트 넣고 내림차순정렬
                dataGridView1.DataSource = temp;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                List<Drug> temp = DataManager.drugs.OrderBy(x => x.Stock).ToList();
                dataGridView1.DataSource = temp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null; //빈칸 만들기
            List<Drug> tempList = new List<Drug>();

            if (comboBox1.SelectedIndex == 0)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.MedName.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.MedComp.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                foreach (var item in DataManager.drugs)
                {
                    if (item.MedId.Contains(textBox1.Text))
                    {
                        tempList.Add(item);
                    }
                }
                dataGridView1.DataSource = tempList;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DrugOrderForm.orders.Count <= 0)
            {
                MessageBox.Show("물품을 먼저 담아주세요");
                return;
            }
            else
            {
                new DrugOrderForm().ShowDialog();
                resetGrid();
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                Drug orderDrug = null;
                Entp orderEntp = null;
                int ordercount = int.Parse(textBox3.Text);

                // 제품명 비교
                foreach (var item in DataManager.drugs)
                {
                    if (textBox2.Text == item.MedName)
                    {
                        orderDrug = item;
                    }                    
                }

                // 제조사 비교
                foreach (var item in DataManager_comp.Comps)
                {
                    if (orderDrug.MedComp == item.entpName)
                    {
                        orderEntp = item;
                    }
                }
                DrugOrderForm.orders.Add(new DrugOrder(orderDrug, orderEntp, ordercount)); // DrugOrderForm에 추가
                MessageBox.Show(textBox2.Text + "수량" + textBox3.Text + "개 가 주문서에 추가 되었습니다.");
            }
            
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("수량을 입력해주세요");
            }

            else
            {
                MessageBox.Show("약품명을 입력해주세요");
            }
        }

        public void resetGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.drugs;
        }
    }
}

