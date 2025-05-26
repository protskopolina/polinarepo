using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ6._1 { 
    //Трикутник
public class Triangle
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }

        public Triangle(double a, double b, double c)
        {
            SetSides(a, b, c);
        }

        // Метод для зміни сторін
        public void SetSides(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("Сторони не утворюють трикутник");
            }
        }

        // Метод для обчислення площі (за формулою Герона)
        public double GetArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }

        // Метод для обчислення кутів (в радіанах -> градусах)
        public (double Alpha, double Beta, double Gamma) GetAngles()
        {
            double alpha = Math.Acos((B * B + C * C - A * A) / (2 * B * C));
            double beta = Math.Acos((A * A + C * C - B * B) / (2 * A * C));
            double gamma = Math.Acos((A * A + B * B - C * C) / (2 * A * B));

            // Перетворимо в градуси
            return (
                Math.Round(alpha * 180 / Math.PI, 2),
                Math.Round(beta * 180 / Math.PI, 2),
                Math.Round(gamma * 180 / Math.PI, 2)
            );
        }

        public override string ToString()
        {
            var (alpha, beta, gamma) = GetAngles();
            return $"Трикутник: A={A}, B={B}, C={C}, Площа={GetArea():F2}, " +
                   $"Кути: α={alpha}°, β={beta}°, γ={gamma}°";
        }
    }

}
