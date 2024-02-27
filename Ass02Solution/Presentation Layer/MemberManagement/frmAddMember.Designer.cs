namespace Ass02Solution.Presentation_Layer
{
    partial class frmAddMember
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
            txtCountry = new TextBox();
            txtCity = new TextBox();
            txtCompanyName = new TextBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(266, 381);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(177, 23);
            txtCountry.TabIndex = 25;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(266, 319);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(177, 23);
            txtCity.TabIndex = 24;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(266, 256);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(177, 23);
            txtCompanyName.TabIndex = 23;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(266, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(177, 23);
            txtPassword.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(266, 136);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(177, 23);
            txtEmail.TabIndex = 21;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(266, 73);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(177, 23);
            txtMemberID.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 384);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 19;
            label6.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 322);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 18;
            label5.Text = "City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 259);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 17;
            label4.Text = "Company Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 201);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 16;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 139);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 15;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 76);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 14;
            label1.Text = "Member ID";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(154, 470);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(343, 470);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 533);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
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
            Name = "frmAddMember";
            Text = "Add Member";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCountry;
        private TextBox txtCity;
        private TextBox txtCompanyName;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
        private Button btnCancel;
    }
}