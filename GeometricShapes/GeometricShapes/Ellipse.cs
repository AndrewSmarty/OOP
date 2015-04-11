using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Ellipse : Circle
    {
        private int width;
        private int height;

        public Ellipse()
        {
            
        }

        public override void Draw()
        {
            var graphics = System.Windows.Forms.Panel.CreateGraphics();
            graphics.FillRectangle(Brush, new System.Drawing.Rectangle(Left, Top, width, height));
        }

    }
}
