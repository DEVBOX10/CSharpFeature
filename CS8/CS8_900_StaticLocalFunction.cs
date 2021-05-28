using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 기타 기능들 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-misc.aspx
    /// </summary>
    class CS8_900_StaticLocalFunction
    {
        private void Run1()
        {
            double r = 1.0;
            PrintArea();

            // non-static local function
            void PrintArea()
            {
                // 외부의 r 변수를 사용
                var area = Math.PI * r * r;
                Console.WriteLine(area);
            }

            r = 2.0;
            PrintArea();
        }

        private void Run2()
        {
            double r = 1.0;
            PrintArea(r);

            // static local function
            static void PrintArea(double radius)
            {
                // 외부 변수 사용 못하고
                // 입력 파라미터 사용
                var area = Math.PI * radius * radius;
                Console.WriteLine(area);
            }

            PrintArea(2.0);
        }
    }
}
