using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace CS8
{
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
