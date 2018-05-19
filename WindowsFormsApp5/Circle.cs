using System.Drawing;

namespace WindowsFormsApp5
{
    class Circle : Ellipse
    {
        public Circle(int x1, int y1, int diameter, Pen pen) : base(x1, y1, diameter, diameter, pen) { }
    }
}
