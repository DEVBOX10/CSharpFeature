using System;
using System.Collections.Generic;
using System.Text;

namespace CS6
{
    /// <summary>
    /// C# 6.0 문자열 내삽 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/CS6/CSharp-string-interpolation.aspx
    /// </summary>
    public static class CS6_200_StringInterpolation
    {
        public static void Test()
        {
            Rectangle r = new Rectangle();
            r.Height = 10;
            r.Width = 32;

            // Format string 앞에 $ 를 붙인다
            // {} 안에 속성 혹은 계산식 등을 넣을 수 있다.
            string s = $"{r.Height} x {r.Width} = {(r.Height * r.Width)}";
            Console.WriteLine(s);
        }
    }


    class Shape { }
    class Line : Shape { }
    class Circle : Shape
    {
        private int _radius;

        /// <summary>
        /// Feature 'expression body constructor and destructor' is not available in C# 6. Please use language version 7.0 or greater.
        /// </summary>
        /// <param name="radius"></param>
        //public Circle(int radius) => _radius = radius;

        public int Radius { get; set; }
    }

    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
