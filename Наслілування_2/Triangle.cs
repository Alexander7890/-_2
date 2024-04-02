using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Наслілування_2.Form1;

namespace Наслілування_2
{
    public class Triangle : Figure
    {
        private double Side1 { get; set; }
        private double Side2 { get; set; }
        private double Side3 { get; set; }

        public Triangle(double side1, double side2, double side3)
        {
            Type = "Triangle";
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            CalcArea();
            CalcPerimeter();
        }

        public override void CalcArea()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            Area = Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public override void CalcPerimeter()
        {
            Perimeter = Side1 + Side2 + Side3;
        }
    }
}
