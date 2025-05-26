using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ6._2
{//чотирикутник
   
        public class Quadrilateral : Polygon
        {
            public Quadrilateral(double a, double b, double c, double d)
                : base("Чотирикутник", a, b, c, d) { }

            public override double GetPerimeter() => Sides.Sum();
        }

    }
