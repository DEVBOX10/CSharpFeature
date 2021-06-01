/*
C# 9 공변 리턴 타입 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-covariant-return.aspx

C# 9 이전에서는 Base 클래스에 정의된 메서드를 파생클래스에서 재정의(override) 할 때, 메서드의 리턴타입이 동일해야 했었는데, 
C# 9 에서는 파생클래스에서 재정의된 메서드의 리턴타입이 Base 클래스의 메서드 리턴타입보다 더 하위 타입으로 지정할 수 있게 되었다.
아래 예제에서 Car 클래스의 GetEngine() 메서드는 Engine 이라는 클래스 타입을 리턴하는데, 
파생클래스인 Audi 클래스의 GetEngine() 메서드는 V6Engine 이라는 서브클래스 타입을 리턴하고 있다. 
만약 아래 코드를 C# 9 이전 버전에서 실행하면 
return type must be Engine to match overridden member Car.GetEngine() 와 같은 에러가 발생 된다.
*/

public abstract class Car
{
    public abstract Engine GetEngine();
}

public class Audi : Car
{
    public override V6Engine GetEngine()
    {
        return new V6Engine();
    }
}

public class Engine { }
public class V6Engine: Engine { }