using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 구조체 읽기 전용 멤버 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-readonly-member.aspx
    /// 
    /// 이전 C# 버전에서 구조체(struct) 전체를 readonly로 만들 수 있었는데, C# 8.0부터는 구조체의 각 멤버에 대해 개별적으로 readonly로 정의할 수 있게 되었다. 
    /// 만약 구조체의 메서드나 속성이 구조체의 상태를 변경하지 않는다면 readonly로 적용할 수 있고, readonly 멤버가 다른 non-readonly 멤버를 엑세스하면 컴파일러가 Warning을 표시한다.
    /// </summary>
    class CS8_810_StructReadonlyMember
    {

        static void Test()
        {
            TriangleReadonly t = new TriangleReadonly(3, 4, 5);
            Check(t);
            Check_Ref(ref t);
        }


        // Do not use 'System.Runtime.CompilerServices.IsReadOnlyAttribute'. This is reserved for compiler usage.

        /// <summary>
        /// Check() 메서드에서 Triangle 구조체의 Perimeter와 IsEquilateral 멤버를 2번 호출하고 있는데, 이렇게 멤버를 호출할 때마다 직전에 Triangle 인스턴스를 로컬변수에 복사하게 된다. 아래 예제는 위 코드를 컴파일했을 때의 코드를 표현한 것으로 멤버 호출 직전에 구조체 파라미터를 복사하고 있다.
        /// 
        /// 위와 같은 복사(hidden copy) 이슈를 해결하기 위해서, 만약 그 멤버가 구조체의 상태를 변화시키지 않을 경우 멤버 앞에 readonly를 붙여 컴파일러에게 hidden copy를 만들 필요가 없음을 알려 줄 수 있다. 즉, Perimeter와 IsEquilateral 멤버 앞에 아래와 같이 readonly를 표시할 수 있다.
        /// </summary>
        /// <param name="tri"></param>
        private static void Check_Ref([In] ref TriangleReadonly tri)
        {
            TriangleReadonly triangle = tri;
            int perimeter = triangle.Perimeter;
            triangle = tri;
            bool isEquilateral = triangle.IsEquilateral;
            Console.WriteLine(string.Format("{0}, {1}", perimeter, isEquilateral));
        }


        private static void Check(in TriangleReadonly tri)
        {
            int perim = tri.Perimeter;
            bool equi = tri.IsEquilateral;

            Console.WriteLine($"{perim}, {equi}");
        }
    }


    public struct TriangleReadonly
    {
        public readonly int a, b, c;

        public TriangleReadonly(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public readonly int Perimeter => a + b + c;
        public readonly bool IsEquilateral => a == b && b == c;
    }
}
