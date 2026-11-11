using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab29_Task2
{
    public class Stack<T>
    {
        private readonly List<T> _items = new List<T>();
        public void Push(T item)
        {
            _items.Add(item);
        }
        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек порожній");
            T LastItem = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return LastItem;
        }
        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек порожній");
            return _items[_items.Count - 1];
        }
        public int Count => _items.Count;

        public bool IsEmpty => _items.Count == 0;
    }
}
