using System;

/// <summary>
/// C# 9 향상된 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-pattern-match.aspx
/// 
/// C# 9에서는 switch 식에서 >, <, >=, <=; 등과 같은 관계 연산자를 사용할 수 있는 기능이 추가되었다. 
/// 아래 예제에서 GetGrade() 메서드의 switch 식은 score의 범위에 따라 A-F 학점을 리턴하고 있다. 
/// 여기서 각 점수의 범위를 부등식을 사용하여 지정하고 있는데, 이것이 관계 연산자 패턴이다.
/// </summary>
class CS9_300_Pattern_Relational
{
    static void Test()
    {
        char g = GetGrade(75);
        Console.WriteLine(g);
    }


    static char GetGrade(int score)
    {
        // 관계 패턴
        char gr = score switch
        {
            >= 90 => 'A',
            >= 80 => 'B',
            >= 70 => 'C',
            >= 60 => 'D',
            _ => 'F'
        };

        return gr;
    }
}

