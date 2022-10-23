using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Generic_Box_Of_String
{
    public class GenericBoxOfString<T>
    {
        public T Value { get; set; }

        public GenericBoxOfString(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.GetType().FullName + $": {Value}";
        }
    }
}
