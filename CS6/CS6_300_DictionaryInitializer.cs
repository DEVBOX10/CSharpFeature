using System;
using System.Collections.Generic;
using System.Text;

namespace CS6
{
    class CS6_300_DictionaryInitializer
    {
        void Test()
        {
            // 이전의 C# 표현
            var scores = new Dictionary<string, int>()
                        {
                            { "kim", 100 },
                            { "lee",  90 }
                        };
            int sc = scores["lee"];



            //TODO: C# 6.0 표현
            var scores2 = new Dictionary<string, int>()
            {
                ["kim"] = 100,
                ["lee"] = 90
            };
            int sc2 = scores["lee"];



            //TODO: C# 6.0의 Dictionary 초기화 기능은 해시테이블, Dictionary 뿐만 아니라, 인덱서를 지원하는 모든 객체에서 사용될 수 있다.

            var A = new[] { 1, 2, 3 };

            // List는 인덱서를 지원하므로
            // Dictionary Initializer 사용 가능

            var L = new List<int>(A) { [2] = 9 };
        }
    }
}
