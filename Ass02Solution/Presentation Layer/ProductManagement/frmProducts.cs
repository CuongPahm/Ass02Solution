using Ass02Solution.Business_Layer;
using Ass02Solution.Presentation_Layer.Product;
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

namespace Ass02Solution.Presentation_Layer.ProductManagement
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddProduct frmAddProduct = new frmAddProduct();
            frmAddProduct.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "delete from Product where ProductId=@id";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@id",txtProductID.Text)
                };
                if (d.executeNonQuery(strSQL, sqlParameters))
                {
                    MessageBox.Show("Delete success.");
                    loadProducts();
                    ClearText();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error" + ex.Message);
            }
        }

        private void ClearText()
        {
            txtProductID.Text = string.Empty;
            txtCategoryID.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitInStock.Text = string.Empty;
        }

        private void loadProducts()
        {
            List<Products> data = new List<Products>();
            using (IDataReader dr = d.executeQuery2("Select * from Product"))
            {
                while (dr.Read())
                {
                    int productId = dr.GetInt32(0);
                    int categoryId = dr.GetInt32(1);
                    string productName = dr.GetString(2).ToString();
                    string weight = dr.GetString(3).ToString();
                    decimal unitPrice = dr.GetDecimal(4);
                    int unitInStock = dr.GetInt32(5);
                    Products product = new Products(productId, categoryId, productName, weight, unitPrice, unitInStock);
                    data.Add(product);
                }
            }
            dgvProductList.DataSource = data;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain frmMain = new frmMain();
            frmMain.Show();
        }

        private void dgvProductList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProductID.Text = dgvProductList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtCategoryID.Text = dgvProductList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtProductName.Text = dgvProductList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtWeight.Text = dgvProductList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtUnitPrice.Text = dgvProductList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtUnitInStock.Text = dgvProductList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void dgvProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdateProduct update = new frmUpdateProduct()
            {
                ProductInfo = GetProduct()
            };
            this.Hide();
            update.Show();
        }

        private Products GetProduct()
        {
            Products products = null;
            try
            {
                products = new Products
                {
                    ProductId = int.Parse(txtProductID.Text),
                    CategoryId = int.Parse(txtCategoryID.Text),
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    UnitsInStock = int.Parse(txtUnitInStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Product");
            }
            return products;
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            loadProducts();
        }
    }
}
