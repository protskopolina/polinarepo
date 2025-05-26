using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ6._2
{
        public class Triangle : Polygon
        {
            public Triangle(double a, double b, double c)
                : base("Трикутник", a, b, c) { }

            public override double GetPerimeter() => Sides.Sum();
        }

    }

