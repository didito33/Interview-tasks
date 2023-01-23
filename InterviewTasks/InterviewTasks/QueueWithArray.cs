using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public class QueueWithArray<T>:IQueue<T>
    {
        private T[] items;
        private int head;
        private int tail;
        private int count;

        public QueueWithArray(int capacity)
        {
            items = new T[capacity];
        }

        public void Enqueue(T item)
        {
            if (count == items.Length)
            {
                throw new InvalidOperationException("The queue is full.");
            }
            items[tail] = item;
            tail++;
            count++;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                throw new InvalidOperationException("The queue is empty.");
            }
            T item = items[head];
            items[head] = default(T);
            head++;
            count--;
            return item;
        }
    }
}
