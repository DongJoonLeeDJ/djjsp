using ATM.Common;
using ATM.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ATM.Control
{
    class CarController :BaseController
    {
        
        //List<Car> listCar;

        //internal List<Car> ListCar { get => listCar; set => listCar = value; }

        public CarController(RandData rand)
        {
            //부모 클래스에 있는 List 사용
            listItem = new List<object>();
            //listCar = listItem.Cast<Car>().ToList();
            this.rand = rand;
        }

        //여기부터
        public override void insRandData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                //listCar.Add(new Car(rand.getModel(), rand.getColor(), rand.getCompany(), rand.getPrice()));
            }
        }

        public override void itemView()
        {
            //for (int i = 0; i < listCar.Count; i++)
            //{
            //    Console.WriteLine((i + 1) + "번");
            //    listCar[i].printInfoCar();
            //}
        }

        public override void removeAll()
        {
            //listCar.Clear();
        }

        public override void addItem(object item)
        {
            //listCar.Add(item as Car);
        }

        public override void delItem(string item)
        {
            //for (int i = 0; i < listCar.Count; i++)
            //{

            //    if (listCar[i].Model.Equals(item))
            //    {
            //        listCar.RemoveAt(i--);
            //    }

            //}
        }

        public override void updateItem(string[] item)
        {
            //for (int i = 0; i < listCar.Count; i++)
            //{
            //    if (listCar[i].Model.Equals(item[CommMenu.OLD_MODEL]))
            //    {
            //        listCar[i].Model = item[CommMenu.NEW_MODEL];
            //    }
            //}
        }
    }
}
