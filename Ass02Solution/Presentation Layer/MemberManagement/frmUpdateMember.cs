using Ass02Solution.Business_Layer;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass02Solution.Presentation_Layer
{
    public partial class frmUpdateMember : Form
    {
        public frmUpdateMember()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();
        public Member MemberInfo { get; set; }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "Update Member set Email = @email, CompanyName = @companyName, " +
                    "City = @city,Country = @country,Password = @password  where MemberId = @memberId";
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
                    MessageBox.Show("Update success.");
                    this.Close();
                    frmMembers frmMembers = new frmMembers();
                    frmMembers.Show();
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
            frmMembers frmMembers = new frmMembers();
            frmMembers.Show();
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            txtMemberID.ReadOnly = true;
            txtMemberID.Text = MemberInfo.MemberId.ToString();
            txtEmail.Text = MemberInfo.Email;
            txtPassword.Text = MemberInfo.Password;
            txtCompanyName.Text = MemberInfo.CompanyName;
            txtCity.Text = MemberInfo.City;
            txtCountry.Text = MemberInfo.Country;
        }
    }
}
