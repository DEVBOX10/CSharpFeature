using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-pattern-matching.aspx
    /// </summary>
    class CS8_200_RecursivePattern
    {
        IEnumerable<string> GetStudents(List<Person> people)
        {
            foreach (var p in people)
            {
                // Recursive pattern (재귀 패턴)
                if (p is Student { Graduated: false, Name: string name })
                {
                    yield return name;
                }
            }
        }
    }

    class Person
    {
    }

    class Student : Person
    {
        public bool Graduated { get; set; }
        public string Name { get; set; }
    }
}
