namespace Ass02Solution.Presentation_Layer
{
    partial class frmMain
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
            btnMember = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            SuspendLayout();
            // 
            // btnMember
            // 
            btnMember.Location = new Point(83, 124);
            btnMember.Name = "btnMember";
            btnMember.Size = new Size(89, 49);
            btnMember.TabIndex = 0;
            btnMember.Text = "Member";
            btnMember.UseVisualStyleBackColor = true;
            btnMember.Click += btnMember_Click;
            // 
            // btnProducts
            // 
            btnProducts.Location = new Point(248, 124);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(89, 49);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(413, 124);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(89, 49);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 323);
            Controls.Add(btnOrders);
            Controls.Add(btnProducts);
            Controls.Add(btnMember);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMember;
        private Button btnProducts;
        private Button btnOrders;
    }
}