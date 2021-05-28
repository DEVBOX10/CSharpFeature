using System;
using System.Collections.Generic;
using System.Text;

namespace CS7
{
    /// <summary>
    /// C# 7.0 튜플 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS7-tuple.aspx
    /// 
    /// 메서드 원형을 정의할 때 리턴타입이 복수 개이므로 튜플 리턴 타입(tuple return type) 표현식을 사용하게 되는데, 이는 괄호 ( ) 안에 여러 리턴타입들을 순서대로 나열하면 된다. 
    /// 예를 들어, int 2개와 double 하나를 리턴할 경우 "(int, int, double)" 과 같이 표현할 수 있으며, 더 나아가 편의를 위해 각 리턴타입마다 이름을 지정할 수도 있다. 
    /// 예를 들어 "(int count, int sum, double average)"와 같이.
    /// 아래 예제에서 Calculate() 라는 메서드는 입력된 숫자 리스트의 갯수, 합계, 평균을 리턴하는 함수인데, 메서드명 앞에 튜플 리턴 타입을 지정하였으며, 메서드 본문 마지막 return 문에는 3개의 변수값들을 묶은 튜플 리터럴을 리턴하고 있다.
    /// 아래 Calculate() 메서드에서 튜플리턴타입을 명칭 없이 타입만(int, int, double) 지정한다면, 결과 변수는 r.Item1, r.Item2, r.Item3 와 같이 Item* 이라는 속성을 사용하여 3개의 값을 전달받는다. 
    /// 이러한 Item* 속성은 튜플로부터 항상 사용할 수 있는 속성이다. 
    /// 물론 아래 예제 처럼 튜플리턴타입에 명칭을 선언한다면, 선언된 변수명을 사용할 수 있다.
    /// </summary>
    public static class CS7_200_Tuple
    {
        static (int count, int sum, double average) Calculate(List<int> data) //튜플 리턴타입
        {
            int cnt = 0, sum = 0;
            double avg = 0;

            foreach (var i in data)
            {
                cnt++;
                sum += i;
            }

            avg = sum / cnt;

            return (cnt, sum, avg); //튜플 리터럴
        }

        public static void Run()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            var r = Calculate(list);  // 튜플 결과
            Console.WriteLine($"{r.count}, {r.sum}, {r.average}");
            Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}");
        }


        /// <summary>
        /// 튜플로 복수 개의 값들이 리턴될 경우 이를 각각의 변수로 쪼개서 할당하는 것을 튜플 Deconstruction 이라 부른다. 
        /// 예를 들어, 위의 Calculate() 메서드로부터 값을 리턴받을 때 하나의 튜플로 리턴받는 것이 아니라, 아래 예제처럼 3개의 변수에 나누어 전달 받을 수 있다. 각 변수의 타입을 모두 var 로 지정할 수도 있고, "var (a,b,c)" 처럼 var 타입의 3개 변수를 전달받는 표현도 가능하다. 
        /// 아래 마지막 라인처럼 기존에 있는 변수들에 (변수 타입 선언 없이) 할당할 수도 있다.
        /// 
        /// </summary>
        static void TupleDeconstruction()
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };

            (int cnt, int sum, double avg) = Calculate(list); // Deconstruction 
            //(var cnt, var sum, var avg) = Calculate(list);
            //var (cnt, sum, avg) = Calculate(list);
            (cnt, sum, avg) = Calculate(list);
        }
    }
}
