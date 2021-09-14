using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    // 코드 8-4: 인덱서 선언
    class Products
    {
        public int this[int i]
        {
            // Products products = new Product();
            // products[i] 할 때에 호출
            get { return i; }
            // products[i] = 10 할 때에 호출
            set { Console.WriteLine(i + "번째 상품 설정"); }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();
            int xeno = products[3];
            products[100] = 1;
        }
    }
}
