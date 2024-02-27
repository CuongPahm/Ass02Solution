using Ass02Solution.Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass02Solution.Presentation_Layer
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == String.Empty && txtPassword.Text == string.Empty)
            {
                MessageBox.Show("All fields are required!");
            }
            else if(txtEmail.Text.Equals("admin@fstore.com") && txtPassword.Text.Equals("admin@@"))
            {
                this.Hide();
                frmMain main = new frmMain();
                main.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
