using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 인덱싱과 슬라이싱 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-indexing-slicing.aspx
    /// </summary>
    class CS8_400_IndexingSlicing
    {
        static void Index_Range()
        {
            string s = "Hello World";

            // System.Index
            Index idx = ^2;
            var ch = s[idx]; // l

            // System.Range
            Range r1 = 1..4;
            string str1 = s[r1]; // ell
            Index start = r1.Start;
            bool b = start.IsFromEnd; // false
            int v1 = start.Value;  // 1
            int v2 = r1.End.Value; // 4
        }

        static void Indexing_Slicing()
        {
            string s = "Hello World";

            // 인덱싱
            char ch1 = s[0];  // H
            char ch2 = s[1];  // e
            char ch3 = s[^1]; // d
            char ch4 = s[^2]; // l

            // 슬라이싱
            var s1 = s[1..4];   // ell
            var s2 = s[^5..^2]; // Wor
            var s3 = s[..];  // Hello World
            var s4 = s[..3]; // Hel
            var s5 = s[3..]; // lo World

            Range rng = 1..^0;
            var s6 = s[rng];  // ello World
        }
    }
}
