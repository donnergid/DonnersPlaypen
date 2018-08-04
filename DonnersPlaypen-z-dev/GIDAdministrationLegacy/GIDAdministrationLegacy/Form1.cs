using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIDAdministrationLegacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pnlTestInterface.Visible = false; 
        }

        private void btnShowTestInterface_Click(object sender, EventArgs e)
        {
            pnlTestInterface.Visible = true; // make the test interface visible to the User. 
        }

        private void btnHideTestInterface_Click(object sender, EventArgs e)
        {
            pnlTestInterface.Visible = false; 
        }
    }
}
