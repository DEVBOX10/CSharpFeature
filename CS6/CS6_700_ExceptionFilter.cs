using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CS6
{
    /// <summary>
    /// C# 6.0 catch블럭 await - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/CS6/CSharp-try-catch-enhanced.aspx#MainPlaceHolder_MainBar_MainContent_s2_TitleDiv
    /// </summary>
    public static class CS6_700_ExceptionFilter
    {
        public static async void ExceptionFilter()
        {
            // Exception Filter
            try
            {
                //...
            }
            catch (Win32Exception ex) when (ex.NativeErrorCode == 0x10)
            {
                Log(ex);
            }
        }

        public static async Task Log(Exception ex)
        {
        }
    }
}
