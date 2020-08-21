using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Utilities<T> where T : IComparable, new() // constraints
    {
        // Usually we do this:
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        { 
            
        }

        // When we use Generics, we do this:
        public T Max(T a, T b) 
        {     
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}

// Types of Constraints
// where T : IComparable
// where T : Product
// where T : struct
// where T : class
// where T : new()