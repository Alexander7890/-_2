using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наслілування_2
{
    public class Figure
    {
        public string Type { get; set; }
        public double Area { get; set; }
        public double Perimeter { get; set; }

        // Віртуальні методи для обчислення площі та периметру
        public virtual void CalcArea() { }
        public virtual void CalcPerimeter() { }
    }
}
