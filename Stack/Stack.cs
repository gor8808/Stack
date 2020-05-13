using System;
using System.Collections.Generic;

namespace Stack.LinkedList
{
    class Stack<T> : IEquatable<T>
    {
        private LinkedList<T> _list = new LinkedList<T>();

        public void Push(T item)
        {
            _list.AddFirst(item);
        }
        public T Pop()
        {
            T itemRec = _list.First.Value;
            _list.RemoveFirst();
            return itemRec;
        }
        public T Peak()
        {
            return _list.First.Value;
        }
        public bool Equals(T other)
        {
            throw new NotImplementedException();
        }
        public int Count
        {
            get
            {
                return _list.Count;
            } 
        }
        public void Clear()
        {
            _list.Clear();
        }

    }
}
