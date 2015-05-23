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
            this.components = new System.ComponentModel.Container();
            this.CreateFishPanel = new System.Windows.Forms.Panel();
            this.ResultFishesPanel = new System.Windows.Forms.Panel();
            this.DeleteFishesBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Sackgill = new System.Windows.Forms.RadioButton();
            this.Barbus = new System.Windows.Forms.RadioButton();
            this.Clown = new System.Windows.Forms.RadioButton();
            this.Guppi = new System.Windows.Forms.RadioButton();
            this.LoadFishesBtn = new System.Windows.Forms.Button();
            this.SaveFishesBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateFishPanel
            // 
            this.CreateFishPanel.AutoScroll = true;
            this.CreateFishPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CreateFishPanel.Location = new System.Drawing.Point(269, 40);
            this.CreateFishPanel.Name = "CreateFishPanel";
            this.CreateFishPanel.Size = new System.Drawing.Size(238, 272);
            this.CreateFishPanel.TabIndex = 0;
            // 
            // ResultFishesPanel
            // 
            this.ResultFishesPanel.AutoScroll = true;
            this.ResultFishesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultFishesPanel.Location = new System.Drawing.Point(6, 40);
            this.ResultFishesPanel.Name = "ResultFishesPanel";
            this.ResultFishesPanel.Size = new System.Drawing.Size(257, 272);
            this.ResultFishesPanel.TabIndex = 1;
            // 
            // DeleteFishesBtn
            // 
            this.DeleteFishesBtn.Location = new System.Drawing.Point(6, 377);
            this.DeleteFishesBtn.Name = "DeleteFishesBtn";
            this.DeleteFishesBtn.Size = new System.Drawing.Size(257, 24);
            this.DeleteFishesBtn.TabIndex = 3;
            this.DeleteFishesBtn.Text = "Delete Fishes";
            this.DeleteFishesBtn.UseVisualStyleBackColor = true;
            this.DeleteFishesBtn.Click += new System.EventHandler(this.DeleteFishesBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Sackgill);
            this.panel3.Controls.Add(this.Barbus);
            this.panel3.Controls.Add(this.Clown);
            this.panel3.Controls.Add(this.Guppi);
            this.panel3.Location = new System.Drawing.Point(269, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 83);
            this.panel3.TabIndex = 4;
            // 
            // Sackgill
            // 
            this.Sackgill.AutoSize = true;
            this.Sackgill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sackgill.Location = new System.Drawing.Point(25, 44);
            this.Sackgill.Name = "Sackgill";
            this.Sackgill.Size = new System.Drawing.Size(81, 24);
            this.Sackgill.TabIndex = 3;
            this.Sackgill.TabStop = true;
            this.Sackgill.Text = "Sackgill";
            this.Sackgill.UseVisualStyleBackColor = true;
            this.Sackgill.CheckedChanged += new System.EventHandler(this.Sackgill_CheckedChanged);
            // 
            // Barbus
            // 
            this.Barbus.AutoSize = true;
            this.Barbus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Barbus.Location = new System.Drawing.Point(25, 14);
            this.Barbus.Name = "Barbus";
            this.Barbus.Size = new System.Drawing.Size(78, 24);
            this.Barbus.TabIndex = 2;
            this.Barbus.TabStop = true;
            this.Barbus.Text = "Barbus";
            this.Barbus.UseVisualStyleBackColor = true;
            this.Barbus.CheckedChanged += new System.EventHandler(this.Barbus_CheckedChanged);
            // 
            // Clown
            // 
            this.Clown.AutoSize = true;
            this.Clown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clown.Location = new System.Drawing.Point(136, 44);
            this.Clown.Name = "Clown";
            this.Clown.Size = new System.Drawing.Size(70, 24);
            this.Clown.TabIndex = 1;
            this.Clown.TabStop = true;
            this.Clown.Text = "Clown";
            this.Clown.UseVisualStyleBackColor = true;
            this.Clown.CheckedChanged += new System.EventHandler(this.Clown_CheckedChanged);
            // 
            // Guppi
            // 
            this.Guppi.AutoSize = true;
            this.Guppi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Guppi.Location = new System.Drawing.Point(136, 14);
            this.Guppi.Name = "Guppi";
            this.Guppi.Size = new System.Drawing.Size(70, 24);
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
            this.LoadFishesBtn.Click += new System.EventHandler(this.LoadFishesBtn_Click);
            // 
            // SaveFishesBtn
            // 
            this.SaveFishesBtn.Location = new System.Drawing.Point(6, 348);
            this.SaveFishesBtn.Name = "SaveFishesBtn";
            this.SaveFishesBtn.Size = new System.Drawing.Size(257, 23);
            this.SaveFishesBtn.TabIndex = 6;
            this.SaveFishesBtn.Text = "Save Fishes";
            this.SaveFishesBtn.UseVisualStyleBackColor = true;
            this.SaveFishesBtn.Click += new System.EventHandler(this.SaveFishesBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(73, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aquarium";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(352, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 406);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveFishesBtn);
            this.Controls.Add(this.LoadFishesBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DeleteFishesBtn);
            this.Controls.Add(this.ResultFishesPanel);
            this.Controls.Add(this.CreateFishPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CreateFishPanel;
        private System.Windows.Forms.Panel ResultFishesPanel;
        private System.Windows.Forms.Button DeleteFishesBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton Sackgill;
        private System.Windows.Forms.RadioButton Barbus;
        private System.Windows.Forms.RadioButton Clown;
        private System.Windows.Forms.RadioButton Guppi;
        private System.Windows.Forms.Button LoadFishesBtn;
        private System.Windows.Forms.Button SaveFishesBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

