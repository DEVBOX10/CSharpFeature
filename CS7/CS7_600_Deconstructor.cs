using System;
using System.Collections.Generic;
using System.Text;

namespace CS7
{
    /// <summary>
    /// C# 7 에서 Deconstructor 라는 기능을 제공하고 있는데, 이는 생성자(Constructor)와 대칭적인 개념으로 파괴자(Destructor)와 혼돈하지 말아야 한다. Constructor는 보통 외부에서 입력파라미터를 받아들여 이를 필드에 저장하는 역활을 하는데, Deconstructor는 반대로 필드의 값들을 외부로 전달하는 역활을 한다. 
    /// 이는 불필요한 리소스를 제거하는 파괴자(Destructor)와 다르다.
    /// 
    /// 
    /// 클래스에서 Deconstructor를 지원하기 위해서는 아래와 같은 Deconstruct() 메서드를 추가해야 한다. 여기서 out 파라미터들의 숫자는 임의로 정할 수 있으며, 이들 out 파라미터들이 리턴되어 복수 개의 리턴 변수들에게 전달된다.
    /// 
    /// public void Deconstruct(out T1 x1, ..., out Tn xn) { ... }
    /// 
    /// 아래 예제를 보면, BasicInfo라는 클래스는 Constructor에서 3개의 입력 파라미터들을 받아들여 3개의 필드에 저장하고 있다. 
    /// 그리고 Deconstructor 즉 Deconstruct() 메서드에서는 다시 이 3개의 필드의 내용을 out 파라미터로 리턴하고 있다. 이 Deconstruct()는 var (id, name, age) = person; 와 같이 복수 값을 리턴하는 곳에서 자동으로 호출되어 해당 값들을 리턴하게 된다. 
    /// 즉, Deconstruct()의 out 파라미터들 순서대로 var 변수에 할당되는 것이다. 
    /// 이러한 점에서 Deconstructor는 Constructor와 대칭되는 기능한다고 볼 수 있다.
    /// </summary>
    class CS7_600_Deconstructor
    {
        static void Test()
        {
            BasicInfo person = new BasicInfo(1, "Lee", 10);

            // Deconstruct()가 호출되어 복수 리턴 변수들에 할당됨
            var (id, name, age) = person;

            Console.WriteLine($"{id} - {name}");
        }
    }


    class BasicInfo
    {
        private int _id;
        private string _name;
        private int _age;

        // Constructor
        public BasicInfo(int id, string name, int age)
        {
            this._id = id;
            this._name = name;
            this._age = age;
        }

        // Deconstructor
        public void Deconstruct(out int id, out string name, out int age)
        {
            id = this._id;
            name = this._name;
            age = this._age;
        }
    }
}
