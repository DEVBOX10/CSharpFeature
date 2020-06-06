using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Text;

namespace CS6
{
    class CS6_A00_ExpresionBodiedMember
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        string data = "";


        // 기존의 속성
        public int Area
        {
            get
            {
                return Height * Width;
            }
        }

        // C# 6.0의 Expression-bodied member 표현
        public int Area2 => Height * Width;


        // 메서드에서 하나의 Point 객체 리턴
        public Point Move(int x, int y) => new Point(X + x, Y + y);

        // 메서드에서 void 리턴
        public void Print() => Console.WriteLine(data);

        // 속성에서 get 리턴
        public string Name => FirstName + " " + LastName;

        // 인덱서에서 Customer 객체 리턴
        //public Customer this[int id] => db.FindCustomer(id);


        //TODO: One of the parameters of a binary operator must be the containing type

        // 연산자 메서드 표현 (+)
        //public static Complex operator +(Complex a, Complex b) => a + b;
    }
}
