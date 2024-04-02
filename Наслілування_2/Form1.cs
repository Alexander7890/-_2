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
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // Додавання прямокутник до колекції та виведення його даних
        private void button1_Click_1(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(textBox1.Text);
            double width = Convert.ToDouble(textBox2.Text);
            Rectangle rectangle = new Rectangle(length, width);
            figures.Add(rectangle);
            listBox1.Items.Add($"Type: {rectangle.Type}, Area={rectangle.Area}, Perimeter={rectangle.Perimeter}");
        }

        // Додавання коло до колекції та виведення його даних
        private void button2_Click_1(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(textBox3.Text);
            Circle circle = new Circle(radius);
            figures.Add(circle);
            listBox1.Items.Add($"Type: {circle.Type}, Area={circle.Area}, Perimeter={circle.Perimeter}");
        }

        // Додавання трикутник до колекції та виведення його даних
        private void button3_Click_1(object sender, EventArgs e)
        {
            double side1 = Convert.ToDouble(textBox4.Text);
            double side2 = Convert.ToDouble(textBox5.Text);
            double side3 = Convert.ToDouble(textBox6.Text);
            Triangle triangle = new Triangle(side1, side2, side3);
            figures.Add(triangle);
            listBox1.Items.Add($"Type: {triangle.Type}, Area={triangle.Area}, Perimeter={triangle.Perimeter}");
        }

        // Вивід даних про обрану фігуру з колекції
        private void button4_Click_1(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(textBox7.Text);
            if (index >= 0 && index < figures.Count)
            {
                Figure selectedFigure = figures[index];
                label1.Text = $"Type: {selectedFigure.Type}, Area: {selectedFigure.Area}";
            }
            else
            {
                MessageBox.Show("Please enter a valid index");
            }
        }
    }
}
