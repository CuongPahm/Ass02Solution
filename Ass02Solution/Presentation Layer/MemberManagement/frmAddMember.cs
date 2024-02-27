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

namespace Ass02Solution.Presentation_Layer
{
    public partial class frmAddMember : Form
    {
        public frmAddMember()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "insert into Member(MemberId,Email,CompanyName,City,Country,Password)"
                    + " values(@memberId,@email,@companyName,@city,@country,@password)";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@memberId",txtMemberID.Text),
                new SqlParameter("@email",txtEmail.Text),
                new SqlParameter("@companyName",txtCompanyName.Text),
                new SqlParameter("@city",txtCity.Text),
                new SqlParameter("@country",txtCountry.Text),
                new SqlParameter("@password",txtPassword.Text)
                };
                if (d.executeNonQuery(strSQL, sqlParameters))
                {
                    MessageBox.Show("Add success.");
                    frmMembers members = new frmMembers();
                    this.Close();
                    members.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
