using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 Nullable Reference Type - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-nullable-ref-type.aspx
    /// </summary>
    class CS8_300_NullableReference
    {
        // C# 8.0에 추가된 이러한 Nullable Reference Type 기능은 기존에 작성된 프로그램들에 대해 수많은 경고 메시지를 발생시키게 할 것이다. 왜냐하면, C# 8.0 이전에는 Reference Type에 자유롭게 NULL을 할당할 수 있었기 때문에, 동일한 기존 C# 프로그램을 C# 8.0 컴파일러로 컴파일하면 모두 Warning으로 취급하게 될 것이기 때문이다. 이러한 Backward Compatibilty 문제점 때문에 C# 8.0 에선 디폴트로 Nullable Reference Type 기능을 Disable 하였으며, 이 기능을 사용하기 위해서는 프로젝트 레벨이나 파일 레벨, 혹은 소스코드 내의 임의의 위치에서 Nullable Reference Type 기능을 사용하도록 먼저 Enable 하여야 한다.

        //C# 프로젝트 파일(*.csproj)에서 <Nullable>enable</Nullable> 을 /Project/PropertyGroup 안에 넣으면, 프로젝트 레벨에서 Nullable Reference Type 기능을 사용하게 된다. 또한, 소스 파일의 첫 라인에 #nullable enable 을 사용하면 파일 레벨에서 Nullable Reference Type 기능을 사용하게 된다. 마찬가지로 소스 코드 중간에 #nullable enable을 넣으면 그 다음 라인부터 Nullable Reference 기능이 활성화 되고, #nullable disable을 넣으면 그 다음 라인부터 이 기능이 비활성화 된다.


        static void Test()
        {
#nullable enable
            string s1 = null; // Warning: Converting null literal or 
                              // possible null value to non-nullable type
            if (s1 == null) return;

            string? s2 = null;
            if (s2 == null) return;

#nullable disable
            string s3 = null; // No Warning
            if (s3 == null) return;
        }



        // Nullable Reference Type은 기존 Reference Type 뒤에 물음표를 붙여 표시한다. 예를 들어, string은 Non-nullable Reference Type이며, string? 은 Nullable Reference Type임을 표시한다. Nullable Reference Type의 변수를 사용할 때는 항상 먼저 NULL 인지를 체크해야 하며, 만약 그렇지 않으면 컴파일러가 경고(Warning) 메시지를 표시한다. 즉, 컴파일러가 이렇게 NULL이 들어갈 수 있는 부분을 자동으로 체크해서 경고를 표시하기 때문에, 개발자가 실수로 Null Reference Exception를 발생시키는 오류를 범하지 않도록 도와주게 된다. 아래 예제에서 첫번째 Console.WriteLine(s.Length) 문은 s.Length 속성을 엑세스하기 이전에 NULL 체크를 수행하지 않았기 때문에 컴파일러가 Warning 메시지를 표시하는 반면, 두번째 Console.WriteLine(s) 문은 먼저 s에 대한 NULL 체크를 수행했기 때문에 컴파일러가 Warning 메시지를 표시하지 않게 된다.


#nullable enable
        static void Print(string? s)
        {
            Console.WriteLine(s.Length); // Warning: Dereference of a possibly null reference

            if (s != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
