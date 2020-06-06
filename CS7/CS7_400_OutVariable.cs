using System;
using System.Collections.Generic;
using System.Text;

namespace CS7
{
    class CS7_400_OutVariable
    {
        void Test()
        {
            // 이전 방식
            //int x, y;   // 미리 선언해야
            //GetXY(out x, out y);

            // C# 7 간편해진 out 파라미터
            GetXY(out int x, out int y);

            // 여기서 x, y 를 사용할 수 있다.
            Console.WriteLine($"{x},{y}");


            // out var 를 사용한 표현
            //GetXY(out var x, out var y);

            // 필요없는 out 파라미터에 _ 사용
            GetXY(out var i, out _);
        }

        void GetXY(out int x, out int y)
        {
            x = 5;
            y = 10;
        }

        void GetXY(out int i)
        {
            i = 5;
        }
    }
}
