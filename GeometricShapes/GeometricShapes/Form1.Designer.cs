namespace GeometricShapes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RectangleBtn = new System.Windows.Forms.Button();
            this.CircleBtn = new System.Windows.Forms.Button();
            this.EllipseBtn = new System.Windows.Forms.Button();
            this.SquareBtn = new System.Windows.Forms.Button();
            this.DrawingSurface = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.ClrSurfaceBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorPaletteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.Location = new System.Drawing.Point(12, 377);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(98, 23);
            this.RectangleBtn.TabIndex = 0;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            this.RectangleBtn.Click += new System.EventHandler(this.RectangleBtn_Click);
            // 
            // CircleBtn
            // 
            this.CircleBtn.Location = new System.Drawing.Point(12, 407);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(98, 23);
            this.CircleBtn.TabIndex = 1;
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            this.CircleBtn.Click += new System.EventHandler(this.CircleBtn_Click);
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.Location = new System.Drawing.Point(133, 407);
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(102, 23);
            this.EllipseBtn.TabIndex = 2;
            this.EllipseBtn.Text = "Ellipse";
            this.EllipseBtn.UseVisualStyleBackColor = true;
            this.EllipseBtn.Click += new System.EventHandler(this.EllipseBtn_Click);
            // 
            // SquareBtn
            // 
            this.SquareBtn.Location = new System.Drawing.Point(133, 378);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(102, 23);
            this.SquareBtn.TabIndex = 3;
            this.SquareBtn.Text = "Square";
            this.SquareBtn.UseVisualStyleBackColor = true;
            this.SquareBtn.Click += new System.EventHandler(this.SquareBtn_Click);
            // 
            // DrawingSurface
            // 
            this.DrawingSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawingSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingSurface.Location = new System.Drawing.Point(12, 12);
            this.DrawingSurface.Name = "DrawingSurface";
            this.DrawingSurface.Size = new System.Drawing.Size(577, 350);
            this.DrawingSurface.TabIndex = 4;
            this.DrawingSurface.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawingSurface_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 380);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 410);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // ClrSurfaceBtn
            // 
            this.ClrSurfaceBtn.Location = new System.Drawing.Point(492, 383);
            this.ClrSurfaceBtn.Name = "ClrSurfaceBtn";
            this.ClrSurfaceBtn.Size = new System.Drawing.Size(75, 52);
            this.ClrSurfaceBtn.TabIndex = 7;
            this.ClrSurfaceBtn.Text = "Clear Surface";
            this.ClrSurfaceBtn.UseVisualStyleBackColor = true;
            this.ClrSurfaceBtn.Click += new System.EventHandler(this.ClrSurfaceBtn_Click);
            // 
            // ColorPaletteBtn
            // 
            this.ColorPaletteBtn.BackColor = System.Drawing.Color.Yellow;
            this.ColorPaletteBtn.Location = new System.Drawing.Point(405, 407);
            this.ColorPaletteBtn.Name = "ColorPaletteBtn";
            this.ColorPaletteBtn.Size = new System.Drawing.Size(41, 23);
            this.ColorPaletteBtn.TabIndex = 8;
            this.ColorPaletteBtn.UseVisualStyleBackColor = false;
            this.ColorPaletteBtn.Click += new System.EventHandler(this.ColorPaletteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose a color";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorPaletteBtn);
            this.Controls.Add(this.ClrSurfaceBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DrawingSurface);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.EllipseBtn);
            this.Controls.Add(this.CircleBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button EllipseBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Panel DrawingSurface;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ClrSurfaceBtn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorPaletteBtn;
        private System.Windows.Forms.Label label1;
    }
}

