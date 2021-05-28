using System;
using System.Collections.Generic;
using System.Text;

namespace CS7
{
    /// <summary>
    /// C# 7.0 로컬 함수 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS7-localfunc.aspx
    /// 
    /// 로컬 함수는 - 클로져(Closure) 기능을 사용할 수 있어서 - 자신을 정의한 메서드의 변수들을 로컬 함수에서 사용할 수 있다. 
    /// 예를 들어, 아래 예제에서 factor 라는 메서드 로컬변수를 MyFormula() 라는 로컬함수 안에서 사용하였다.
    /// 로컬함수는 컴파일러가 다른 메서드와 동일하게 "메서드" 형태로 취급하는데, 이는 컴파일러가 람다식처럼 컴파일시 익명 타입을 자동으로 생성하는 등의 일을 하지 않는다는 것을 의미한다.
    /// 로컬함수는 특히 메서드 내에서만 사용해야 하는 함수가 필요할 때 유용하다. 
    /// 예를 들어, 아래 예제에서 로컬함수 NumberIterator()는 GetNumbers()라는 메서드 내에서만 사용하도록 설계되었다. 
    /// GetNumbers()는 입력파라미터가 타당한 지 검사한 후 NumberIterator()를 호출하게 되어 있으며, 로컬함수 안에서는 filter 라는 델리게이트가 이미 있음을 가정하고 있다. 
    /// 만약 이런 종류의 함수를 로컬함수로 쓰지 않고 일반 메서드로 작성한다면, 클래스의 다른 메서드들이 잘못 호출할 가능성도 있을 것이다.
    /// </summary>
    class CS7_300_LocalFunction
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        private int MyCalc(int a, int b, int c)
        {
            int factor = 10;
            int ab = MyFormula(a, b);
            int ac = MyFormula(a, c);
            return Math.Max(ab, ac);

            // 로컬 함수
            int MyFormula(int x, int y)
            {
                int res = 2 * x + 7 * y - 5;
                return res % factor; // factor 변수를 사용
            }
        }


        private IEnumerable<int> GetNumbers(int count, Func<int, bool> filter)
        {
            if (count < 1) throw new ArgumentException();
            if (filter == null) throw new ArgumentException();

            return NumberIterator();

            // 로컬함수
            IEnumerable<int> NumberIterator()
            {
                for (int i = 0; i < count; i++)
                {
                    if (filter(i))  // 메서드의 filter 파라미터 사용
                    {
                        yield return i;
                    }
                }
            }
        }

        // 사용
        private void Run()
        {
            foreach (var item in GetNumbers(100, n => n % 2 == 0))
            {
                Console.WriteLine(item);
            }
        }
    }
}
