using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public interface IStorage<T>
    {
        void Add(T item);
        void Remove(T item);
        bool Contains(T item);
        void Update(T item, T newValue);
        void ShowList();
    }


}
