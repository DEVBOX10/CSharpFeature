using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
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
