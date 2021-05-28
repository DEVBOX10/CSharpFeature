using System;

namespace CS6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CS6_100_NullConditionOperator.Test();
            CS6_200_StringInterpolation.Test();
            CS6_300_DictionaryInitializer.Test();
            CS6_400_NameOfExpression.Test();
            CS6_500_UsingStatic.Test();
            CS6_600_AwaitCatchFinally.Test();
            CS6_700_ExceptionFilter.ExceptionFilter();

            var cs6_800 = new CS6_800_AutoPropertyInitializer();
            cs6_800.Name = "C# 6.0 - AutoPropertyInitializer";
            
            CS6_900_ReadOnlyAutoProperty.Test();

            var a00 = new CS6_A00_ExpresionBodiedMember();
            a00.Move(10, 20);
        }
    }
}
