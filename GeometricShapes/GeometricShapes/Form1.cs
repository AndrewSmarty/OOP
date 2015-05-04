using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private DrawingMethod DrawSpecifiedShape;

        private Shape shape;

        public Form1()
        {
            InitializeComponent();
            InitializeFields();
            //this.textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            //this.textBox2.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }

        private void InitializeFields()
        {
            left = top = width = height = 0;
            DrawSpecifiedShape = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SendMessage(textBox1.Handle, EM_SETCUEBANNER, 0, "Width");
            SendMessage(textBox2.Handle, EM_SETCUEBANNER, 0, "Height");

            var graphics = DrawingSurface.CreateGraphics();
            var pen = new System.Drawing.Pen(System.Drawing.Color.Yellow);
            shape = new Shape(graphics, pen);
            //var paintMan = new PaintMan();
            //paintMan.SetShapesStruct(shape);
        }

        /****************     Draw  Events     **********************/

        private void DrawRectangle()
        {
            var Rect = shape.ConstructRectangle(left, top, width, height);
            
        }

        private void DrawCircle()
        {
            shape.ConstructCircle(left, top, width / 2);
        }

        private void DrawSquare()
        {
            shape.ConstructSquare(left, top, width);
        }

        private void DrawEllipse()
        {
            shape.ConstructEllipse(left, top, width, height);
        }

        private void DrawTriangle()
        {
            shape.ConstructTrianlge(left, top, width, height);
        }

        /****************    Click Events     **********************/
  
        private void RectangleBtn_Click(object sender, EventArgs e)
        {
            DrawSpecifiedShape = DrawRectangle;
        }

        private void SquareBtn_Click(object sender, EventArgs e)
        {
            DrawSpecifiedShape = DrawSquare;
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            DrawSpecifiedShape = DrawEllipse;
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            DrawSpecifiedShape = DrawCircle;
        }

        private void TriangleBtn_Click(object sender, EventArgs e)
        {
            DrawSpecifiedShape = DrawTriangle;
        }

        private void ClrSurfaceBtn_Click(object sender, EventArgs e)
        {
            DrawingSurface.Refresh();
        }

        private void ColorPaletteBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorPaletteBtn.BackColor = colorDialog1.Color;
                shape.Pen = new Pen(colorDialog1.Color);
            }
        }

        private void DrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (DrawSpecifiedShape == null || textBox1.Text == "" || textBox2.Text == "") return;

            left = e.X;
            top = e.Y;
            width = int.Parse(textBox1.Text);
            height = int.Parse(textBox2.Text);

            DrawSpecifiedShape();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            DropLetters();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            DropLetters();
        }

        private void DropLetters()
        {
            this.textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }        
    }
}
