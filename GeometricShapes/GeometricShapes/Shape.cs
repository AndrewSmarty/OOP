using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public abstract class Shape
    {
        private System.Drawing.Graphics graphics;
        private System.Drawing.Pen pen;
        private int Left;
        private int Top;
    
        public Shape(System.Drawing.Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

        public void DrawRectangle(int left, int top, int width, int height)
        {
            this.graphics.DrawRectangle(pen, left, top, width, height);
        }

        public void DrawCircle(int left, int top, int radius)
        {
            this.graphics.DrawEllipse(pen, left, top, 2*radius, 2*radius);
        }

        public void DrawSquare(int left, int top, int side)
        {
            this.graphics.DrawRectangle(pen, left, top, side, side);
        }

        public void DrawEllipse(int left, int top, int width, int height)
        {
            this.graphics.DrawEllipse(pen, left, top, width, height);
        }

        public abstract void Draw();
    }
}
