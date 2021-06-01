/// <summary>
/// C# 9 향상된 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-pattern-match.aspx
/// 
/// C# 9에서는 switch 식에서 and, or, not 등과 같은 논리 연산자를 사용할 수 있는 기능이 추가되었는데, 관계 연산자와 논리 연산자는 혼합하여 사용할 수 있다. 
/// 아래 예제(A)는 category의 값에 따라 다른 숫자를 리턴하는 메서드인데, 조건식에 and, not, or 같은 논리 연산자를 사용하고 있다.
/// 특히, 예제(B)에서 보는 바와 같이, 기존의 C#에서 is 키워드를 사용하여 타입을 비교할 때, is not과 같은 표현을 쓸 수 없어서 if (!(a is Dog))와 같이 표현하였었는데, C# 9에서는 이를 간단히 is not 으로 표현할 수 있게 되었다.
/// </summary>
class CS9_300_Pattern_Logical
{
    // 예제(A) 논리 패턴
    static int GetValue(int category)
    {
        int val = category switch
        {
            0 or 1 => 101,
            > 1 and < 10 => 201,
            not 100 => 301,
            _ => 401
        };

        return val;
    }

    // 예제(B) not
    void Check(Animal a)
    { 
        // if (!(a is Dog)) // 기존방식
        if (a is not Dog)   // C# 9
        {
            //... 
        }
    }
}

