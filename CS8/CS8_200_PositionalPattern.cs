using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-pattern-matching.aspx
    /// </summary>
    class CS8_200_PositionalPattern
    {
        class Point
        {
            public int X { get; }
            public int Y { get; }
            public Point(int x, int y) => (X, Y) = (x, y);
            public void Deconstruct(out int x, out int y) =>
                (x, y) = (X, Y);
        }

        static string Quadrantal(Point point)
        {
            //Positional pattern (위치 패턴)
            string quad = point switch
            {
                (0, 0) => "원점",
                var (x, y) when x > 0 && y > 0 => "1사분면",
                var (x, y) when x < 0 && y > 0 => "2사분면",
                var (x, y) when x < 0 && y < 0 => "3사분면",
                var (x, y) when x > 0 && y < 0 => "4사분면",
                var (_, _) => "X/Y축",
                _ => null
            };
            return quad;
        }

        static void Test()
        {
            var p = new Point(-5, -2);
            string q = Quadrantal(p);
            Console.WriteLine(q); // 3사분면
        }
    }
}
