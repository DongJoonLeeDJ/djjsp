using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyObserverPattern
{
    public interface ISubject
    {
        void subscribe(IObserver o); //관찰자 추가
        void remove(IObserver o); //관찰자 제거
        void notify(); //관찰자들(옵저버들)에게 일괄통지할 함수
    }
}
