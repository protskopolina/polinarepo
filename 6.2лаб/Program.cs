using System;
using System.Collections.Generic;
using System.Linq;
using ЛБ6._2;

class Program
{
    static void Main()
    {
        List<Polygon> shapes = new List<Polygon>
        {
            new Triangle(3, 4, 5),
            new Quadrilateral(2, 3, 4, 5),//чотирикутник
            new Square(6),//квадрат
            new Triangle(7, 8, 9),
            new Square(2),
            new Quadrilateral(10, 10, 10, 10)
        };

        try
        {
            Console.Write("Введіть мінімальну довжину сторони: ");
            if (double.TryParse(Console.ReadLine(), out double minLength))
            {
                var result = shapes.Where(s => s.Sides.Any(side => side >= minLength)).ToList();

                if (result.Any())
                {
                    Console.WriteLine("\n Результат запиту:");
                    result.ForEach(shape => Console.WriteLine(shape));
                }
                else
                {
                    Console.WriteLine("Немає фігур з стороною ≥ заданого значення.");
                }
            }
            else
            {
                Console.WriteLine("Некоректне число.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Помилка]: {ex.Message}");
        }
    }
}
