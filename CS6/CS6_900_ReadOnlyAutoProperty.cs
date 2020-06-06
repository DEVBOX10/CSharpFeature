using System;
using System.Collections.Generic;
using System.Text;

namespace CS6
{
    class CS6_900_ReadOnlyAutoProperty
    {
        void Test()
        {
            Person2 p = new Person2();
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Nickname); // null 출력
            Console.WriteLine(p.Age);   //  0 출력
        }
    }


    class Person2
    {
        public string Name { get; set; } = "(No name)";

        // 초기화 없을 경우 디폴드값 사용됨
        public string Nickname { get; }
        public int Age { get; }

        // Auto-Property Initializer 할당
        public bool Enabled { get; } = true;

        // 생성자에서 초기값 할당
        public int Level { get; }
        public Person2()
        {
            this.Level = 1;
        }
    }

}
