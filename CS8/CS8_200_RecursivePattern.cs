using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
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
