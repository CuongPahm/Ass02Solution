using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Ass02Solution.Business_Layer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ass02Solution.Presentation_Layer
{
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }
        DataProvider d = new DataProvider();

        private void loadMembers()
        {
            List<Member> data = new List<Member>();
            using (IDataReader dr = d.executeQuery2("Select * from Member"))
            {
                while (dr.Read())
                {
                    int memberId = dr.GetInt32(0);
                    string email = dr.GetString(1).ToString();
                    string companyName = dr.GetString(2).ToString();
                    string city = dr.GetString(3).ToString();
                    string country = dr.GetString(4).ToString();
                    string password = dr.GetString(5).ToString();
                    Member member = new Member(memberId, email, companyName, city, country, password);
                    data.Add(member);
                }
            }
            dgvMemberList.DataSource = data;
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMain main = new frmMain();
            main.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            this.Hide();
            frmAddMember.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strSQL = "delete from Member where MemberId=@id";
                SqlParameter[] sqlParameters = new SqlParameter[]
                {
                new SqlParameter("@id",txtMemberID.Text)
                };
                if (d.executeNonQuery(strSQL, sqlParameters))
                {
                    MessageBox.Show("Delete success.");
                    loadMembers();
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
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtMemberID.Text = string.Empty;
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUpdateMember update = new frmUpdateMember()
            {
                MemberInfo = GetMember()
            };
            this.Hide();
            update.Show();
        }

        private Member GetMember()
        {
            Member member = null;
            try
            {
                member = new Member
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return member;
        }

        private void dgvMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMemberID.Text = dgvMemberList.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtEmail.Text = dgvMemberList.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtCompanyName.Text = dgvMemberList.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtCity.Text = dgvMemberList.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
            txtCountry.Text = dgvMemberList.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtPassword.Text = dgvMemberList.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            loadMembers();
        }
    }
}
