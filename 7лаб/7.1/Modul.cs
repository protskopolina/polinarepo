using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._1
{
    using System;

    public class Modul : IComparable<Modul>, ICloneable
    {
        public Person Leader;
        public string Name;
        public double Size;

        public Modul(Person l, string n, double s) => (Leader, Name, Size) = (l, n, s);
        public int CompareTo(Modul o) => Size.CompareTo(o.Size);
        public object Clone() => new Modul((Person)Leader.Clone(), Name, Size);
        public override string ToString() => $"{Leader}, {Name}, {Size}";
    }
}