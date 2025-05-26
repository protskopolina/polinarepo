using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ6._2
{//квадрат
    
        public class Square : Quadrilateral
        {
            public Square(double side)
                : base(side, side, side, side)
            {
                Name = "Квадрат";
            }
        }

    }

