using ATM.Common;
using ATM.Control;
using ATM.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Controll
{
    class UnionController :BaseController
    {
        CarController carHandle;
        CustController custHandle;
        SellController sellHandle;

        //List<Deal<Car, Customer, Seller>> listUn;


        public UnionController(RandData rand)
        {
            this.rand = rand;
            carHandle = new CarController(rand);
            custHandle = new CustController(rand);
            sellHandle = new SellController(rand);

            listItem = new List<object>();
            //listUn = listItem.Cast<Deal<Car, Customer, Seller>>().ToList();
        }
        public UnionController(CarController carHandle, CustController custHandle, SellController sellHandle)
        {
            this.carHandle = carHandle;
            this.custHandle = custHandle;
            this.sellHandle = sellHandle;
        }

        internal CarController CarHandle { get => carHandle; set => carHandle = value; }
        internal CustController CustHandle { get => custHandle; set => custHandle = value; }
        internal SellController SellHandle { get => sellHandle; set => sellHandle = value; }
        //internal List<Deal<Car, Customer, Seller>> ListUn { get => listUn; set => listUn = value; }

        //기존꺼 수정
        public void itemViewAll()
        {
            //if(listUn.Count==0)
            //{
            //    Console.WriteLine("거래 데이터가 존재하지 않습니다");
            //    return;
            //}

            //for (int i = 0; i < listUn.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + "번");
            //    Console.WriteLine(listUn[i].ToString());
            //    //Console.WriteLine(listUn[i].ToString());
            //}
        }


        //추상
        public override void insRandData(int count)
        {
            //for (int i = 0; i < count; i++)
            //{
            //    listUn.Add(new Deal<Car, Customer, Seller>(new Car(rand.getModel(), rand.getColor(), rand.getCompany(), rand.getPrice()),
            //        new Customer(rand.getName(), rand.getAge(), rand.getTel(), rand.getAddr(), rand.getGender()),
            //        new Seller(rand.getName(), rand.getTel(), rand.getJikwi(), rand.getOffice()), DateTime.Now.ToString("yyyy년MM월dd일--") + DateTime.Now.ToString("HH:mm분:ss초"), rand.getPrice() + "500만원"));
            //}
        }

        public override void itemView()
        {
            //if (listUn.Count == 0)
            //{
            //    Console.WriteLine("거래 데이터가 존재하지 않습니다");
            //    return;
            //}

            //for (int i = 0; i < listUn.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + "번");
            //    listUn[i].dealInfo();
            //}
        }

        public override void removeAll()
        {
            //if (listUn.Count == 0)
            //{
            //    Console.WriteLine("거래 데이터가 존재하지 않습니다");
            //    return;
            //}
            //listUn.Clear();
        }

        public override void addItem(object item)
        {
            //listUn.Add(item as Deal<Car,Customer,Seller>);
        }

        public override void delItem(string item)
        {
            throw new NotImplementedException();
        }

        public override void updateItem(string[] item)
        {
            throw new NotImplementedException();
        }
    }
}
