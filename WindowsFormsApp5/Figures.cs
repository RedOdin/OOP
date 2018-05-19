using System.Drawing;

namespace WindowsFormsApp5
{
    public abstract class Figures
    {
        protected Point point1;
        protected Pen pen;

        public Figures(int x1, int y1, Pen pen)
        {
            point1 = new Point(x1, y1);
            this.pen = pen;
        }

        public abstract void Draw(Graphics graphics);
    }
}
