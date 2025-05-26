namespace Laba1_Nujin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            B_BorderStyle = new Button();
            B_Resize = new Button();
            B_Opacity = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // B_BorderStyle
            // 
            B_BorderStyle.BackColor = Color.FromArgb(255, 192, 128);
            B_BorderStyle.Location = new Point(0, 259);
            B_BorderStyle.Name = "B_BorderStyle";
            B_BorderStyle.Size = new Size(177, 30);
            B_BorderStyle.TabIndex = 0;
            B_BorderStyle.Text = "Border Style";
            B_BorderStyle.UseVisualStyleBackColor = false;
            B_BorderStyle.Click += button1_Click;
            // 
            // B_Resize
            // 
            B_Resize.BackColor = Color.FromArgb(255, 192, 128);
            B_Resize.Location = new Point(0, 288);
            B_Resize.Name = "B_Resize";
            B_Resize.Size = new Size(177, 30);
            B_Resize.TabIndex = 1;
            B_Resize.Text = "Resize";
            B_Resize.UseVisualStyleBackColor = false;
            B_Resize.Click += B_Resize_Click;
            // 
            // B_Opacity
            // 
            B_Opacity.BackColor = Color.FromArgb(255, 192, 128);
            B_Opacity.Location = new Point(0, 315);
            B_Opacity.Name = "B_Opacity";
            B_Opacity.Size = new Size(177, 30);
            B_Opacity.TabIndex = 2;
            B_Opacity.Text = "Opacity";
            B_Opacity.UseVisualStyleBackColor = false;
            B_Opacity.Click += B_Opacity_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Tomato;
            panel1.Controls.Add(B_Opacity);
            panel1.Controls.Add(B_Resize);
            panel1.Controls.Add(B_BorderStyle);
            panel1.Location = new Point(179, -31);
            panel1.Name = "panel1";
            panel1.Size = new Size(177, 487);
            panel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(535, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Location = new Point(100, 200);
            Name = "Form1";
            Opacity = 0.75D;
            StartPosition = FormStartPosition.Manual;
            Text = "Trey Research";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button B_BorderStyle;
        private Button B_Resize;
        private Button B_Opacity;
        private Panel panel1;
    }
}
