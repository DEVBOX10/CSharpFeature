using System;
using System.Collections.Generic;
using System.Text;

namespace CS8
{
    class CS8_B00_UnmanagedConstructedType
    {
        // System.Enum Type Contraint
        public Array GetValues<T>() where T : struct, System.Enum
        {
            return Enum.GetValues(typeof(T));
        }

        // System.Delegate Type Contraint
        public T Combine<T>(T a, T b) where T : Delegate
        {
            return (T)Delegate.Combine(a, b);
        }

        //TODO: Unsafe code may only appear if compiling with /unsafe
        // unmanaged Type Contraint
        //public unsafe void RunUnmanaged<T>(T val) where T : unmanaged
        //{
        //    int size = sizeof(T);
        //    T* a = &val;
        //    //...
        //}
    }
}
