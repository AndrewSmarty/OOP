using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Shape
    {
        private Graphics graphics;
        private Pen pen;

        public Pen Pen
        {
            get { return this.pen; }
            set { this.pen = value; }
        }

        public Shape(Graphics graphics, Pen pen)
        {
            this.graphics = graphics;
            this.pen = pen;
        }

        public Rectangle ConstructRectangle(int left, int top, int width, int height)
        {
            this.graphics.DrawRectangle(pen, left, top, width, height);
            return (new Rectangle(pen, left, top, width, height));
        }

        public Circle ConstructCircle(int left, int top, int radius)
        {
            this.graphics.DrawEllipse(pen, left, top, 2*radius, 2*radius);
            return (new Circle(pen, left, top, radius));
        }

        public Square ConstructSquare(int left, int top, int side)
        {
            this.graphics.DrawRectangle(pen, left, top, side, side);
            return (new Square(pen, left, top, side));
        }

        public Ellipse ConstructEllipse(int left, int top, int width, int height)
        {
            this.graphics.DrawEllipse(pen, left, top, width, height);
            return (new Ellipse(pen, left, top, width, height));
        }

        public Triangle ConstructTrianlge(int left, int top, int width, int height)
        {

            var points = new[]
            {
                new Point(left+width/2, top),
                new Point(left+width, top+height), 
                new Point(left, top+height),
                new Point(left+width/2, top),
            };

            this.graphics.DrawLines(pen, points);
            return (new Triangle(pen, points));
        }

    }
}
