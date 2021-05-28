using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-pattern-matching.aspx
    /// </summary>
    class CS8_200_ProperyPattern
    {
        public decimal CalcFee(Customer cust)
        {
            // Property Pattern (속성 패턴)
            decimal fee = cust switch
            {
                { IsSenior: true } => 10,
                { IsVeteran: true } => 12,
                { Level: "VIP" } => 5,
                { Level: "A", IsMinor: false } => 10,
                _ => 20
            };
            return fee;
        }
    }


    class Customer
    {
        public bool IsSenior { get; set; }
        public bool IsVeteran { get; set; }
        public bool IsMinor { get; set; }
        public string Level { get; set; }
    }
}
