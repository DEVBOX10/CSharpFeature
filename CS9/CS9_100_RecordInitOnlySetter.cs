/*
C# 9 레코드 타입 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-record.aspx

C# 9.0에서 새롭게 추가된 키워드로 init 이라는 키워드가 있다. init은 속성을 정의할 때 쓰는 set 대신에 사용하는데, 
set으로 정의된 속성이 흔히 객체 생성 이후에 속성을 변경하는데 사용되는 것이라면, 
init은 객체가 처음 초기화될 때만 속성을 변경할 수 있다. 
init 키워드는 해당 속성을 Immutable(불변) 속성으로 만드는 역활을 하게 된다. 
init이 하나의 속성을 Immutable로 만드는 것이라면, record 타입은 객체 전체를 Immutable로 만드는 것으로 볼 수 있다. 
record 타입을 정의할 때 위 예제(1)과 같이 생성자를 쓰는 대신, 
아래와 같이 init과 객체 초기자(Object Initializer)를 사용할 수 있는데 만약 필드/속성의 수가 많다면, 아래 표현이 더 간결할 수 있다.

*/

class CS9_210
{
    void Test()
    {
        Person2 p = new Person2
        {
            Name = "Tom",
            Age = 30
        };
    }
}