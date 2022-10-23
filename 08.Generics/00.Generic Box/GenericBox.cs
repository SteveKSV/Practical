using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Generic_Box
{
    public class GenericBox<T>
    {
        public T Value { get; set; }

        public GenericBox(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.GetType().FullName + $": {Value}";
        }
    }
}
