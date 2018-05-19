using System.Drawing;

namespace WindowsFormsApp5
{
    class Ellipse : Figures
    {
        private int width, height;

        public Ellipse(int x1, int y1, int width, int height, Pen pen) : base(x1, y1, pen)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawEllipse(pen, point1.X, point1.Y, width, height);
        }

    }
}
