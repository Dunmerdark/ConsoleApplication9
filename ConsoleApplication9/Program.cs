using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;
using System.Windows.Forms;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(72, 34);

            string output = "X coordinate is: " + point.X +
                "\nY coordinate is: " + point.Y;

            point.X = 10;
            point.Y = 10;
            output += "\n\nThe new coordinate is " + point;

            MessageBox.Show(output, "Demonstration Class Point");

            Circle1 circle1 = new Circle1(23, 35, 5);

            output = "X coordinate is: " + circle1.X +
                "\nY coordinate is: " + circle1.Y +
                "\nOr another variant: " + circle1 +
                "\nRadius is: " + circle1.RADIUS +
                "\nDiameter is: " + String.Format("{0:F}", circle1.Diameter()) +
                "\nArea is: " + String.Format("{0:F}", circle1.Area()) +
                "\nCircumference is: " + String.Format("{0:F}", circle1.Circumference());

            MessageBox.Show(output, "Demonstration Class Circle1");


        }
    }
}
