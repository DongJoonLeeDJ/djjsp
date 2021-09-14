using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyObserverPattern
{
    public interface IObserver
    {
        void update(string value);
    }
}
