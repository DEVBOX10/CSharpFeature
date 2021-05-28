using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 구조체 읽기 전용 멤버 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-readonly-member.aspx
    /// </summary>
    class CS8_800_StructReadonlyMember
    {
        static void Test()
        {
            Triangle t = new Triangle(3, 4, 5);
            Check(t);
        }

        private static void Check(in Triangle tri)
        {
            int perim = tri.Perimeter;
            bool equi = tri.IsEquilateral;

            Console.WriteLine($"{perim}, {equi}");
        }
    }

    public struct Triangle
    {
        public int a, b, c;

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Perimeter => a + b + c;
        public bool IsEquilateral => a == b && b == c;
    }
}
