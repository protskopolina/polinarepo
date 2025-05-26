using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._1
{
    public interface IContainer<T>
    {
        int Count { get; }
        T this[int i] { get; set; }
        void Add(T el);
        void Delete(T el);
    }

    public interface IFileContainer<T> : IContainer<T>
    {
        void Save(string file);
        void Load(string file);
        bool IsDataSaved { get; }
    }
}