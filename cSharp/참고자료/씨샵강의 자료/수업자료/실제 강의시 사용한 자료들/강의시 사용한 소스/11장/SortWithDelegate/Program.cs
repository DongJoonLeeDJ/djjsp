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

			//정렬할 때 마다 이런 걸 매번 구현할 수 없다... 그래서 나온 것이 무명델리게이터!
            Comparison<Product> abc = (x, y) => x.Price.CompareTo(y.Price);
            Comparison<Product> abcd = SortWithPrice;
			
			//Sort() = 인터페이스 구현 필요. 내부적으로 CompareTo를 수행하되, 인터페이스이므로 사용자가 이걸 직접 구현해줘야 함
			//Sort(Comparison<Product>)은 사용자가 만들어준 CompareTo 함수를 이용하는 것.

            // 정렬합니다. (모두 동일한 동작)
			
			//1
            products.Sort(abc);
            
			//2
			products.Sort(abcd);
            
			//3
			products.Sort(SortWithPrice);
			
			//4
			products.Sort
			(
				delegate(Product a, Product b)
				{
					return a.Price.CompareTo(b.Price);
				}
			);
            
			//5
			products.Sort((a,b)=> { return a.Price.CompareTo(b.Price); });
            
			//6
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
