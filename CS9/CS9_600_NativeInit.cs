using System;

/// <summary>
/// C# 9 Native Int 타입 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-native-int.aspx
/// 
/// Native Int란 플랫폼에 따라 다른 크기를 갖는 정수를 말하는데, 예를 들어 32비트 플랫폼에서는 32비트 정수가 되고, 
/// 64비트 플랫폼에서는 64비트 정수가 된다. 
/// C# 9에서 Native Int를 지원하기 위해 nint와 nuint 라는 새로운 키워드를 도입하였다. 
/// nint는 부호(sign)를 갖는 Native Int 타입이고, nuint는 unsigned int 타입의 Native Int 타입을 가리킨다. 
/// Native Int는 주로 Unmanaged 코드와의 연동이나 저수준 라이브러리에서 유용하게 사용될 수 있다.
/// 아래 예제에서처럼 nint를 32비트로 컴파일했을 때는 32비트 (4 바이트)의 정수가 되고, 
/// 64비트로 컴파일했을 때는 64비트 (8바이트)의 정수가 된다.
/// </summary>
class CS9_600_NativeInit
{
    //(1) 32bit로 컴파일되었을 때 4바이트 정수
    nint a = 100;

    //(2) 64bit로 컴파일되었을 때 8바이트 정수
    nint b = 100;

    void Test()
    {
        nint a = 5;
        int b = 10;

        nint c = a + b;
        Console.WriteLine(typeof(nint)); // System.IntPtr

        long d = 15;
        if (a < d)
        {
            Console.WriteLine(a + d); // 20
        }
    }
}