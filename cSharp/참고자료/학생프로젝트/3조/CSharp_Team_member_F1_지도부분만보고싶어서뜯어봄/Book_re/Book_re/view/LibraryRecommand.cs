using Book_re.Model;
using Newtonsoft.Json.Linq;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Book_re
{
    public partial class LibraryRecommand : Form
    {
        public LibraryRecommand()
        {
            InitializeComponent();
            FillDataSource("East"); //제일 왼쪽에 있는 동구를 선택한다.
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FillDataSource(string Location)
        {
            //DBHelper.Read(Location);
            //DGV_Location.DataSource = null;
            //if (DBHelper.ds.Tables[0].Rows.Count > 0)
            //{
            //DGV_Location.DataSource = DBHelper.ds;
            //DGV_Location.DataMember = "Location";
            //}

            DGV_Location.Columns.Add("name", "지역");
            DGV_Location.Columns.Add("sNum", "이름");
            DGV_Location.Rows.Add("동구", "대구2.28기념학생도서관");
        }

        private void button_East_Click(object sender, EventArgs e)
        {

            FillDataSource("East");


        }

        private void button_West_Click(object sender, EventArgs e)
        {

            FillDataSource("West");
        }

        private void button_South_Click(object sender, EventArgs e)
        {

            FillDataSource("South");

        }

        private void button_North_Click(object sender, EventArgs e)
        {

            FillDataSource("North");

        }

        private void button_Center_Click(object sender, EventArgs e)
        {

            FillDataSource("Center");
        }

        private void button_Dal_Click(object sender, EventArgs e)
        {
            FillDataSource("Dalsu");
        }

        private void button_Dal2_Click(object sender, EventArgs e)
        {
            FillDataSource("Dalsung");
        }

        private void button_kinggod_Click(object sender, EventArgs e)
        {
            FillDataSource("Susung");

        }

        private void DGV_Location_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection temp = DGV_Location.SelectedCells;
            string location = DGV_Location[temp[0].ColumnIndex, temp[0].RowIndex].Value.ToString();
            //new Form2(location).ShowDialog();
            this.webBrowser1.Url = new System.Uri("http://ehpub.co.kr/kakaomap.html", System.UriKind.Absolute);
            
            List<MyLocale> mls = KaKaoAPI.Search(location);

            Listbox.Items.Clear();
            foreach (MyLocale locale in mls)
            {
                Listbox.Items.Add(locale);
            }



        }

        private void label_East_Click(object sender, EventArgs e)
        {

        }

        private void Listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                MyLocale ml = Listbox.SelectedItem as MyLocale;
                object[] ps = new object[] { ml.Lat, ml.Lng };
                HtmlDocument hdoc = webBrowser1.Document;
                hdoc.InvokeScript("setCenter", ps);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                //  throw;
            }

        }



        //private void Select_Location_Show_Libraries(object sender, EventArgs e)
        //{
        //    string LocationName = (sender as Label).Name.Replace("label_", "");
        //    DGV_Location.DataSource = null;
        //    DBHelper.
        //    if(DBHelper.ds.Tables[0].Rows.Count >0)
        //    {

        //    }
        //}
    }
}
