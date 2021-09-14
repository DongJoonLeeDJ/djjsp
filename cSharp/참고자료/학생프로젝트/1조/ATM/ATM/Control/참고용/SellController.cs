using ATM.Common;
using ATM.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Controll
{
    class SellController : BaseController
    {
        //List<Seller> listSel;

        //internal List<Seller> ListSel { get => listSel; set => listSel = value; }

        public SellController(RandData rand)
        {
            listItem = new List<object>();
            //listSel = listItem.Cast<Seller>().ToList();
            this.rand = rand;
        }


        //추상
        public override void insRandData(int count)
        {
            //for (int i = 0; i < count; i++)
            //{
            //    listSel.Add(new Seller(rand.getName(), rand.getTel(), rand.getJikwi(), rand.getOffice()));
            //}
        }

        public override void itemView()
        {
            //for (int i = 0; i < listSel.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + "번");
            //    listSel[i].printInfo();
            //}
        }

        public override void removeAll()
        {
            //listSel.Clear();
        }

        public override void addItem(object item)
        {
            //listSel.Add(item as Seller);
        }

        public override void delItem(string item)
        {
            //for (int i = 0; i < listSel.Count; i++)
            //{
            //    if (listSel[i].Name.Equals(item))
            //    {
            //        listSel.RemoveAt(i--);
            //    }
            //}
        }

        public override void updateItem(string[] item)
        {
            //for (int i = 0; i < listSel.Count; i++)
            //{
            //    if (listSel[i].Name.Equals(item[CommMenu.OLD_MODEL]))
            //    {
            //        listSel[i].Name = item[CommMenu.NEW_MODEL];
            //    }
            //}
        }
    }
}
