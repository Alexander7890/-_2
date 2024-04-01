using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Наслілування_2
{
    public partial class Form1 : Form
    {
        List<Figure> figures = new List<Figure>();

        public class Figure
        {
            public string Type { get; set; }
            public double Area { get; set; }
            public double Perimeter { get; set; }

            // Віртуальні методи для обчислення площі та периметру
            public virtual void CalcArea() { }
            public virtual void CalcPerimeter() { }
        }

        // Клас прямокутника, який успадковує від Figure
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
                Area = Math.Round(Length * Width, 2);
            }

            public override void CalcPerimeter()
            {
                Perimeter = Math.Round(2 * (Length + Width), 2);
            }
        }

        // Клас кола, який успадковує від Figure
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

        // Клас трикутника, який успадковує від Figure
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // Додати прямокутник до колекції та вивести його дані
        private void button1_Click_1(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);
            Rectangle rectangle = new Rectangle(length, width);
            figures.Add(rectangle);
            listBox1.Items.Add($"Type: {rectangle.Type}, Area={rectangle.Area}, Perimeter={rectangle.Perimeter}");
        }
        // Додати коло до колекції та вивести його дані
        private void button2_Click_1(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox3.Text);
            Circle circle = new Circle(radius);
            figures.Add(circle);
            listBox1.Items.Add($"Type: {circle.Type}, Area={Math.Round(circle.Area, 2)}, Perimeter={Math.Round(circle.Perimeter, 2)}");
        }
        // Додати трикутник до колекції та вивести його дані
        private void button3_Click_1(object sender, EventArgs e)
        {

            double side1 = Convert.ToDouble(textBox4.Text);
            double side2 = Convert.ToDouble(textBox5.Text);
            double side3 = Convert.ToDouble(textBox6.Text);
            Triangle triangle = new Triangle(side1, side2, side3);
            figures.Add(triangle);
            listBox1.Items.Add($"Type: {triangle.Type}, Area={Math.Round(triangle.Area, 2)}, Perimeter={Math.Round(triangle.Perimeter, 2)}");
        }
        // Вивести дані про обрану фігуру з колекції
        private void button4_Click_1(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBox7.Text);
            if (index >= 0 && index < figures.Count)
            {
                Figure selectedFigure = figures[index];
                label1.Text = $"Type: {selectedFigure.Type}, Area: {Math.Round(selectedFigure.Area, 2)}";
            }
            else
            {
                MessageBox.Show("Please enter a valid index");
            }
        }
    }
}
