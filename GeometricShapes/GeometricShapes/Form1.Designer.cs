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
            this.SuspendLayout();
            // 
            // RectangleBtn
            // 
            this.RectangleBtn.Location = new System.Drawing.Point(120, 376);
            this.RectangleBtn.Name = "RectangleBtn";
            this.RectangleBtn.Size = new System.Drawing.Size(75, 23);
            this.RectangleBtn.TabIndex = 0;
            this.RectangleBtn.Text = "Rectangle";
            this.RectangleBtn.UseVisualStyleBackColor = true;
            // 
            // CircleBtn
            // 
            this.CircleBtn.Location = new System.Drawing.Point(215, 376);
            this.CircleBtn.Name = "CircleBtn";
            this.CircleBtn.Size = new System.Drawing.Size(75, 23);
            this.CircleBtn.TabIndex = 1;
            this.CircleBtn.Text = "Circle";
            this.CircleBtn.UseVisualStyleBackColor = true;
            // 
            // EllipseBtn
            // 
            this.EllipseBtn.Location = new System.Drawing.Point(406, 376);
            this.EllipseBtn.Name = "EllipseBtn";
            this.EllipseBtn.Size = new System.Drawing.Size(75, 23);
            this.EllipseBtn.TabIndex = 2;
            this.EllipseBtn.Text = "Ellipse";
            this.EllipseBtn.UseVisualStyleBackColor = true;
            // 
            // SquareBtn
            // 
            this.SquareBtn.Location = new System.Drawing.Point(313, 376);
            this.SquareBtn.Name = "SquareBtn";
            this.SquareBtn.Size = new System.Drawing.Size(75, 23);
            this.SquareBtn.TabIndex = 3;
            this.SquareBtn.Text = "Square";
            this.SquareBtn.UseVisualStyleBackColor = true;
            // 
            // DrawingSurface
            // 
            this.DrawingSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DrawingSurface.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DrawingSurface.Location = new System.Drawing.Point(12, 12);
            this.DrawingSurface.Name = "DrawingSurface";
            this.DrawingSurface.Size = new System.Drawing.Size(577, 350);
            this.DrawingSurface.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 411);
            this.Controls.Add(this.DrawingSurface);
            this.Controls.Add(this.SquareBtn);
            this.Controls.Add(this.EllipseBtn);
            this.Controls.Add(this.CircleBtn);
            this.Controls.Add(this.RectangleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RectangleBtn;
        private System.Windows.Forms.Button CircleBtn;
        private System.Windows.Forms.Button EllipseBtn;
        private System.Windows.Forms.Button SquareBtn;
        private System.Windows.Forms.Panel DrawingSurface;
    }
}

