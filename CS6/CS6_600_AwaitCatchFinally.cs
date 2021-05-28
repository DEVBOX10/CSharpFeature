using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CS6
{
    /// <summary>
    /// C# 6.0 catch블럭 await - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/CS6/CSharp-try-catch-enhanced.aspx
    /// </summary>
    public static class CS6_600_AwaitCatchFinally
    {
        public static async void Test()
        {
            var req = HttpWebRequest.CreateHttp("");

            IDbConnection conn = null;
            try
            {
                //conn = new SqlConnection();
                //...
                var response = await req.GetResponseAsync();
                //...
            }
            catch (Exception ex)
            {
                //에러를 비동기로 로깅
                await Log(ex);
            }
            finally
            {
                //Close를 비동기로 처리
                await Close(conn);
            }
        }

        


        public static async Task Close(IDbConnection conn)
        {
        }

        public static async Task Log(Exception ex)
        {
        }
    }
}
