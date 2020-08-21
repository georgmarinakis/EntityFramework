using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class Nullable<T> where T : struct
    {
        // value types cannot be NULL in C#
        // I store it as n object in order to be nullable

        private object _value;

        // Default Constructor, in case the value is not set
        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}
