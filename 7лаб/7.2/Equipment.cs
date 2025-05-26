using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LB7._2.Interfaces;

namespace LB7._2 { 

public abstract class Equipment : IDevice, ICloneable, IComparable<Equipment>
{
    public string Name { get; }
    public bool HasEngine { get; }
    protected Equipment(string name, bool hasEngine) => (Name, HasEngine) = (name, hasEngine);
    public abstract object Clone();
    public abstract int CompareTo(Equipment other);
    public override string ToString() => $"{Name} (Engine: {HasEngine})";
}

public class Plane : Equipment, IEngine
{
    public double Power { get; }
    public Plane(string name, double power) : base(name, true) => Power = power;
    public override object Clone() => new Plane(Name, Power);
    public override int CompareTo(Equipment other) => Name.CompareTo(other.Name);
}

public class Balloon : Equipment, IPart
{
    public string Material { get; }
    public Balloon(string name, string material) : base(name, false) => Material = material;
    public override object Clone() => new Balloon(Name, Material);
    public override int CompareTo(Equipment other) => Name.CompareTo(other.Name);
}

public class MagicCarpet : Equipment
{
    public MagicCarpet(string name) : base(name, false) { }
    public override object Clone() => new MagicCarpet(Name);
    public override int CompareTo(Equipment other) => Name.CompareTo(other.Name);
}
}
