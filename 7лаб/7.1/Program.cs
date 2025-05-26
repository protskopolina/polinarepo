using LB7._1;
using System;

class Program
{
    static void Main()
    {
        var p = new Project();
        p.Add(new(new("Іван", "Іванов", DateTime.Now.AddYears(-25)), "UI", 200));
        p.Add(new(new("Оля", "Коваль", DateTime.Now.AddYears(-30)), "Backend", 350));
        p.Add(new(new("Тарас", "Сидор", DateTime.Now.AddYears(-27)), "DB", 250));

        Console.WriteLine("--- Всі модулі ---");
        foreach (var m in p) Console.WriteLine(m);
        p.Save("mods.txt");

        var p2 = new Project();
        for (int i = 0; i < Math.Min(2, p.Count); i++)
            p2.Add((Modul)p[i].Clone());

        Console.WriteLine("\n--- Нові модулі ---");
        foreach (var m in p2) Console.WriteLine(m);
        p2.Save("mods2.txt");
    }
}
