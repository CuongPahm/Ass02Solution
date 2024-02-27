using Ass02Solution.Business_Layer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass02Solution.Presentation_Layer.ProductManagement
{
    public partial class frmUpdateProduct : Form
    {
        public frmUpdateProduct()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();
        public Products ProductInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "Update Product set CategoryId = @categoryId, ProductName = @productName, " +
                    "Weight = @weight,UnitPrice = @unitPrice,UnitInStock = @UnitInStock  where ProductId = @productId";
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
                    MessageBox.Show("Update success.");
                    this.Close();
                    frmProducts frmProducts = new frmProducts();
                    frmProducts.Show();
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
            frmProducts frmProducts = new frmProducts();
            frmProducts.Show();
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            txtProductID.ReadOnly = true;
            txtProductID.Text = ProductInfo.ProductId.ToString();
            txtCategoryID.Text = ProductInfo.CategoryId.ToString();
            txtProductName.Text = ProductInfo.ProductName;
            txtWeight.Text = ProductInfo.Weight;
            txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
            txtUnitInStock.Text = ProductInfo.UnitsInStock.ToString();
        }
    }
}
