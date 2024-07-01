using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WearYourWay
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
          

        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            Customize form4 = new Customize
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None, 
                Dock = DockStyle.Fill
            };
            mainPanel.Controls.Clear(); 
            mainPanel.Controls.Add(form4);
            form4.Show(); 
        }
    }
}