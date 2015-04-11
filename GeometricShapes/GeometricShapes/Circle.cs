using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Circle
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius
        }

        public override void Draw()
        {
            var graphics = System.Windows.Forms.Panel.CreateGraphics();
            graphics.FillEllipse(Brush, new System.Drawing.Rectangle(Left, Top, radius * 2, radius * 2));
        }

    }
}
