using Ass02Solution.Presentation_Layer.ProductManagement;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            frmMembers members = new frmMembers();
            this.Hide();
            members.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            this.Hide();
            products.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            this.Hide();
            orders.Show();
        }
    }
}
