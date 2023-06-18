using System;
using System.Collections.Generic;

namespace CustomListImplementation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;

    namespace CustomListImplementation
    {
        public class CustomList<T> : IEnumerable<T>
        {
            private List<T> _items;

            public int Count => _items.Count;

            public CustomList()
            {
                _items = new List<T>();
            }

            public void AddElement(T item)
            {
                _items.Add(item);
            }

            public void AddList(IEnumerable<T> list)
            {
                _items.AddRange(list);
            }

            public bool InsertElement(T item, int position)
            {
                if (IsValidPosition(position))
                {
                    _items.Insert(position, item);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool InsertList(IEnumerable<T> list, int position)
            {
                if (IsValidPosition(position))
                {
                    _items.InsertRange(position, list);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public T GetElement(int position)
            {
                if (IsValidPosition(position))
                {
                    return _items[position];
                }
                else
                {
                    return default(T);
                }
            }

            public CustomList<T> GetList(int index, int count)
            {
                if (index >= 0 && index < _items.Count && count > 0 && index + count <= _items.Count)
                {
                    CustomList<T> sublist = new CustomList<T>();
                    sublist._items = _items.GetRange(index, count);
                    return sublist;
                }
                return null;
            }


            public bool RemoveElement(T item)
            {
                return _items.Remove(item);
            }

            public bool RemoveList(IEnumerable<T> list)
            {
                bool removed = false;
                foreach (T item in list)
                {
                    removed |= _items.Remove(item);
                }
                return removed;
            }

            public void Clear()
            {
                _items.Clear();
            }

            public T Find(Predicate<T> predicate)
            {
                return _items.Find(predicate);
            }

            public IEnumerator<T> GetEnumerator()
            {
                return _items.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private bool IsValidPosition(int position)
            {
                return position >= 0 && position < _items.Count;
            }
            public T this[int index]
            {
                get { return GetElement(index); }
                set { _items[index] = value; }
            }


        }
    }

}
