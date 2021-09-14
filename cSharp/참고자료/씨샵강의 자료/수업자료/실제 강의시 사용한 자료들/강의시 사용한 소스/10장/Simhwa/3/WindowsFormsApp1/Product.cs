using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Product
    {
        public string name { get; set; } //get; set;을 해줘야 data바인딩할 때 데이터그리드뷰에서는 미리보기가 재공된다. 그리고 다른 컨트롤의 경우에는 "멤머 표시", "값 멤버"에 name과 price가 나타난다.
        public int price { get; set; }
    }
}
