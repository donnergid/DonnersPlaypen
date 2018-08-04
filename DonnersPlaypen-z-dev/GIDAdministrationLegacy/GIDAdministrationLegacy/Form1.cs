using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 


namespace GIDAdministrationLegacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hiding the forms that the customer doesn't need to see on first load. 
            pnlTestInterface.Visible = false;
            pnlAddNewMember.Visible = false; 
        }

        private void btnShowTestInterface_Click(object sender, EventArgs e)
        {
            pnlTestInterface.Visible = true; // make the test interface visible to the User. 
        }

        private void btnHideTestInterface_Click(object sender, EventArgs e)
        {
            pnlTestInterface.Visible = false; 
        }

        private void btnAddNewMember_Click(object sender, EventArgs e)
        {
            pnlAddNewMember.Visible = true; 
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = @"E:\Utilities\Source\DonnersPlaypen-z-dev\GIDAdministration\GIDAdministration\Sample.json";

                FileStream fs = File.Create(fileName);
                fs.Close(); 
                lblErrorStatus.Text = "File Created Successfully";
            }
            catch (IOException oEX)
            {
                MessageBox.Show(oEX.Message);
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
                throw;
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            try
            {
                string fileName = @"E:\Utilities\Source\DonnersPlaypen-z-dev\GIDAdministration\GIDAdministration\Sample.json";

                File.Delete(fileName);
                
                lblErrorStatus.Text = "File Deleted Successfully";
            }
            catch (IOException oEX)
            {
                MessageBox.Show(oEX.Message); 
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
                throw;
            }
        }
    }
}
