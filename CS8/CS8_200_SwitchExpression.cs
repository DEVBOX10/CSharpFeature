using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-pattern-matching.aspx
    /// </summary>
    public class CS8_200_SwitchExpression
    {
        static double GetArea(Shape shape)
        {
            // C# 8.0 switch expression
            double area = shape switch
            {
                null => 0,
                Line _ => 0,
                Rectangle r => r.Width * r.Height,
                Circle c => Math.PI * c.Radius * c.Radius,
                _ => throw new ArgumentException()
            };
            return area;
        }
    }

    //public enum Shape
    //{
    //    Line,
    //    Rectangle,
    //    Circle
    //}

    class Shape { }
    class Line : Shape { }
    class Circle : Shape 
    {
        public double Radius { get; set; }
    }
    class Rectangle : Shape 
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
