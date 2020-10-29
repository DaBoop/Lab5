using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5
{
    
    interface ICList<T> // where T: struct, Goods
    {
        void Add(T val);
        void Remove();

        void Print();
    }
}
