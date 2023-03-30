namespace OliveiraTaylorOOPFinalProject
{
    partial class ProductMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductMaintenance));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lstAllProducts = new System.Windows.Forms.ListBox();
            this.btnAddNewItem = new System.Windows.Forms.Button();
            this.grpUpdateStock = new System.Windows.Forms.GroupBox();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.lblInStock = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNumStock = new System.Windows.Forms.NumericUpDown();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grpUpdateStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumStock)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(605, 12);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lstAllProducts
            // 
            this.lstAllProducts.FormattingEnabled = true;
            this.lstAllProducts.ItemHeight = 16;
            this.lstAllProducts.Location = new System.Drawing.Point(12, 12);
            this.lstAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstAllProducts.Name = "lstAllProducts";
            this.lstAllProducts.Size = new System.Drawing.Size(549, 420);
            this.lstAllProducts.TabIndex = 4;
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.Location = new System.Drawing.Point(579, 139);
            this.btnAddNewItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(93, 59);
            this.btnAddNewItem.TabIndex = 5;
            this.btnAddNewItem.Text = "Add New Item";
            this.btnAddNewItem.UseVisualStyleBackColor = true;
            // 
            // grpUpdateStock
            // 
            this.grpUpdateStock.Controls.Add(this.btnRemoveStock);
            this.grpUpdateStock.Controls.Add(this.lblInStock);
            this.grpUpdateStock.Controls.Add(this.lblProductName);
            this.grpUpdateStock.Controls.Add(this.label2);
            this.grpUpdateStock.Controls.Add(this.label1);
            this.grpUpdateStock.Controls.Add(this.nudNumStock);
            this.grpUpdateStock.Controls.Add(this.btnAddStock);
            this.grpUpdateStock.Location = new System.Drawing.Point(567, 215);
            this.grpUpdateStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateStock.Name = "grpUpdateStock";
            this.grpUpdateStock.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpUpdateStock.Size = new System.Drawing.Size(221, 222);
            this.grpUpdateStock.TabIndex = 6;
            this.grpUpdateStock.TabStop = false;
            this.grpUpdateStock.Text = "Update Stock";
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Location = new System.Drawing.Point(109, 164);
            this.btnRemoveStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(104, 53);
            this.btnRemoveStock.TabIndex = 6;
            this.btnRemoveStock.Text = "Remove Stock";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            // 
            // lblInStock
            // 
            this.lblInStock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInStock.Location = new System.Drawing.Point(3, 103);
            this.lblInStock.Name = "lblInStock";
            this.lblInStock.Size = new System.Drawing.Size(212, 23);
            this.lblInStock.TabIndex = 5;
            this.lblInStock.Text = "label4";
            // 
            // lblProductName
            // 
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductName.Location = new System.Drawing.Point(3, 50);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(212, 23);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current in Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Name:";
            // 
            // nudNumStock
            // 
            this.nudNumStock.Location = new System.Drawing.Point(51, 134);
            this.nudNumStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNumStock.Name = "nudNumStock";
            this.nudNumStock.Size = new System.Drawing.Size(120, 22);
            this.nudNumStock.TabIndex = 1;
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(5, 164);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(99, 53);
            this.btnAddStock.TabIndex = 0;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(687, 139);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(93, 59);
            this.btnGenerateReport.TabIndex = 7;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            // 
            // ProductMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.grpUpdateStock);
            this.Controls.Add(this.btnAddNewItem);
            this.Controls.Add(this.lstAllProducts);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductMaintenance";
            this.Load += new System.EventHandler(this.ProductMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grpUpdateStock.ResumeLayout(false);
            this.grpUpdateStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lstAllProducts;
        private System.Windows.Forms.Button btnAddNewItem;
        private System.Windows.Forms.GroupBox grpUpdateStock;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.Label lblInStock;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNumStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}