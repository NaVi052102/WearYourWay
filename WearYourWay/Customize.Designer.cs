namespace WearYourWay
{
    partial class Customize
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
            colorDialog1 = new ColorDialog();
            btnEditColor = new Button();
            btnFont = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditColor
            // 
            btnEditColor.Location = new Point(49, 35);
            btnEditColor.Name = "btnEditColor";
            btnEditColor.Size = new Size(85, 41);
            btnEditColor.TabIndex = 1;
            btnEditColor.Text = "button1";
            btnEditColor.UseVisualStyleBackColor = true;
            btnEditColor.Click += btnEditColor_Click;
            // 
            // btnFont
            // 
            btnFont.Location = new Point(91, 82);
            btnFont.Name = "btnFont";
            btnFont.Size = new Size(75, 53);
            btnFont.TabIndex = 3;
            btnFont.Text = "button1";
            btnFont.UseVisualStyleBackColor = true;
            btnFont.Click += btnFont_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 238);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(13, 409);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(817, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(14, 409);
            panel3.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(13, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(804, 10);
            panel1.TabIndex = 9;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(13, 399);
            panel4.Name = "panel4";
            panel4.Size = new Size(804, 10);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnFont);
            panel5.Controls.Add(btnEditColor);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(13, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(804, 389);
            panel5.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(794, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 389);
            panel7.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 389);
            panel6.TabIndex = 4;
            // 
            // Customize
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 409);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customize";
            Text = "Form4";
            panel5.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ColorDialog colorDialog1;
        private Button btnEditColor;
        private Button btnFont;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}