﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricShapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var graphics = DrawingSurface.CreateGraphics();
            var pen = new System.Drawing.Pen(System.Drawing.Color.Lime);
            var shapes = new Shapes(graphics, pen);
        }



    }
}