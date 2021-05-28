using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace CS8
{
    /// <summary>
    /// C# 8 using 선언 - C# 프로그래밍 배우기 (Learn C# Programming) : https://www.csharpstudy.com/Latest/CS8-using.aspx
    /// </summary>
    class CS8_600_UsingDeclaration
    {
        // C# 8.0
        private void GetDataCS8()
        {
            using var reader = new StreamReader("src.txt");
            string data = reader.ReadToEnd();
            Debug.WriteLine(data);

            // 여기서 Dispose() 호출됨
        }

        // C# 모든 버전
        private void GetData()
        {
            using (var reader = new StreamReader("src.txt"))
            {
                string data = reader.ReadToEnd();
                Debug.WriteLine(data);
            }  // 여기서 Dispose() 호출됨

            // ...
            Debug.WriteLine("...");
        }
    }
}
