using System;
using System.Collections.Generic;
using System.Text;

namespace CS7
{
    /// <summary>
    /// C# 7.0 throw expression - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS7-throw-expr.aspx
    /// </summary>
    class CS7_A00_ThrowExpression
    {
        private string _name;
        void Test(string name)
        {
            // C# 7 이전 throw 문 
            if (name == null)
            {
                throw new ArgumentException();
            }
            this._name = name;


            // C# 7.0 throw expression
            // (Null Coalescing Operator)

            this._name = name ?? throw new ArgumentException();
        }

        private int id;

        /// <summary>
        /// 다음은 Expression-bodied 멤버에서 throw expression 을 사용한 예이다.
        /// </summary>
        public int Id
        {
            get => this.id;
            set => this.id = value > 0 ? value : throw new ArgumentException();
        }
    }
}
