using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace teamProject
{
    public partial class DrugCompInfo_Form : Form
    {
        public DrugCompInfo_Form()
        {
            InitializeComponent();
        }

        private void DrugCompInfo_Form_Load(object sender, EventArgs e)
        {
            drugComp_dtGridView.DataSource = DataManager_comp.Comps;
            DataManager_comp.Save();
        }

        private void btn_DrugComp_Add_Click(object sender, EventArgs e)
        {
            DataManager_comp.Comps.Add(new Entp(compName_txtBox.Text, compTel_txtBox.Text, compAddr_txtBox.Text, compEmail_txtBox.Text));
            resetList();
            MessageBox.Show("추가되었습니다.", "추가 완료");
            compName_txtBox.Text = "";
            compTel_txtBox.Text = "";
            compAddr_txtBox.Text = "";
            compEmail_txtBox.Text = "";
        }

        private void drugComp_dtGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Entp temp = drugComp_dtGridView.CurrentRow.DataBoundItem as Entp; // Entp를 형변환 시켜서 drugComp_dtGridView의 선택된 셀에 넣음
                compName_txtBox.Text = temp.entpName;
                compTel_txtBox.Text = temp.entpTel;
                compAddr_txtBox.Text = temp.entpAddr;
                compEmail_txtBox.Text = temp.entpEmail;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void btn_DrugComp_Edit_Click(object sender, EventArgs e)
        {
            int n = drugComp_dtGridView.CurrentCell.RowIndex; // 선택된 리스트 저장
            //MessageBox.Show(n.ToString());
            DataManager_comp.Comps[n].entpName = compName_txtBox.Text;
            DataManager_comp.Comps[n].entpTel = compTel_txtBox.Text;
            DataManager_comp.Comps[n].entpAddr = compAddr_txtBox.Text;
            DataManager_comp.Comps[n].entpEmail = compEmail_txtBox.Text;
            resetList();
        }

        private void resetList()
        {
            DataManager_comp.Save();
            drugComp_dtGridView.DataSource = null;
            drugComp_dtGridView.DataSource = DataManager_comp.Comps;
        }

        private void btn_DrugComp_Del_Click(object sender, EventArgs e)
        {
            int n = drugComp_dtGridView.CurrentCell.RowIndex;
            DataManager_comp.Comps.RemoveAt(n);
            resetList();
        }
        
        private void searchName()
        {
            if (compId_txtBox.Text.Trim() == "")
            {
                MessageBox.Show("제약회사 이름을 입력해 주세요!");
                //함수 종료
                return;
            }
            System.Collections.Generic.List<Entp> tempComps = new List<Entp>();
            drugComp_dtGridView.DataSource = null;
            try
            {
                for (int i = 0; i < DataManager_comp.Comps.Count; i++)
                {
                    if (DataManager_comp.Comps[i].entpName.Contains(compId_txtBox.Text))
                    {
                        tempComps.Add(DataManager_comp.Comps[i]); // 밑의 네줄 한줄로 요약
                        //drugComp_dtGridView.DataSource = DataManager_comp.Comps[0].entpName;
                        //drugComp_dtGridView.DataSource = DataManager_comp.Comps[0].entpTel;
                        //drugComp_dtGridView.DataSource = DataManager_comp.Comps[0].entpAddr;
                        //drugComp_dtGridView.DataSource = DataManager_comp.Comps[0].entpEmail;
                    }
                }
                drugComp_dtGridView.DataSource = tempComps;
            }
            catch (Exception ex)
            {
                MessageBox.Show("조회 안됨");
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DrugComp_Search_Click(object sender, EventArgs e)
        {
            searchName();
        }

        private void compId_txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            KeyPreview = true;
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    searchName();
                    break;
            }
        }
    }
}

