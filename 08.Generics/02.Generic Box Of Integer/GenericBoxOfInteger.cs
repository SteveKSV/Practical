using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Generic_Box_Of_Integer
{
    public class GenericBoxOfInteger<T>
    {
        public T Value { get; set; }

        public GenericBoxOfInteger(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.GetType().FullName + $": {Value}";
        }
    }
}
