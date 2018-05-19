using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp5
{
    public static class ListOfFigures
    {
        private static List<Figures> list;

        public static int FiguresCount
        {
            get { return list.Count; }
        }

        static ListOfFigures()
        {
            list = new List<Figures>();
        }

        public static void AddFigures(params Figures[] figures)
        {

            foreach (Figures figure in figures)
            {
                list.Add(figure);
            }

        }

        //public static void DrawFigures(Graphics graphics)
        //{

        //    foreach (Figures figure in list)
        //    {
        //        figure.Draw(graphics);
        //    }

        //}

        public static void Clear()
        {
            list.Clear();
        }
    }
}
