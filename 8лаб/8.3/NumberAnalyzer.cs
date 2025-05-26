using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB8._2
{
     class NumberAnalyzer
    {
        public int [] Numbers { get; set; }
        public NumberAnalyzer (int[]numbers)
        {
            Numbers = numbers;
        }
        public int CountMultiplesOfSeven()
        {
            return Numbers.Count(n => n % 7 == 0);
        }
        public int CountPositiveNumbers()
        {
            return Numbers.Count(n => n > 0);
        }
    }
}
