namespace Ass02Solution.Presentation_Layer.ProductManagement
{
    partial class frmProducts
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
            dgvProductList = new DataGridView();
            btnDelete = new Button();
            btnAdd = new Button();
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
            btnCLose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductList).BeginInit();
            SuspendLayout();
            // 
            // dgvProductList
            // 
            dgvProductList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductList.Location = new Point(81, 270);
            dgvProductList.Name = "dgvProductList";
            dgvProductList.RowTemplate.Height = 25;
            dgvProductList.Size = new Size(639, 150);
            dgvProductList.TabIndex = 44;
            dgvProductList.CellClick += dgvProductList_CellClick;
            dgvProductList.CellDoubleClick += dgvProductList_CellDoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(366, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 43;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(176, 218);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 42;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUnitInStock
            // 
            txtUnitInStock.Location = new Point(543, 156);
            txtUnitInStock.Name = "txtUnitInStock";
            txtUnitInStock.Size = new Size(177, 23);
            txtUnitInStock.TabIndex = 41;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(543, 94);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(177, 23);
            txtUnitPrice.TabIndex = 40;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(543, 31);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(177, 23);
            txtProductName.TabIndex = 39;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(187, 156);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(177, 23);
            txtWeight.TabIndex = 38;
            // 
            // txtCategoryID
            // 
            txtCategoryID.Location = new Point(187, 94);
            txtCategoryID.Name = "txtCategoryID";
            txtCategoryID.Size = new Size(177, 23);
            txtCategoryID.TabIndex = 37;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(187, 31);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(177, 23);
            txtProductID.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(402, 159);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 35;
            label6.Text = "Unit In Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 97);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 34;
            label5.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 34);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 33;
            label4.Text = "Product Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 159);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 32;
            label3.Text = "Weight";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 97);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 31;
            label2.Text = "Category ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 34);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 30;
            label1.Text = "Product ID";
            // 
            // btnCLose
            // 
            btnCLose.Location = new Point(553, 218);
            btnCLose.Name = "btnCLose";
            btnCLose.Size = new Size(75, 23);
            btnCLose.TabIndex = 29;
            btnCLose.Text = "Close";
            btnCLose.UseVisualStyleBackColor = true;
            btnCLose.Click += btnCLose_Click;
            // 
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProductList);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
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
            Controls.Add(btnCLose);
            Name = "frmProducts";
            Text = "frmProducts";
            Load += frmProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProductList;
        private Button btnDelete;
        private Button btnAdd;
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
        private Button btnCLose;
    }
}