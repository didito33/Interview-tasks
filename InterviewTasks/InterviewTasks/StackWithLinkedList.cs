using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class StackWithLinkedList<T>:IStack<T>
    {
        private LinkedList<T> list = new LinkedList<T>();

        public void Push(T item)
        {
            list.AddFirst(item);
        }

        public T Pop()
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }
            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }


    }
}
