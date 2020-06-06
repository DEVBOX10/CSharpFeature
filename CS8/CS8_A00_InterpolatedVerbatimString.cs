using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
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
