using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Person : IComparable<Person>, ICloneable
{
    public string Name, LastName;
    public DateTime BDate;

    public Person(string name, string last, DateTime date) => (Name, LastName, BDate) = (name, last, date);
    public int CompareTo(Person o) => LastName.CompareTo(o.LastName);
    public object Clone() => new Person(Name, LastName, BDate);
    public override string ToString() => $"{Name} {LastName} ({BDate:dd.MM.yyyy})";
}