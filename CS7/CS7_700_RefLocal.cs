using System;
using System.Collections.Generic;
using System.Text;

namespace CS7
{
    class CS7_700_RefLocal
    {
        void RefLocal()
        {
            int a = 1;

            // ref local
            ref int b = ref a;

            b = 2;

            Console.WriteLine($"{a}, {b}");  // "2, 2" 출력
        }


        static GameData _gameData = new GameData();

        void RefReturn()
        {
            // 10번째 배열요소에 대한 ref
            ref int score10 = ref _gameData.GetScore(10);

            // 10번째 배열요소에 쓰기
            score10 = 99;

            Console.WriteLine(_gameData.GetScore(10)); // 99
        }

    }

    class GameData
    {
        private int[] scores = new int[100];

        // ref return 
        public ref int GetScore(int id)
        {
            //...

            return ref scores[id];
        }
    }
}
