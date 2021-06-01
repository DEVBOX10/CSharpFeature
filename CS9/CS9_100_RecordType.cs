/// C# 9 레코드 타입 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-record.aspx

// 예제(1)
/*
C# 9 최상위 프로그램 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-top-level.aspx

C# 9.0 에서 가장 두드러진 변화는 record 타입을 새로 도입한 것이다. 
지금까지의 C#/.NET에서는 struct를 사용하는 Value Type(값 타입)과 class를 사용하는 Reference Type(레퍼런스 타입)이 있었는데, 
C# 9에서 Immutable 값 데이타를 갖는 record 타입을 추가하였다. 
새로 도입된 record 타입은 객체 내의 멤버가 변하지 않는 Immutable Reference Type을 만들기 위한 것이다. 
C# 9에서는 이를 위해 record 라는 새로운 키워드를 도입했으며, class 키워드를 사용해서 클래스를 정의하는 것이 아니라, 
이 record라는 키워드를 통해 Immutable Type을 정의하게 된다.


*/

class CS9_200
{
    static void Test()
    {
        Person p = new Person("Tom", 30);
        string s = p.Name;
    }
}