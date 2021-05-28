using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 기타 기능들 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-misc.aspx
    /// </summary>
    class CS8_A00_InterpolatedVerbatimString
    {
        string GetDataFile(string path)
        {
            string s = $@"{path}\data.csv"; // 사용가능
            s = @$"{path}\data.csv";        // 사용가능
            return s;
        }
    }
}
