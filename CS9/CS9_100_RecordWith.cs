/*
C# 9 레코드 타입 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-record.aspx

record 타입은 객체 전체가 Immutable인 타입인데, 만약 객체 중 일부만 변경하여 새로운 record 객체를 만들고 싶다면, 
C# 9에서 새로 도입된 with 키워드를 사용할 수 있다. 
예를 들어, 아래 예제에서 Person 타입의 객체로 tom1을 만들었을 때, 
tom1 객체 중 나이만 변경하고 나머지 데이타는 동일하게 tom2 객체를 만들고 싶다면, 아래와 같이 with 키워드를 사용할 수 있다.


*/

Person2 tom1 = new Person2
{
    Name = "Tom",
    Age = 30
};


Person2 tom2 = tom1 with { Age = 40 };

class CS9_220
{
    
}