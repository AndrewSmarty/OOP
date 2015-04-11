using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeometricShapes
{
    public partial class Form1 : Form
    {
        //placeholders for textboxes
        private const int EM_SETCUEBANNER = 0x1501;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);
       
        
        private int left, top, width, height;

        private delegate void DrawingMethod();
        private DrawingMethod drawSpecifiedShape;

        private Shape shapes;

        public Form1()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            left = top = width = height = 0;
            drawSpecifiedShape = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Width");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 0, "Height");

            var graphics = DrawingSurface.CreateGraphics();
            var pen = new System.Drawing.Pen(System.Drawing.Color.Lime);
            shapes = new Shape(graphics, pen);
        }

        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            drawSpecifiedShape = Rectangle;
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            drawSpecifiedShape = Square;
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            drawSpecifiedShape = Ellipse;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            drawSpecifiedShape = Circle;
        }

        private void DrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            left = e.X;
            top = e.Y;
            width = int.Parse(textBox1.Text);
            height = int.Parse(textBox2.Text);

            drawSpecifiedShape();
        }

        private void Rectangle()
        {
            shapes.DrawRectangle(left, top, width, height);
        }

        private void Circle()
        {
            shapes.DrawCircle(left, top, width/2);
        }

        private void Square()
        {
            shapes.DrawSquare(left, top, width);
        }

        private void Ellipse()
        {
            shapes.DrawEllipse(left, top, width, height);
        }

        private void ClrSurfaceBtn_Click(object sender, EventArgs e)
        {
            DrawingSurface.Refresh();
        }


    }
}
