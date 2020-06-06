using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace CS7
{
    /// <summary>
    /// C# 6.0 에서 Expression-bodied 함수가 처음 소개되었을 때, 이 기능은 메서드, 속성, 인덱서, Operator 에만 적용할 수 있었다. C# 7.0 에서는 이를 보다 많은 클래스 멤버들에 확대 적용할 수 있게 되었다.

    /// C# 7.0 에선 생성자(Constructor), Finalizer (Destructor), 속성이나 인덱서의 accessor (getter/setter), 이벤트 accessor 들에 Expression-bodied 함수를 사용할 수 있게 되었다.
    /// </summary>
    class CS7_900_ExpressionBodiedMember
    {
    }


    class Employee
    {
        private int id;
        private string[] tags = new string[10];

        // 생성자
        public Employee(int id) => this.id = id;

        // Finalizer
        ~Employee() => Debug.Write("~Employee()");

        // 속성 accessor (getter/setter)
        public int Id
        {
            get => this.id;   // getter
            set => this.id = value > 0 ? value : 0;  // setter
        }

        // 인덱서 accessor (getter/setter)
        public string this[int index]
        {
            // 타당성 체크 생략
            get => tags[index];
            set => tags[index] = value;
        }

        // 이벤트 accessor
        private EventHandler notified;
        public event EventHandler Notified
        {
            add => this.notified += value;
            remove => this.notified -= value;
        }
    }
}
