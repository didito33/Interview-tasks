using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class StackWithArray<T> :IStack<T>
    {
        private T[] items;
        private int count;

        public StackWithArray(int capacity)
        {
            items = new T[capacity];
        }

        public void Push(T item)
        {
            if (count == items.Length)
            {
                throw new InvalidOperationException("The stack is full.");
            }
            items[count] = item;
            count++;
        }

        public T Pop()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            count--;
            T item = items[count];
            items[count] = default(T);
            return item;
        }
    }
}
