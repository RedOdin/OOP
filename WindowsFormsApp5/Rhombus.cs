using System.Drawing;


namespace WindowsFormsApp5
{
    public class Rhombus : Figures
    {
        private Point point2, point3, point4;

        public Rhombus(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, pen)
        {
            point2 = new Point(x2, y2);
            point3 = new Point(point1.X, point2.Y + (point2.Y - point1.Y));
            point4 = new Point(point1.X - (point2.X - point1.X), point2.Y);
        }

        public override void Draw(Graphics graphics)
        {
            Point[] points = { point1, point2, point3, point4 };
            graphics.DrawPolygon(pen, points);
        }
    }
}
