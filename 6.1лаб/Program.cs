using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ6._1
{
   
class Program
    {
        static void Main()
        {
            // Звичайний трикутник
            Triangle t = new Triangle(3, 4, 5);
            Console.WriteLine(t);

            Console.WriteLine();

            // Рівнобедрений трикутник
            IsoscelesTriangle iso = new IsoscelesTriangle(5, 6);
            Console.WriteLine(iso);
        }
    }
}
