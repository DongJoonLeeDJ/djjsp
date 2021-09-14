using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    interface IBasic
    {
        int TestInstanceMethod();
        int TestProperty { get; set; }
    }
}
