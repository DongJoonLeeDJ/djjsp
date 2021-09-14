using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATM.Util;

namespace ATM.Common
{
    abstract class BaseController
    {
        protected RandData rand;
        protected List<Object> listItem;
        public abstract void insRandData(int count);
        public abstract void itemView();
        public abstract void removeAll();
        public abstract void addItem(Object item);
        public abstract void delItem(string item);
        public abstract void updateItem(string[] item);
    }
}
