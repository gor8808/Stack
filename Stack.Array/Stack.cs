using System;

namespace Stack.Array
{
    public class Stack<T> : IEquatable<T>
    {
        T[] _items = new T[0];
        private int _size;

        public void Push(T item)
        {
            if(_size == _items.Length)
            {
                int newLength = _size == 0 ? 4 : _size * 2;
                T[] newItems = new T[newLength];
                _items.CopyTo(newItems, 0);
                _items = newItems;

            }
            _items[_size] = item;
            _size++;
        }
        public T Pop()
        {
            if(_items.Length == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            _size--;
            return _items[_size];
        }
        public bool Equals(T other)
        {
            throw new NotImplementedException();
        }
    }
}
