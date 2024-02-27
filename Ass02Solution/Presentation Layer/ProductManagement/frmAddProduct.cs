using Ass02Solution.Presentation_Layer.ProductManagement;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass02Solution.Presentation_Layer.Product
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "insert into Product(ProductId,CategoryId,ProductName,Weight,UnitPrice,UnitInStock)"
                    + " values(@productId,@categoryId,@productName,@weight,@unitPrice,@unitInStock)";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@productId",txtProductID.Text),
                new SqlParameter("@categoryId",txtCategoryID.Text),
                new SqlParameter("@productName",txtProductName.Text),
                new SqlParameter("@weight",txtWeight.Text),
                new SqlParameter("@unitPrice",txtUnitPrice.Text),
                new SqlParameter("@unitInStock",txtUnitInStock.Text)
                };
                if (d.executeNonQuery(strSQL, sqlParameters))
                {
                    MessageBox.Show("Add success.");
                    frmProducts pr = new frmProducts();
                    this.Close();
                    pr.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            frmProducts products = new frmProducts();
            products.Show();
        }
    }
}
