using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 널 병합 할당자 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-null-coalescing.aspx
    /// </summary>
    class CS8_700_NullCoalescingAssignment
    {
        static void Test(List<int> list)
        {
            if (list == null)
            {
                list = new List<int>();
            }
        }

        static List<int> AddData(List<int> list, int? a, int? b)
        {
            // 널 병합 연산자
            list ??= new List<int>();
            list.Add(a ??= 1);
            list.Add(b ??= 2);

            return list;
        }

        /// <summary>
        /// NULL 병합 vs NULL 병합 할당
        /// </summary>
        static void NullCoalescing()
        {
            int? a = null;

            // (1) 널 병합 연산자
            int b = a ?? 1;

            // 위 문장 실행후: a = null, b = 1


            // (2) 널 병합 할당 연산자
            a ??= 100;

            // 위 문장 실행후: a = 100
        }
    }
}
