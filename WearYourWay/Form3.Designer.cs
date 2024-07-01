namespace WearYourWay
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            bindingSource1 = new BindingSource(components);
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            button3 = new Button();
            button5 = new Button();
            btnOrder = new Button();
            btnCustomize = new Button();
            btnHome = new Button();
            panel5 = new Panel();
            mainPanel = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 25);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 549);
            panel2.Name = "panel2";
            panel2.Size = new Size(1184, 24);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(24, 524);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(24, 25);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 524);
            panel4.TabIndex = 3;
            panel4.Paint += panel4_Paint;
            // 
            // panel6
            // 
            panel6.Controls.Add(button3);
            panel6.Controls.Add(button5);
            panel6.Controls.Add(btnOrder);
            panel6.Controls.Add(btnCustomize);
            panel6.Controls.Add(btnHome);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 83);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 441);
            panel6.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(29, 276);
            button3.Name = "button3";
            button3.Size = new Size(148, 37);
            button3.TabIndex = 6;
            button3.Text = "REPORT";
            button3.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Black;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(29, 222);
            button5.Name = "button5";
            button5.Size = new Size(148, 37);
            button5.TabIndex = 5;
            button5.Text = "PUBLIC";
            button5.UseVisualStyleBackColor = false;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Black;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Location = new Point(29, 170);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(148, 37);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // btnCustomize
            // 
            btnCustomize.BackColor = Color.Black;
            btnCustomize.FlatStyle = FlatStyle.Flat;
            btnCustomize.Location = new Point(29, 118);
            btnCustomize.Name = "btnCustomize";
            btnCustomize.Size = new Size(148, 37);
            btnCustomize.TabIndex = 3;
            btnCustomize.Text = "CUSTOMIZE";
            btnCustomize.UseVisualStyleBackColor = false;
            btnCustomize.Click += btnCustomize_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Black;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Location = new Point(29, 66);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(148, 37);
            btnHome.TabIndex = 0;
            btnHome.Text = "HOME";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 83);
            panel5.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(panel9);
            mainPanel.Controls.Add(panel8);
            mainPanel.Controls.Add(panel7);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(224, 25);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(960, 524);
            mainPanel.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Gray;
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(23, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(916, 524);
            panel9.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(23, 524);
            panel8.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(939, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(21, 524);
            panel7.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1184, 573);
            Controls.Add(mainPanel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            Margin = new Padding(4);
            Name = "Form3";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bindingSource1;
        private TextBox textBox1;
        private Button btnMinimize;
        private Button btnExit;
        private Button btnMaximize;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Button btnHome;
        private Button button5;
        private Button btnOrder;
        private Button btnCustomize;
        private Button button3;
        private Panel mainPanel;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
    }
}