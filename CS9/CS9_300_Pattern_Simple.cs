/// <summary>
/// C# 9 향상된 패턴 매칭 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-pattern-match.aspx
/// 
/// switch 식에서 흔히 사용하지 않는 변수를 밑줄(_)로 표시하는데, 기존에는 이 밑줄(discard parameter라고 불리움)을 생략할 수 없었다. 
/// C# 9에서는 어떤 타입의 변수를 사용하지 않는다면, 밑줄을 생략할 수 있게 되었다. 
/// 아래 예제에서 기존에는 Animal _ 을 사용하였지만, C# 9에서는 _ 을 생략할 수 있다.
/// </summary>
class CS9_300_Pattern_Simple
{
    void Check(Animal animal)
    {
        string name = animal switch
        {
            Dog d => "Dog",
            Cat c => "Cat",
            //Animal _ => "" 
            Animal => ""
        };
    }
}