using System;
using System.Drawing;

namespace GridSearch.Domain.Geometry
{
    public struct Square
    {
        public Square(int centerX, int centerY, int sideSize)
        {
            Center = new Point(centerX, centerY);
            SideSize = sideSize;
        }

        public Point Center { get; private set; }
        public int SideSize { get; private set; }

        private int SideHalfSize
        {
            get { return SideSize / 2; }
        }

        public Point TopLeft
        {
            get
            {
                int x = Center.X - SideHalfSize;
                int y = Center.Y + SideHalfSize;

                return new Point(x, y);
            }
        }

        public Point BottomLeft
        {
            get
            {
                int x = Center.X + SideHalfSize;
                int y = Center.Y - SideHalfSize;

                return new Point(x, y);
            }
        }

        public bool IsInside(Point point)
        {
            bool inX = false;
            bool inY = false;

            if (point.X >= TopLeft.X && point.X <= BottomLeft.X)
            {
                inX = true;
            }

            if (point.Y >= BottomLeft.Y && point.Y <= TopLeft.Y)
            {
                inY = true;
            }

            return inX && inY;
        }

        public static bool IsInside(int pointX, int pointY, Square square)
        {
            return square.IsInside(new Point(pointX, pointY));
        }
    }

}
