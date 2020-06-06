using System;
using System.Collections.Generic;
using System.Text;

namespace CS7
{
    class CS7_100_PatternMatching
    {
        void IsOperator()
        {
            object[] data = { 1, null, 10, new Circle(5), new Person("Lee"), "" };

            foreach (var item in data)
            {
                // 패턴 찾기
            }
        }

        /// <summary>
        /// 상수 패턴(const pattern)은 특정 상수값을 사용해서 패턴을 체크하는 것이다. 예를 들어, 아래 예제의 if 조건문에서 item 이 null 인지 아니면 상수값 10 인지를 체크하고 있다. 여기서 is 연산자를 사용하고 있는데, is 뒤에 상수값을 직접 대입하여 사용하였다. 이러한 표현은 C# 7 이전에는 허용되지 않았던 표현이고, 이전 버젼에서는 대신 동등연산자 == 를 사용하였다.
        /// </summary>
        void ConstPattern()
        {
            object[] data = { 1, null, 10, new Circle(5), new Person("Lee"), "" };

            foreach (var item in data)
            {
                if (item is null)   // const pattern
                {
                    Console.WriteLine("NULL 찾았음");
                }
                else if (item is 10)  // const pattern
                {
                    Console.WriteLine("10 찾았음");
                }
            }
        }

        /// <summary>
        /// 타입 패턴(type pattern)은 어떤 객체가 해당 타입의 혹은 그 파생클래스의 객체인지, 또는 어떤 인터페이스 타입을 가지고 있는지 등을 체크하는 것으로 사실 이는 기존의 is 연산자가 제공했던 기능이다. 다만, 다른 차이점은 C# 7에서는 해당 타입에 상응하는 새로운 변수를 제공한다는 점이다.
        /// 아래 예제에서 변수 item은 object 타입인데, 이것이 Circle 객체인지 체크하면서 Circle 타입인 경우 item 객체를 Circle 타입의 객체로 변환하여 새로운 변수 circ 에 넣게 된다. 이후, 이 변수 circ는 자신을 둘러싼 블럭(enclosing block) 범위 내에서 사용될 수 있는데, 아래 예에서 보듯이 circ.Radius 와 같이 Circle 타입의 속성을 캐스팅 없이 직접 사용할 수 있다.
        /// </summary>
        void TypePattern()
        {
            object[] data = { 1, null, 10, new Circle(5), new Person("Lee"), "" };

            foreach (object item in data)
            {
                if (item is Circle circ)  // type pattern
                {
                    Console.WriteLine(circ.Radius);
                }
            }
        }


        /// <summary>
        /// 패턴매칭: switch 문
        /// 이전 C# 버전에서 switch 문은 int, string, bool 등의 기본적인 데이타 타입에서만 사용할 수 있었다. 하지만, C# 7 부터는 switch 문이 패턴 매칭을 위해 사용될 수 있게 되었다. 즉, case 문에 위에서 언급한 3가지 패턴들이 사용될 수 있는 것이다.

        /// 아래 예제에서 switch 문은 Shape 라는 클래스 객체를 받아들이고 있다.C# 7 이전에서는 이러한 클래스 객체를 switch에서 받아들일 수 없었다. switch 문의 case 에서는 상수패턴, 타입패턴, var 패턴을 사용할 수 있다. 아래 예제에서는 첫번째 case 에서 상수패턴으로 null 을 체크하였고, 두번째 ~ 네번째에서 타입패턴을 체크하고 있다. 두번째 타입패턴은 "Circle c" 로서 만약 해당 Shape 이 Circle 객체이면 변수 c 에 Circle 로 캐스팅된 객체를 넣게 되고 이를 case 블럭에서 사용할 수 있게 된다. case 블럭에서 정의된 새로운 변수는 case 블럭 안에서만 사용할 수 있다.
        /// </summary>
        /// <param name="shapes"></param>
        private void PrintArea(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                switch (shape)
                {
                    // const pattern
                    case null:
                        Console.WriteLine("Skip");
                        break;

                    // type pattern
                    case Circle c:
                        Console.WriteLine($"원: {c.Radius * c.Radius * Math.PI}");
                        break;
                    case Rectangle r when r.Width == r.Height:
                        Console.WriteLine($"정사각형: {r.Width * r.Width}");
                        break;
                    case Rectangle r2:
                        Console.WriteLine($"사각형: {r2.Width * r2.Height}");
                        break;

                    default:
                        Console.WriteLine("모르는 모양");
                        break;
                }
            }
        }


        List<int> vip = new List<int> { 1, 3, 5, 9 };
        List<int> active = new List<int> { 10, 13, 15, 19 };
        List<int> blacklist = new List<int> { 7, 14, 12, 133 };

        /// <summary>
        /// var 패턴(var pattern)은 타입패턴에서 타입 대신 var 를 쓰는 것으로, 모든 타입은 var 변수에 할당할 수 있으므로 is 연산자에서 이는 항상 참이 된다. var 패턴은 아래 switch 문에서 좀 더 자세히 설명한다.
        /// 
        /// var 패턴은 크게 쓸 용도가 없는 것처럼 보이지만, case 문에서 when 과 연동하여 유용하게 사용될 수도 있다. 아래 예제는 고객의 ID를 체크하여 어떤 종류의 고객인지 판별하는 간단한 예인데, 여기서 var 패턴을 활용하여 when 문에서 ID가 속한 그룹을 찾아내고 있다.
        /// </summary>
        /// <param name="id"></param>
        private void VarPattern(int id)
        {
            switch (id)
            {
                case var _id when (vip.Contains(_id)):
                    Console.WriteLine("VIP");
                    // VIP 
                    break;
                case var _id when (active.Contains(_id)):
                    //...
                    break;
                case var _id when (blacklist.Contains(_id)):
                    //...
                    break;
                default:
                    //...
                    break;
            }
        }
    }

    class Shape { }
    class Line : Shape { }
    class Circle : Shape
    {
        private int _radius;
        public Circle(int radius) => _radius = radius;

        public int Radius { get; set; }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    class Person
    {
        private string _name;
        public Person(string name)
        {
            _name = name;
        }
    }
}
