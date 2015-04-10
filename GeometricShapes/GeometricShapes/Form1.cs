using System;
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
        private int left, top, width, height;
        private delegate void method();

        private method drawingMethod();

        public Form1()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            left = 0;
            top = 0;
            width = 0;
            height = 0;
            drawingMethod = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var graphics = DrawingSurface.CreateGraphics();
            var pen = new System.Drawing.Pen(System.Drawing.Color.Lime);
            var shapes = new Shapes(graphics, pen);
        }

        public void DrawRectangle()
        {
            
        }
    }
}
