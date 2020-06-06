using System;
using System.Collections.Generic;
using System.Text;

namespace CS6
{
    class CS6_400_NameOfExpression
    {
        void Test()
        {
            var id = "";

            // 1. 파마미터명 id (Hard coding 하지 않음)
            throw new ArgumentException("Invalid argument", nameof(id));


            var person = new Person("test");

            // 2. 속성명을 nameof 로 추출
            Console.WriteLine("{0}: {1}", nameof(person.Height), person.Height);

            
        }

        // 3. 메서드명 로깅에 추가
        void Run()
        {
            Console.WriteLine(nameof(Run) + " : Started");
        }
    }


    class Person
    {
        private string _name;
        public Person(string name)
        {
            _name = name;
        }

        public int Height { get; set; }
    }
}
