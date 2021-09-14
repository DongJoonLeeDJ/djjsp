using ATM.Common;
using ATM.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM.Controll
{
    class CustController : BaseController
    {
        //List<Customer> listCust;

        //internal List<Customer> ListCust { get => listCust; set => listCust = value; }

        public CustController(RandData rand)
        {
            listItem = new List<object>();
            //listCust = listItem.Cast<Customer>().ToList();
            this.rand = rand;
        }


        //여기서부터 추상
        public override void insRandData(int count)
        {
            //for (int i = 0; i < count; i++)
            //{
            //    listCust.Add(new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getAddr(), rand.getGender()));
            //}
        }

        public override void itemView()
        {
            //for (int i = 0; i < listCust.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + "번");
            //    listCust[i].CustomerInfo();
            //}
        }

        public override void removeAll()
        {
            //listCust.Clear();
        }

        public override void addItem(object item)
        {
            //listCust.Add(item as Customer);
        }

        public override void delItem(string item)
        {
            //for (int i = 0; i < listCust.Count; i++)
            //{
            //    if (listCust[i].Name.Equals(item))
            //    {
            //        listCust.RemoveAt(i--);
            //    }
            //}
        }

        public override void updateItem(string[] item)
        {
            //for (int i = 0; i < listCust.Count; i++)
            //{
            //    if (listCust[i].Name.Equals(item[CommMenu.OLD_MODEL]))
            //    {
            //        listCust[i].Name = item[CommMenu.NEW_MODEL];
            //    }
            //}
        }
    }
}
