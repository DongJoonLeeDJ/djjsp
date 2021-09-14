using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaBasic
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

            // 정렬합니다.
            products.Sort((a, b) =>
            {
                return a.Price.CompareTo(b.Price);
            });

            // 출력합니다.
            foreach (var item in products)
            {
                Console.WriteLine(item.Name + " : " + item.Price);
            }
        }
    }
}
