using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._3
{
    
        public class ACipher : ICipher
        {
            // Шифрування - зсув на одну позицію вперед
            public string Encode(string text) =>
                new string(text.Select(ShiftUp).ToArray());

            // Дешифрування - зсув на одну позицію назад
            public string Decode(string text) =>
                new string(text.Select(ShiftDown).ToArray());

            // Метод для зсуву символу вперед по алфавіту
            private char ShiftUp(char c) =>
                c switch
                {
                    >= 'А' and <= 'Я' => c == 'Я' ? 'А' : (char)(c + 1),  // Великі літери
                    >= 'а' and <= 'я' => c == 'я' ? 'а' : (char)(c + 1),  // Малі літери
                    _ => c // Якщо символ не буква, залишити його без змін
                };

            // Метод для зсуву символу назад по алфавіту
            private char ShiftDown(char c) =>
                c switch
                {
                    >= 'А' and <= 'Я' => c == 'А' ? 'Я' : (char)(c - 1),  // Великі літери
                    >= 'а' and <= 'я' => c == 'а' ? 'я' : (char)(c - 1),  // Малі літери
                    _ => c // Якщо символ не буква, залишити його без змін
                };
        }

    }

