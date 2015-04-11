﻿using System;
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

        public Ellipse(Pen pen, int left, int right, int width, int height):base(pen, left, right, width)
        {
            this.width = width;
            this.height = height;
        }

    }
}
