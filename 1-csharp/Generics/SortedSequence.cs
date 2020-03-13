using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    // behaves like a List<T> but keep itself sorted
    class SortedSequence<T>
    {
        List<T> _list = new List<T>();

        public void Add(T item)
        {
            _list.Add(item);
            _list.Sort();
        }

        //implement indexer operator []
        T this[int i] 
        { 
            get => _list[i]; 
            set => _list[i] = value;
            // using expression body syntax so its shorter to write
        }
    }
}
