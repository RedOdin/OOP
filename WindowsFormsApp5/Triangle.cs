using System.Drawing;


namespace WindowsFormsApp5
{
    class Triangle : Figures
    {
        private Point point2, point3;
        private Point[] pointM;

        public Triangle(int x1, int y1, int x2, int y2, Pen pen) : base(x1, y1, pen)
        {
            point2 = new Point(x2, y2);
            point3 = new Point(x2 - (x2 - x1) * 2, y2);
            pointM = new Point[] { point1, point2, point3 };
        }
    
        public override void Draw(Graphics graphics)
        {
            graphics.DrawPolygon(pen, pointM);
        }
    }
}
