namespace App
{
    partial class MainForm
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
            this.Output = new System.Windows.Forms.PictureBox();
            this.CubBtn = new System.Windows.Forms.RadioButton();
            this.TetrahedronBtn = new System.Windows.Forms.RadioButton();
            this.OctahedronBtn = new System.Windows.Forms.RadioButton();
            this.GetSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.IcosahedronBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetSize)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(13, 13);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(425, 425);
            this.Output.TabIndex = 0;
            this.Output.TabStop = false;
            this.Output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            // 
            // CubBtn
            // 
            this.CubBtn.AutoSize = true;
            this.CubBtn.Checked = true;
            this.CubBtn.Location = new System.Drawing.Point(444, 13);
            this.CubBtn.Name = "CubBtn";
            this.CubBtn.Size = new System.Drawing.Size(42, 17);
            this.CubBtn.TabIndex = 1;
            this.CubBtn.TabStop = true;
            this.CubBtn.Text = "куб";
            this.CubBtn.UseVisualStyleBackColor = true;
            this.CubBtn.CheckedChanged += new System.EventHandler(this.ModelChanged);
            // 
            // TetrahedronBtn
            // 
            this.TetrahedronBtn.AutoSize = true;
            this.TetrahedronBtn.Location = new System.Drawing.Point(444, 36);
            this.TetrahedronBtn.Name = "TetrahedronBtn";
            this.TetrahedronBtn.Size = new System.Drawing.Size(71, 17);
            this.TetrahedronBtn.TabIndex = 2;
            this.TetrahedronBtn.Text = "тетраэдр";
            this.TetrahedronBtn.UseVisualStyleBackColor = true;
            this.TetrahedronBtn.CheckedChanged += new System.EventHandler(this.ModelChanged);
            // 
            // OctahedronBtn
            // 
            this.OctahedronBtn.AutoSize = true;
            this.OctahedronBtn.Location = new System.Drawing.Point(444, 59);
            this.OctahedronBtn.Name = "OctahedronBtn";
            this.OctahedronBtn.Size = new System.Drawing.Size(66, 17);
            this.OctahedronBtn.TabIndex = 3;
            this.OctahedronBtn.Text = "октаэдр";
            this.OctahedronBtn.UseVisualStyleBackColor = true;
            this.OctahedronBtn.CheckedChanged += new System.EventHandler(this.ModelChanged);
            // 
            // GetSize
            // 
            this.GetSize.DecimalPlaces = 3;
            this.GetSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.GetSize.Location = new System.Drawing.Point(553, 29);
            this.GetSize.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.GetSize.Name = "GetSize";
            this.GetSize.Size = new System.Drawing.Size(57, 20);
            this.GetSize.TabIndex = 4;
            this.GetSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.GetSize.ValueChanged += new System.EventHandler(this.ModelChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(550, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "size";
            // 
            // IcosahedronBtn
            // 
            this.IcosahedronBtn.AutoSize = true;
            this.IcosahedronBtn.Location = new System.Drawing.Point(444, 82);
            this.IcosahedronBtn.Name = "IcosahedronBtn";
            this.IcosahedronBtn.Size = new System.Drawing.Size(73, 17);
            this.IcosahedronBtn.TabIndex = 6;
            this.IcosahedronBtn.Text = "икосаэдр";
            this.IcosahedronBtn.UseVisualStyleBackColor = true;
            this.IcosahedronBtn.CheckedChanged += new System.EventHandler(this.ModelChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.IcosahedronBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetSize);
            this.Controls.Add(this.OctahedronBtn);
            this.Controls.Add(this.TetrahedronBtn);
            this.Controls.Add(this.CubBtn);
            this.Controls.Add(this.Output);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GetSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Output;
        private System.Windows.Forms.RadioButton CubBtn;
        private System.Windows.Forms.RadioButton TetrahedronBtn;
        private System.Windows.Forms.RadioButton OctahedronBtn;
        private System.Windows.Forms.NumericUpDown GetSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton IcosahedronBtn;
    }
}

