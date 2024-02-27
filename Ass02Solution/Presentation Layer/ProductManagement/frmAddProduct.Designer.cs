namespace Ass02Solution.Presentation_Layer.Product
{
    partial class frmAddProduct
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
            btnCancel = new Button();
            btnSave = new Button();
            txtUnitInStock = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtWeight = new TextBox();
            txtCategoryID = new TextBox();
            txtProductID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(306, 470);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 41;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(140, 470);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 40;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(251, 389);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(177, 23);
            txtUnitInStock.TabIndex = 53;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(251, 327);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(177, 23);
            txtUnitPrice.TabIndex = 52;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(251, 200);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(177, 23);
            txtProductName.TabIndex = 51;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(251, 260);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(177, 23);
            txtWeight.TabIndex = 50;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(251, 135);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(177, 23);
            txtCategoryID.TabIndex = 49;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(251, 72);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(177, 23);
            txtProductID.TabIndex = 48;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(110, 392);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 47;
            label6.Text = "Unit In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 330);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 46;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 203);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 45;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 263);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 44;
            label3.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 138);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 43;
            label2.Text = "Category ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 75);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 42;
            label1.Text = "Product ID";
            // 
            // frmAddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 566);
            Controls.Add(txtUnitInStock);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtProductName);
            Controls.Add(txtWeight);
            Controls.Add(txtCategoryID);
            Controls.Add(txtProductID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmAddProduct";
            Text = "frmAddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtUnitInStock;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtWeight;
        private TextBox txtCategoryID;
        private TextBox txtProductID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}