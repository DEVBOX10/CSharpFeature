/// <summary>
/// C# 9 향상된 Target Typing - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-target-typing.aspx
/// 
/// Target Typing 이란 문맥(context)으로부터 어떤 타입을 추론하는 것을 말한다. 
/// 예를 들어, C#에서 var를 사용하면, 컴파일러가 그 타입을 추론하여 결정하게 되는데, 이는 타겟 타이핑의 예로 볼 수 있다.
/// C# 9.0에서 새로 추가된 Target Typing으로 Target Typed new Expression 이 있는데, 
/// 이는 객체를 생성할 때 사용하는 new 키워드 뒤에 지금까지는 항상 타입을 적어왔으나, C# 9에서는 타입을 적지 않고 추론할 수 있도록 한 것이다.
/// 예를 들어, 아래 예제에서 new Employee() 대신 new() 를 사용하면, 컴파일러는 그 타입이 Employee인 것을 전후 맥락을 통해 추론하게 된다.
/// 기존의 var 와 C# 9의 new()는 유사한 점이 있는데, C# 9의 new() 가 특히 유용한 곳은 필드에서 타입 추론을 할 때이다. 
/// C# var는 메서드 내의 로컬변수에서만 사용할 수 있고 필드에서는 사용할 수 없지만, C# 9의 new()는 필드에서도 사용될 수 있다.
/// </summary>
class CS9_400_TargetTyping
{
    void Test()
    {
        // var 사용
        var a = new Employee();
            
        // new() 사용
        Employee b = new();
    }

    /// <summary>
    /// C# 9에서 ? : 조건연산자를 사용할 때, 공유되는 타입이 있다면 조건연산자 안에서 사용할 수 있게 되었다. 
    /// 예를 들어, 아래 예제에서 Fulltime, Parttime 클래스는 Employee 클래스로부터 파생된 클래스인데, 
    /// ? : 조건연산자에서 파생클래스가 Base 클래스 타입을 공유하기 때문에 이러한 표현을 사용할 수 있게 되었다. 
    /// 이는 int? 타입에서 0 혹은 null을 리턴하는 것도 동일한 맥락이다.
    /// 만약 C# 9 이전에 이 표현을 사용하면 
    /// CS0173 Type of conditional expression cannot be determined because there is no implicit conversion between Fulltime and Parttime 와 같은 에러를 발생하게 된다.
    /// </summary>
    void Test_ConditionalOperator()
    {
        Fulltime fte = null;
        Parttime part = new Parttime();
        bool ok = true;

        // Base 타입 공유
        Employee emp = ok ? fte : part;

        // nullable value type
        int? i = ok ? 0 : null;
    }
}