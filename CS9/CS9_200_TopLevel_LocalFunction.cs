/*
C# 9 최상위 프로그램 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS9-top-level.aspx

최상위 프로그램에서 로컬함수를 정의하여 사용할 수 있는데, 이 로컬함수는 최상위 프로그램 안에서만 호출되며 최상위 밖에서는 사용할 수 없다. 
최상위 프로그램은 또한 명령인자를 받아들일 수 있는데, 이때는 args 라는 최상위에서 인식되는 특별한 변수를 사용하면 된다. 
아래 예제는 최상위 프로그램에서 2개의 숫자 명령인자를 받아들여 로컬함수를 통해 이를 더하는 샘플 코드이다. 
실행 프로그램명을 test.exe 라고 했을 때, test 100 200 처럼 명령인자를 전달하여 프로그램을 실행하는 것을 가정한 것이다.
*/



// 프로그래명이 test.exe 일 때
//   test.exe 100 200
// 와 같이 호출한다고 가정
// int a = int.Parse(args[0]); // 100
// int b = int.Parse(args[1]); // 200

/*

int a = 100;
int b = 200;

// 로컬함수 사용
int c = Calculate(a, b);
System.Console.WriteLine(c);

// 로컬함수 정의
int Calculate(int x, int y)
{
    int k = x + y;
    return k;
}

*/