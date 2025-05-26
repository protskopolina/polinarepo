using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LB7._2.Interfaces;

namespace LB7._2
{
    public class Registry
    {
        private List<Equipment> items = new();
        public void Add(Equipment e) => items.Add(e);
        public void PrintAll() => items.ForEach(Console.WriteLine);
        public void PrintWithEngine() => items.Where(i => i.HasEngine).ToList().ForEach(Console.WriteLine);
        public void PrintWithoutEngine() => items.Where(i => !i.HasEngine).ToList().ForEach(Console.WriteLine);
        public void SortByName() => items.Sort((a, b) => a.Name.CompareTo(b.Name));
        public void SortByPower() => items.Sort((a, b) => ((a as IEngine)?.Power ?? 0).CompareTo((b as IEngine)?.Power ?? 0));
        public Registry CopyFirst(int n)
        {
            var r = new Registry();
            for (int i = 0; i < Math.Min(n, items.Count); i++)
                r.Add((Equipment)items[i].Clone());
            return r;
        }
    }
}