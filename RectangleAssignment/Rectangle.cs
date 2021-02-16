using System;
namespace RectangleAssignment
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }

        public int GetLength() { return length; }

        public int GetWidth() { return width; }

        public int GetPerimeter() { return (2*length + 2*width); }

        public int GetArea() { return length * width; }

        public int setLength(int len) { length = len; return length; }

        public int setWidth(int wid) { width = wid; return width; }


    }
}
