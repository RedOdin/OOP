using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Main : Form
    {
        private Bitmap bitmap;
        private Graphics graphics;
        private Pen pen;

        private readonly Color standardColor = Color.Blue;
        private readonly float standardThickness = 3;

        private Color color = Color.Blue;
        private float thickness = 3;

        private bool mouseIsDown = false;
        private int x1, y1, x2, y2, width, height;

        private Figures newFigure;
        private int figureType = 0;


        public Main()
        {
            InitializeComponent();
            Init();
            pen = new Pen(color, thickness);
        }

        private void Init()
        {
            bitmap = new Bitmap(MysticalDraw.Width, MysticalDraw.Height);
            graphics = Graphics.FromImage(bitmap);
            MysticalDraw.Image = bitmap;
        }

        private void MysticalDraw_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;

            x1 = x2 = e.X;
            y1 = y2 = e.Y;
        }


        private void MysticalDraw_MouseLeave(object sender, EventArgs e)
        {
            //  pen = new Pen(color, thickness);
        }

        private void MysticalDraw_MouseMove(object sender, MouseEventArgs e)
        {

            if (mouseIsDown)
            {

                if (figureType == 1)
                {
                    x1 = x2;
                    y1 = y2;
                }

                x2 = e.X;
                y2 = e.Y;

                MysticalDraw.Invalidate();

            }
        }

        private void MysticalDraw_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;

            x1 = y1 = x2 = y2 = -1;

            if (newFigure != null && figureType != 1)
            {
                ListOfFigures.AddFigures(newFigure);
            }
        }

        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figureType = 2;
        }

        private void MysticalDraw_Paint(object sender, PaintEventArgs e)
        {
            if (x1 >= 0 && y1 >= 0 && x2 >= 0 && y2 >= 0)
            {

                width = Math.Abs(x1 - x2);
                height = Math.Abs(y1 - y2);

                switch (figureType)
                {

                    case 0:
                        return;

                    case 1:
                        newFigure = new Line(x1, y1, x2, y2, pen);

                        if (newFigure != null)
                        {
                            ListOfFigures.AddFigures(newFigure);
                        }

                        break;

                    case 2:
                        newFigure = new Line(x1, y1, x2, y2, pen);
                        break;

                        //case 3:
                        //    newFigure = new Ellipse(x1, y1, width, height, pen);
                        //    break;

                        //case 4:
                        //    newFigure = new Circle(x1, y1, (width <= height) ? width : height, pen);
                        //    break;

                        //case 5:
                        //    newFigure = new Rectangle(x1, y1, width, height, pen);
                        //    break;

                        //case 6:
                        //    newFigure = new Square(x1, y1, (width <= height) ? width : height, pen);
                        //    break;

                        //case 7:
                        //    newFigure = new Rhombus(x1, y1, x2, y2, pen);
                        //    break;

                }

                if (figureType != 1)
                {
                    Init();
                    ListOfFigures.DrawFigures(graphics);
                }

                newFigure.Draw(graphics);

            }
        }
    }
}
