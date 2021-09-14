using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortWithDelegate
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        static void Main(string[] args)
        {
            // 리스트를 생성합니다.
            List<Product> products = new List<Product>()
            {
                new Product() { Name = "감자", Price = 500 },
                new Product() { Name = "사과", Price = 700 },
                new Product() { Name = "고구마", Price = 400 },
                new Product() { Name = "배추", Price = 600 },
                new Product() { Name = "상추", Price = 300 }
            };

            Comparison<Product> abc = (x, y) => x.Price.CompareTo(y.Price);
            Comparison<Product> abcd = SortWithPrice;

            // 정렬합니다.
            //products.Sort(abc);
            //products.Sort(abcd);
            //products.Sort(SortWithPrice);
            //products.Sort
            //(
            //    delegate (Product a, Product b)
            //    {
            //        return a.Price.CompareTo(b.Price);
            //    }
            //);
            //products.Sort((a,b)=> { return a.Price.CompareTo(b.Price); });
            products.Sort((a, b) => a.Price.CompareTo(b.Price));

            // 출력합니다.
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }

        }

        private static int SortWithPrice(Product x, Product y)
        {
            return x.Price.CompareTo(y.Price);
            /*
             
                 - 보다 작은	x가 y보다 작은 경우
                 0	x 가 y와 같습니다.
                 +	x 가 y이 throw됩니다.

             */
        }
    }
}
