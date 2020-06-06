using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace CS8
{
    class CS8_100_DefaultInterfaceMember
    {
        void Test()
        {
            //TDO: 인터페이스의 디폴트 멤버 구현을 엑세스하기 위해서는 인터페이스로 캐스팅된 변수를 사용한다는 점이다. 예를 들어, 위 ILogger.Log(string logType, string msg) 메서드에서 정의된 디폴트 구현은 MyLogger 객체에서 직접 엑세스할 수 없고, ILogger로 캐스팅 된 후에 엑세스할 수 있다.

            MyLogger myLogger = new MyLogger();
            //myLogger.Log("Error", "Invalid Data"); //ERROR!

            ILogger logger = new MyLogger();
            logger.Log("", "");
        }
    }



    // ILogger v1.0
    //public interface ILogger
    //{
    //    void Log(string message);
    //}

    //TODO: ILogger v2.0은 Exception 객체를 받아이거나 로그타입을 추가적으로 받아들일 수 있도록 한 것이다. 이때, 새로 추가된 메서드들에 디폴트 메서드 Body부분을 구현해서 기존 v1.0을 사용하는 타입들도 별도의 수정없이 계속 사용할 수 있도록 한다.

    // ILogger v2.0
    public interface ILogger
    {
        void Log(string message);

        // 추가된 멤버들
        void Log(Exception ex) => Log(ex.Message);
        void Log(string logType, string msg)
        {
            if (logType == "Error" ||
                logType == "Warning" ||
                logType == "Info")
            {
                Log($"{logType}: {msg}");
            }
            else
            {
                throw new ApplicationException("Invalid LogType");
            }
        }
    }


    class MyLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
            Debug.WriteLine(message);
        }

        // 디폴트 구현을 사용하지 않고 새로 정의함
        public void Log(Exception ex)
        {
            Debug.WriteLine(ex.ToString());
        }
    }
}
