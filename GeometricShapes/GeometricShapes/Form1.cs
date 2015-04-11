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

        private delegate void DrawingMethod(int left, int top, int width, int height);
        private DrawingMethod drawShape;

        private Shapes shapes;

        public Form1()
        {
            InitializeComponent();
            InitializeFields();
        }

        private void InitializeFields()
        {
            left = top = width = height = 0;
            drawShape = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Width");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 0, "Height");

            var graphics = DrawingSurface.CreateGraphics();
            var pen = new System.Drawing.Pen(System.Drawing.Color.Lime);
            shapes = new Shapes(graphics, pen);
        }

        private void Rectangle(int left, int top, int width, int height)
        {

        }

        private void Circle(int left, int top, int radius)
        {

        }

        private void Square(int left, int top, int side)
        {

        }

        private void Ellipse(int left, int top, int width, int height)
        {

        }


        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            drawShape = Rectangle;
        }

        private void DrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            drawShape();
        }
    

    }
}
