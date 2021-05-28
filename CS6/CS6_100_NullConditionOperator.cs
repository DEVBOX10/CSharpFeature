using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CS6
{
    /// <summary>
    /// C# 6.0 널 조건 연산자 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/CS6/CSharp-null-conditional-operator.aspx
    /// </summary>
    static class CS6_100_NullConditionOperator
    {
        public static void Test()
        {
            var rows = new List<string>();
            var customers = new List<Customer>();
            var button = new MyButton();
            button.Click2();

            // rows가 NULL이면 cnt 도 NULL
            // rows가 NULL이 아니면 cnt는 실제 rows 갯수
            int? cnt = rows?.Count;

            // customers 컬렉션이 NULL이면 c는 NULL
            // 아니면, c는 첫번째 배열요소
            Customer c = customers?[0];

            // customers가 널인지 체크하고
            // 다시 customers[0]가 널인지 체크
            int? age = customers?[0]?.Age;
        }
    }


    class Customer : IEnumerable
    {
        public int Age => 0;
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public class MyButton
    {
        public delegate void MyEventHandler (object source, EventArgs args);
        public event EventHandler Clicked;

        // 이전 방식
        public void Click1()
        {
            //...

            // 스텝1. 임시변수에 이벤트 복사 (Thread safety 때문)
            var tempClicked = Clicked;
            // 스텝2. 널 체크
            if (tempClicked != null)
            {
                // 스텝3. 이벤트 Invoke
                tempClicked(this, null);
            }
        }

        // C# 6.0 방식
        public void Click2()
        {
            // ...

            // 위의 3 스텝을 널 조건 연산자을 사용하여
            // 한 문장으로 표현
            Clicked?.Invoke(this, null);
        }
    }
}
