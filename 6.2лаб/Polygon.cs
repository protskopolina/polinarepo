using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ6._2
{
    
        public abstract class Polygon
        {
            public string Name { get; protected set; }
            public double[] Sides { get; protected set; }

            protected Polygon(string name, params double[] sides)
            {
                if (sides.Length < 3)
                    throw new ArgumentException("Полігон повинен мати щонайменше 3 сторони");

                if (sides.Any(s => s <= 0))
                    throw new ArgumentException("Довжина сторін повинна бути додатною");

                Name = name;
                Sides = sides;
            }

            public abstract double GetPerimeter();

            public override string ToString()
            {
                return $"{Name}: Сторони = [{string.Join(", ", Sides)}], Периметр = {GetPerimeter():F2}";
            }
        }

    }

