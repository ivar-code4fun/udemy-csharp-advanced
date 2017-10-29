﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // where T : IComparable
    // where T : Product -- a class
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        //Generic version of Add
        public T Max(T a, T b)
        {
            //return a > b ? a : b;
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
