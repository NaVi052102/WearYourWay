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
    public partial class ADMINVIEW : Form
    {
        public ADMINVIEW()
        {
            InitializeComponent();
        }

        private void btnCustomize_Click(object sender, EventArgs e)
        {
            Customize form4 = new Customize
            {
                TopLevel = false, // Set as a non-top-level control
                FormBorderStyle = FormBorderStyle.None, // Remove borders
                Dock = DockStyle.Fill // Fill the panel
            };
            panel9.Controls.Clear(); // Clear any existing controls
            panel9.Controls.Add(form4); // Add Form4 to the panel
            form4.Show(); // Show Form4
        }
    }
}
