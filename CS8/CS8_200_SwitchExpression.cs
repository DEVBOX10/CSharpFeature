using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
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
