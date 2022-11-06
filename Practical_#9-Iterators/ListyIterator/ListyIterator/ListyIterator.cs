using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> collection;
        private int index; 

        public ListyIterator()
        {
            this.collection = new List<T>();
            this.index = 0;
        }

        public void Create(List<T> items)
        {
            if(items.Count == 0)
            {
                throw new ArgumentException("Invalid Operation");
            }

            for(int i = 0; i < items.Count; i++)
            {
                collection.Add(items[i]);
            }
        }

        public bool Move()
        {
            if(HasNext())
            {
                this.index++;
                return true; 
            }
            return false;
        }

        public bool HasNext()
        {
            return index + 1 < collection.Count;
        }

        public void Print()
        {
            Console.WriteLine(collection[index]);
        }
    }
}
