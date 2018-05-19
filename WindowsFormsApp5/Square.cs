using System.Drawing;

namespace WindowsFormsApp5
{
    public class Square : Rectangle
    {
        public Square(int x1, int y1, int side, Pen pen) : base(x1, y1, side, side, pen) { }
    }
}
