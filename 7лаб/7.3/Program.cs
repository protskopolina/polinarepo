using LB7._3;

class Program
{
    static void Main()
    {
        // Оригінальний текст
        string original = "ПРИВІТ, СВІТ!";

        // Створення об'єктів шифраторів
        ICipher a = new ACipher();  // Шифрування з зсувом
        ICipher b = new BCipher();  // Шифрування через дзеркальну заміну

        // Демонстрація шифрування та дешифрування для ACipher
        Console.WriteLine("--- ACipher ---");
        var aEnc = a.Encode(original);  // Шифруємо
        Console.WriteLine("Encoded: " + aEnc);
        Console.WriteLine("Decoded: " + a.Decode(aEnc));  // Дешифруємо

        // Демонстрація шифрування та дешифрування для BCipher
        Console.WriteLine("\n--- BCipher ---");
        var bEnc = b.Encode(original);  // Шифруємо
        Console.WriteLine("Encoded: " + bEnc);
        Console.WriteLine("Decoded: " + b.Decode(bEnc));  // Дешифруємо
    }
}
