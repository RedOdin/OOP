using System.Drawing;

namespace WindowsFormsApp5
{
    public class Line : Figures
    {
        private Point point2;

        public Line(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, pen)
        {
            point2 = new Point(x2, y2);
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawLine(pen, point1, point2);
        }
    }
}
