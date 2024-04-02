using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Наслілування_2.Form1;

namespace Наслілування_2
{
    public class Rectangle : Figure
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Type = "Rectangle";
            Length = length;
            Width = width;
            CalcArea();
            CalcPerimeter();
        }

        public override void CalcArea()
        {
            Area = Length * Width;
        }

        public override void CalcPerimeter()
        {
            Perimeter = 2 * (Length + Width);
        }
    }
}
