using LB7._1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Project : IFileContainer<Modul>, IEnumerable<Modul>, IEnumerator<Modul>
{
    List<Modul> mods = new();
    int pos = -1;
    bool saved;

    public int Count => mods.Count;
    public bool IsDataSaved => saved;

    public Modul this[int i]
    {
        get
        {
            if (i < 0 || i >= Count) throw new IndexOutOfRangeException();
            return mods[i];
        }
        set
        {
            if (i < 0 || i >= Count) throw new IndexOutOfRangeException();
            mods[i] = value;
        }
    }

    public void Add(Modul el) { mods.Add(el); saved = false; }
    public void Delete(Modul el) { mods.Remove(el); saved = false; }

    public void Save(string f)
    {
        File.WriteAllLines(f, mods.Select(m => $"{m.Leader.Name};{m.Name};{m.Size}"));
        saved = true;
    }

    public void Load(string f)
    {
        mods.Clear();
        foreach (var l in File.ReadAllLines(f))
        {
            var p = l.Split(';');
            mods.Add(new Modul(new Person(p[0], "Прізвище", DateTime.Now.AddYears(-20)), p[1], double.Parse(p[2])));
        }
        saved = true;
    }

    public IEnumerator<Modul> GetEnumerator() => this;
    IEnumerator IEnumerable.GetEnumerator() => this;
    public Modul Current => mods[pos];
    object IEnumerator.Current => Current;
    public bool MoveNext() => ++pos < mods.Count;
    public void Reset() => pos = -1;
    public void Dispose() { }
}
