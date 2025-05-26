using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB8._2
{
    class DateChecker
    {
        public Func<int, bool>
            IsProgrammersDay => day => day == 256;
    }
}
