﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    public interface IQueue<T>
    {
        void Enqueue(T item);
        T Dequeue();
    }
}
