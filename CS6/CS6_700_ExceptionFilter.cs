using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CS6
{
    class CS6_700_ExceptionFilter
    {
        async void ExceptionFilter()
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

        async Task Log(Exception ex)
        {
        }
    }
}
