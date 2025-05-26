using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._2
{
    class Interfaces
    {
        public interface IDevice { string Name { get; } bool HasEngine { get; } }
        public interface IEngine { double Power { get; } }
        public interface IPart { string Material { get; } }

    }
}
