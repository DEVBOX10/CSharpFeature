﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-pattern-matching.aspx
    /// </summary>
    class CS8_200_TuplePattern
    {
        static int GetCreditLimit(int creditScore, int debtLevel)
        {
            // Tuple Pattern (튜플 패턴)
            var credit = (creditScore, debtLevel) switch
            {
                (850, 0) => 200, //max credit score with no debt
                var (c, d) when c > 700 => 100,
                var (c, d) when c > 600 && d < 50 => 80,
                var (c, d) when c > 600 && d >= 50 => 60,
                _ => 40
            };
            return credit;
        }

        static void Test()
        {
            int creditPct = GetCreditLimit(650, 30);
            Console.WriteLine(creditPct);
        }
    }
}
