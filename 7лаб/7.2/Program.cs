
using LB7._2;
using System;


class Program
{
    static void Main()
    {
        var reg = new Registry();
        reg.Add(new Plane("Jet", 1000));
        reg.Add(new Plane("Chopper", 700));
        reg.Add(new Balloon("AirBalloon", "Nylon"));
        reg.Add(new MagicCarpet("Rug"));

        Console.WriteLine("-- Всі --");
        reg.PrintAll();

        Console.WriteLine("\n-- З двигуном --");
        reg.PrintWithEngine();

        Console.WriteLine("\n-- Без двигуна --");
        reg.PrintWithoutEngine();

        Console.WriteLine("\n-- Сортування за потужністю --");
        reg.SortByPower();
        reg.PrintAll();

        Console.WriteLine("\n-- Копія перших 2 --");
        reg.CopyFirst(2).PrintAll();
    }
}
