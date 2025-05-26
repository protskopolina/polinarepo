using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB7._3
{
    
        public interface ICipher
        {
            // Шифрування рядка
            string Encode(string text);

            // Дешифрування рядка
            string Decode(string text);
        }

    }

