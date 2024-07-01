using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WearYourWay
{
    public partial class Customize : Form
    {
        public Customize()
        {
            InitializeComponent();
           
        }

        private void btnEditColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                // Show the color dialog
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Apply the selected color (e.g., to a panel or form background)
                    panel1.BackColor = colorDialog.Color;
                }

            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                // Show the font dialog
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    // Apply the selected font (e.g., to a label or text box)
                    label1.Font = fontDialog.Font;
                }
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
           
        }
    }
}
