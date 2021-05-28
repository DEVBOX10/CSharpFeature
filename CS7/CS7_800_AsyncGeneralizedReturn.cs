using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CS7
{
    /// <summary>
    /// C# 7.0 async 리턴타입 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS7-async-return.aspx
    /// 
    /// 지금까지의 async / await는 void, Task, Task<T> 등 3가지 리턴 타입만을 가질 수 있었는데, Task는 리턴값이 없는 비동기 메서드를 위해서 사용되었고, Task<T>는 리턴값 T를 갖는 비동기 메서드를 위해 사용되었다. 
    /// void는 주로 이벤트핸들러를 위해 사용되었지만 메서드 내부에서 Unhandled Exception이 발생하면 프로세스를 다운시키는 문제가 있어서 사용을 자제한 리턴타입이다.
    /// C# 7 에서는 이러한 3가지 async 리턴타입에 대한 제약을 넘어 커스텀 리턴 타입을 허용하게 되었는데, 이러한 커스텀 타입은 async 패턴에 맞게 정의되어야 한다. 
    /// 이러한 Custom 리턴 타입의 하나로 .NET Framework에서 ValueTask<T> 라는 타입이 제공되고 있는데, 필요한 경우 Nuget 패키지에서 System.Threading.Tasks.Extensions 을 설치하여 사용한다.
    /// async 메서드에서 흔히 사용하는 Task, Task<T> 리턴타입은 비동기 처리가 필요없이 상수값을 리턴할 때도 Task 객체를 항상 만들기 때문에 일부 경우에 성능을 저하시킬 수 있다.
    /// ValueTask<T> 타입은 값 T 와 Task<T> 가 결합된 형태라고 볼 수 있는데, async 메서드 내에서 동기 처리가 필요할 때는 Task 객체를 생성하지 않고 직접 값 T 를 리턴하고, 비동기 처리가 필요할 때는 Task 객체를 생성하여 사용하게 된다. 
    /// 따라서, ValueTask<T> 타입은 async 메서드 내에 동기 처리와 비동기 처리가 혼합되어 있을 때 유용하다.
    /// 예를 들어, async 메서드가 캐쉬에 데이타가 있으면 즉시 동기적으로 캐쉬값을 리턴하고 그렇지 않으면 네트워크을 통해 비동기적으로 값을 가져와야 하는 경우, async 리턴타입으로 ValueTask<T> 을 사용하면 성능 향상을 기대할 수 있다.
    /// 아래 예제는 캐쉬를 사용하여 동기와 비동기 처리를 함께 수행하는 async 메서드에 대한 예로서 리턴타입으로 ValueTask<T> 커스텀 타입을 사용하고 있다. 
    /// (여기서 ValueTask 대신 Task를 써도 동작하지만 ValueTask이 더 효율적이다)
    /// </summary>
    class CS7_800_AsyncGeneralizedReturn
    {
        private Dictionary<int, int> cache = new Dictionary<int, int>();

        private async ValueTask<int> GetCache(int id)
        {
            if (cache.ContainsKey(id))
            {
                // 동기 처리. 값 직접 리턴
                return cache[id];
            }
            else
            {
                // 비동기 처리. Task 객체 생성
                int res = await Fetch(id);
                cache.Add(id, res);
                return res;
            }
        }

        async Task<int> Fetch(int id)
        {
            return id * 100;
        }
    }
}
