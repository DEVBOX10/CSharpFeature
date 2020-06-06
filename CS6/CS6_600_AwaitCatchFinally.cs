using System;
using System.Collections.Generic;
using System.Data;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CS6
{
    class CS6_600_AwaitCatchFinally
    {
        async void Test()
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

        


        async Task Close(IDbConnection conn)
        {
        }

        async Task Log(Exception ex)
        {
        }
    }
}
