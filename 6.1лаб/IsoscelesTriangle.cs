using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ6._1
{//Рівнобедренний трикутник
        public class IsoscelesTriangle : Triangle
        {
            public double Area { get;  set; }

            public IsoscelesTriangle(double equalSide, double baseSide)
                : base(equalSide, baseSide, equalSide)
            {
                Area = GetArea();
            }

            public double GetPerimeter()
            {
                return A + B + C;
            }

            public override string ToString()
            {
                return $"Рівнобедрений трикутник:\n" +
                       $"Сторони: A={A}, B={B}, C={C}\n" +
                       $"Площа: {Area:F2}, Периметр: {GetPerimeter():F2}";
            }
        }

    }
