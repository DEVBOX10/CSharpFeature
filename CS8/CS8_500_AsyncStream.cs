using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CS8
{
    class CS8_500_AsyncStream
    {
        static void Test()
        {
            TempTest().Wait();
        }

        static async Task TempTest()
        {
            var dev = new Device();
            await foreach (var temp in dev.GetTemperatures())
            {
                Console.WriteLine($"{DateTime.Now}: {temp}");
            }
        }
    }


    class Device
    {
        private int lastTemp = 0;

        public async IAsyncEnumerable<int> GetTemperatures()
        {
            for (int i = 0; i < 100; i++)
            {
                //int currTemp = await GetTempFromDevice();
                int currTemp = i;
                if (currTemp != lastTemp)
                {
                    lastTemp = currTemp;
                    yield return lastTemp;
                }
            }
        }

        //private async Task<int> GetTempFromDevice() 
        //{
        //}
    }
}
