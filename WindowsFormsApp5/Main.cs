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

        private void MysticalDraw_MouseDown(object sender, MouseEventArgs e)
        {
            mouseIsDown = true;

            x1 = x2 = e.X;
            y1 = y2 = e.Y;
        }

        private void MysticalDraw_MouseLeave(object sender, EventArgs e)
        {
            pen = new Pen(color, thickness);
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
    }
}
