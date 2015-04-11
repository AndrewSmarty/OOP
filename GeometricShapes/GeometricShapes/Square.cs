using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    public class Square : Shape
    {
        private int side;

        public Square()
        {
            
        }

        public override void Draw()
        {
            var graphics = System.Windows.Forms.Panel.CreateGraphics();
            graphics.FillRectangle(Brush, new System.Drawing.Rectangle(Left, Top, side, side));
        }

    }
}
