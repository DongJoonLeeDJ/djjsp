using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    class Program
    {
        // 연습문제 12-5: 클래스 선언 부분
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        static void Main(string[] args)
        {
            // 연습문제 12-1
            List<int> input = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var outputA = from item in input
                          where item < 4
                          select item;

            // 연습문제 12-2
            var outputB = from item in input
                          where item % 4 == 1
                          select item;

            // 연습문제 12-3
            var outputC = from item in input
                          where item % 4 == 1
                          orderby item
                          select item;

            // 연습문제 12-4
            var outputD = from item in input
                          where item % 4 == 1
                          orderby item descending
                          select item;

            // 연습문제 12-5: Linq 부분
            List<Product> products = new List<Product>()
            {
                new Product() { Name ="고구마", Price = 1500 },
                new Product() { Name ="사과", Price = 2400 },
                new Product() { Name ="바나나", Price = 1000 },
                new Product() { Name ="배", Price = 3000 },
            };
            var outputE = from item in products
                          orderby item.Name
                          select item;

            var outputF = from item in products
                          where item.Price < 2000
                          orderby item.Price
                          select item;

            var outputG = from item in products
                          where item.Price < 2000
                          orderby item.Price descending
                          select item;
        }
    }
}
