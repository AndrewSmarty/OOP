namespace Serialization
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
            this.CreateFishPanel = new System.Windows.Forms.Panel();
            this.ResultFishesPanel = new System.Windows.Forms.Panel();
            this.CreateFishBtn = new System.Windows.Forms.Button();
            this.DeleteFishesBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.Sackgill = new System.Windows.Forms.RadioButton();
            this.Barbus = new System.Windows.Forms.RadioButton();
            this.Clown = new System.Windows.Forms.RadioButton();
            this.Guppi = new System.Windows.Forms.RadioButton();
            this.LoadFishesBtn = new System.Windows.Forms.Button();
            this.SaveFishesBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateFishPanel
            // 
            this.CreateFishPanel.AutoScroll = true;
            this.CreateFishPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateFishPanel.Location = new System.Drawing.Point(269, 5);
            this.CreateFishPanel.Name = "CreateFishPanel";
            this.CreateFishPanel.Size = new System.Drawing.Size(238, 267);
            this.CreateFishPanel.TabIndex = 0;
            // 
            // ResultFishesPanel
            // 
            this.ResultFishesPanel.AutoScroll = true;
            this.ResultFishesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultFishesPanel.Location = new System.Drawing.Point(6, 5);
            this.ResultFishesPanel.Name = "ResultFishesPanel";
            this.ResultFishesPanel.Size = new System.Drawing.Size(257, 307);
            this.ResultFishesPanel.TabIndex = 1;
            // 
            // CreateFishBtn
            // 
            this.CreateFishBtn.Location = new System.Drawing.Point(269, 377);
            this.CreateFishBtn.Name = "CreateFishBtn";
            this.CreateFishBtn.Size = new System.Drawing.Size(238, 24);
            this.CreateFishBtn.TabIndex = 2;
            this.CreateFishBtn.Text = "Create Fish";
            this.CreateFishBtn.UseVisualStyleBackColor = true;
            this.CreateFishBtn.Click += new System.EventHandler(this.CreateFishBtn_Click);
            // 
            // DeleteFishesBtn
            // 
            this.DeleteFishesBtn.Location = new System.Drawing.Point(6, 377);
            this.DeleteFishesBtn.Name = "DeleteFishesBtn";
            this.DeleteFishesBtn.Size = new System.Drawing.Size(257, 24);
            this.DeleteFishesBtn.TabIndex = 3;
            this.DeleteFishesBtn.Text = "Delete Fishes";
            this.DeleteFishesBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.radioButton5);
            this.panel3.Controls.Add(this.Sackgill);
            this.panel3.Controls.Add(this.Barbus);
            this.panel3.Controls.Add(this.Clown);
            this.panel3.Controls.Add(this.Guppi);
            this.panel3.Location = new System.Drawing.Point(269, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 93);
            this.panel3.TabIndex = 4;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(14, 61);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(85, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Sackgill
            // 
            this.Sackgill.AutoSize = true;
            this.Sackgill.Location = new System.Drawing.Point(14, 38);
            this.Sackgill.Name = "Sackgill";
            this.Sackgill.Size = new System.Drawing.Size(62, 17);
            this.Sackgill.TabIndex = 3;
            this.Sackgill.TabStop = true;
            this.Sackgill.Text = "Sackgill";
            this.Sackgill.UseVisualStyleBackColor = true;
            this.Sackgill.CheckedChanged += new System.EventHandler(this.Sackgill_CheckedChanged);
            // 
            // Barbus
            // 
            this.Barbus.AutoSize = true;
            this.Barbus.Location = new System.Drawing.Point(14, 14);
            this.Barbus.Name = "Barbus";
            this.Barbus.Size = new System.Drawing.Size(58, 17);
            this.Barbus.TabIndex = 2;
            this.Barbus.TabStop = true;
            this.Barbus.Text = "Barbus";
            this.Barbus.UseVisualStyleBackColor = true;
            this.Barbus.CheckedChanged += new System.EventHandler(this.Barbus_CheckedChanged);
            // 
            // Clown
            // 
            this.Clown.AutoSize = true;
            this.Clown.Location = new System.Drawing.Point(150, 37);
            this.Clown.Name = "Clown";
            this.Clown.Size = new System.Drawing.Size(54, 17);
            this.Clown.TabIndex = 1;
            this.Clown.TabStop = true;
            this.Clown.Text = "Clown";
            this.Clown.UseVisualStyleBackColor = true;
            this.Clown.CheckedChanged += new System.EventHandler(this.Clown_CheckedChanged);
            // 
            // Guppi
            // 
            this.Guppi.AutoSize = true;
            this.Guppi.Location = new System.Drawing.Point(150, 14);
            this.Guppi.Name = "Guppi";
            this.Guppi.Size = new System.Drawing.Size(53, 17);
            this.Guppi.TabIndex = 0;
            this.Guppi.TabStop = true;
            this.Guppi.Text = "Guppi";
            this.Guppi.UseVisualStyleBackColor = true;
            this.Guppi.CheckedChanged += new System.EventHandler(this.Guppi_CheckedChanged);
            // 
            // LoadFishesBtn
            // 
            this.LoadFishesBtn.Location = new System.Drawing.Point(6, 318);
            this.LoadFishesBtn.Name = "LoadFishesBtn";
            this.LoadFishesBtn.Size = new System.Drawing.Size(257, 24);
            this.LoadFishesBtn.TabIndex = 5;
            this.LoadFishesBtn.Text = "Load Fishes";
            this.LoadFishesBtn.UseVisualStyleBackColor = true;
            // 
            // SaveFishesBtn
            // 
            this.SaveFishesBtn.Location = new System.Drawing.Point(6, 348);
            this.SaveFishesBtn.Name = "SaveFishesBtn";
            this.SaveFishesBtn.Size = new System.Drawing.Size(257, 23);
            this.SaveFishesBtn.TabIndex = 6;
            this.SaveFishesBtn.Text = "Save Fishes";
            this.SaveFishesBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 406);
            this.Controls.Add(this.SaveFishesBtn);
            this.Controls.Add(this.LoadFishesBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DeleteFishesBtn);
            this.Controls.Add(this.CreateFishBtn);
            this.Controls.Add(this.ResultFishesPanel);
            this.Controls.Add(this.CreateFishPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CreateFishPanel;
        private System.Windows.Forms.Panel ResultFishesPanel;
        private System.Windows.Forms.Button CreateFishBtn;
        private System.Windows.Forms.Button DeleteFishesBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton Sackgill;
        private System.Windows.Forms.RadioButton Barbus;
        private System.Windows.Forms.RadioButton Clown;
        private System.Windows.Forms.RadioButton Guppi;
        private System.Windows.Forms.Button LoadFishesBtn;
        private System.Windows.Forms.Button SaveFishesBtn;
    }
}

