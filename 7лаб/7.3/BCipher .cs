using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._3
{
    public class BCipher : ICipher
    {
        // Алфавіт (великий і малий)
        const string upper = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
        const string lower = "абвгґдеєжзиіїйклмнопрстуфхцчшщьюя";

        // Шифрування - заміна на дзеркальну літеру з кінця алфавіту
        public string Encode(string text) =>
            new string(text.Select(Mirror).ToArray());

        // Дешифрування - дзеркальне шифрування (саме так)
        public string Decode(string text) =>
            Encode(text); // Дешифрування те ж саме, бо дзеркальний процес
        private char Mirror(char c)
        {
            int i;

            // Перевірка для великих літер
            if ((i = upper.IndexOf(c)) != -1)
                return upper[upper.Length - 1 - i];  // Використовуємо довжину для отримання символу з кінця

            // Перевірка для малих літер
            if ((i = lower.IndexOf(c)) != -1)
                return lower[lower.Length - 1 - i];  // Використовуємо довжину для отримання символу з кінця

            // Якщо символ не літера, залишаємо його без змін
            return c;
        }

    }
}
           