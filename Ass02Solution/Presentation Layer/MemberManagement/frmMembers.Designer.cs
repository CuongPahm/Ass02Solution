namespace Ass02Solution.Presentation_Layer
{
    partial class frmMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMemberList = new DataGridView();
            btnCLose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberID = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCompanyName = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // dgvMemberList
            // 
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(60, 263);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowTemplate.Height = 25;
            dgvMemberList.Size = new Size(670, 150);
            dgvMemberList.TabIndex = 0;
            dgvMemberList.CellClick += dgvMemberList_CellClick;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
            // 
            // btnCLose
            // 
            btnCLose.Location = new Point(535, 221);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(75, 23);
            btnCLose.TabIndex = 1;
            btnCLose.Text = "Close";
            btnCLose.UseVisualStyleBackColor = true;
            btnCLose.Click += btnCLose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Member ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 109);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 171);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 46);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 5;
            label4.Text = "Company Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 109);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 6;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(394, 171);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 7;
            label6.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(179, 43);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(177, 23);
            txtMemberID.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(179, 106);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(179, 168);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(535, 43);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(177, 23);
            txtCompanyName.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(535, 106);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(177, 23);
            txtCity.TabIndex = 12;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(535, 168);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(177, 23);
            txtCountry.TabIndex = 13;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(179, 221);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(369, 221);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // frmMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 462);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtCompanyName);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCLose);
            Controls.Add(dgvMemberList);
            Name = "frmMembers";
            Text = "frmMembers";
            Load += frmMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMemberList;
        private Button btnCLose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Button btnAdd;
        private Button btnDelete;
    }
}