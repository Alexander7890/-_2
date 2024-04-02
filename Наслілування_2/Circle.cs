using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Наслілування_2.Form1;

namespace Наслілування_2
{
    public class Circle : Figure
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Type = "Circle";
            Radius = radius;
            CalcArea();
            CalcPerimeter();
        }

        public override void CalcArea()
        {
            Area = Math.PI * Radius * Radius;
        }

        public override void CalcPerimeter()
        {
            Perimeter = 2 * Math.PI * Radius;
        }
    }
}
