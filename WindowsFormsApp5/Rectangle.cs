using System.Drawing;

namespace WindowsFormsApp5
{
    public class Rectangle : Figures
    {
        private int width, height;

        public Rectangle(int x1, int y1, int width, int height, Pen pen) : base(x1, y1, pen)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics graphics)
        {
            graphics.DrawRectangle(pen, point1.X, point1.Y, width, height);
        }
    }
}
