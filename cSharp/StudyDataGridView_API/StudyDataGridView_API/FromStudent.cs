using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyDataGridView_API
{
    public class FromStudent : Student
    {
        //상속받은 클래스에서의 메소드
        public override void Study()
        {
            base.Study(); // 조상에 있는 걸 그대로 쓰는 거
            System.Windows.Forms.MessageBox.Show("이렇게 새로운 걸 쓸 수도 있음");
        }

        //클래스 상속받을 때
        //부모 클래스의 생성자에 매개변수 필요하다면
        //자식 클래스에서도 아래와 명시해 줘야한다.
        public FromStudent(string name, int age, string hakbeon) : base(name, age, hakbeon)
        {

        }

    }
}
