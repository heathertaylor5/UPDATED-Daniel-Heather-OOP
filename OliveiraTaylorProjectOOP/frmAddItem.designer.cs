namespace OliveiraTaylorOOPFinalProject
{
    partial class frmAddItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddItem));
            this.grpProductType = new System.Windows.Forms.GroupBox();
            this.btnSelectType = new System.Windows.Forms.Button();
            this.radPhoto = new System.Windows.Forms.RadioButton();
            this.radPainting = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumInStock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDigitalOriginal = new System.Windows.Forms.TextBox();
            this.lblDigitalOriginal = new System.Windows.Forms.Label();
            this.txtColourFrame = new System.Windows.Forms.TextBox();
            this.lblColourFrame = new System.Windows.Forms.Label();
            this.grpProductInfo = new System.Windows.Forms.GroupBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpProductType.SuspendLayout();
            this.grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpProductType
            // 
            this.grpProductType.Controls.Add(this.btnSelectType);
            this.grpProductType.Controls.Add(this.radPhoto);
            this.grpProductType.Controls.Add(this.radPainting);
            this.grpProductType.Location = new System.Drawing.Point(25, 30);
            this.grpProductType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProductType.Name = "grpProductType";
            this.grpProductType.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProductType.Size = new System.Drawing.Size(219, 135);
            this.grpProductType.TabIndex = 0;
            this.grpProductType.TabStop = false;
            this.grpProductType.Text = "Picture Type";
            // 
            // btnSelectType
            // 
            this.btnSelectType.Location = new System.Drawing.Point(57, 75);
            this.btnSelectType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectType.Name = "btnSelectType";
            this.btnSelectType.Size = new System.Drawing.Size(91, 46);
            this.btnSelectType.TabIndex = 2;
            this.btnSelectType.Text = "Select Type";
            this.btnSelectType.UseVisualStyleBackColor = true;
            this.btnSelectType.Click += new System.EventHandler(this.btnSelectType_Click);
            // 
            // radPhoto
            // 
            this.radPhoto.AutoSize = true;
            this.radPhoto.Location = new System.Drawing.Point(7, 49);
            this.radPhoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPhoto.Name = "radPhoto";
            this.radPhoto.Size = new System.Drawing.Size(63, 20);
            this.radPhoto.TabIndex = 1;
            this.radPhoto.TabStop = true;
            this.radPhoto.Text = "Photo";
            this.radPhoto.UseVisualStyleBackColor = true;
            // 
            // radPainting
            // 
            this.radPainting.AutoSize = true;
            this.radPainting.Location = new System.Drawing.Point(7, 25);
            this.radPainting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radPainting.Name = "radPainting";
            this.radPainting.Size = new System.Drawing.Size(76, 20);
            this.radPainting.TabIndex = 0;
            this.radPainting.TabStop = true;
            this.radPainting.Text = "Painting";
            this.radPainting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(100, 37);
            this.txtCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCode.MaxLength = 3;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 2;
            this.txtCode.Tag = "Code";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(99, 89);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Tag = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(99, 140);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.Tag = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // txtNumInStock
            // 
            this.txtNumInStock.Location = new System.Drawing.Point(341, 37);
            this.txtNumInStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumInStock.Name = "txtNumInStock";
            this.txtNumInStock.Size = new System.Drawing.Size(100, 22);
            this.txtNumInStock.TabIndex = 8;
            this.txtNumInStock.Tag = "InStock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Num in Stock";
            // 
            // txtDigitalOriginal
            // 
            this.txtDigitalOriginal.Location = new System.Drawing.Point(341, 89);
            this.txtDigitalOriginal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDigitalOriginal.Name = "txtDigitalOriginal";
            this.txtDigitalOriginal.Size = new System.Drawing.Size(100, 22);
            this.txtDigitalOriginal.TabIndex = 10;
            this.txtDigitalOriginal.Tag = "Photo:Digital/Painting:Original";
            // 
            // lblDigitalOriginal
            // 
            this.lblDigitalOriginal.AutoSize = true;
            this.lblDigitalOriginal.Location = new System.Drawing.Point(252, 89);
            this.lblDigitalOriginal.Name = "lblDigitalOriginal";
            this.lblDigitalOriginal.Size = new System.Drawing.Size(44, 16);
            this.lblDigitalOriginal.TabIndex = 9;
            this.lblDigitalOriginal.Text = "label5";
            // 
            // txtColourFrame
            // 
            this.txtColourFrame.Location = new System.Drawing.Point(341, 145);
            this.txtColourFrame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtColourFrame.Name = "txtColourFrame";
            this.txtColourFrame.Size = new System.Drawing.Size(100, 22);
            this.txtColourFrame.TabIndex = 12;
            this.txtColourFrame.Tag = "Photo:Colour/Painting:Framed";
            // 
            // lblColourFrame
            // 
            this.lblColourFrame.AutoSize = true;
            this.lblColourFrame.Location = new System.Drawing.Point(252, 145);
            this.lblColourFrame.Name = "lblColourFrame";
            this.lblColourFrame.Size = new System.Drawing.Size(44, 16);
            this.lblColourFrame.TabIndex = 11;
            this.lblColourFrame.Text = "label6";
            // 
            // grpProductInfo
            // 
            this.grpProductInfo.Controls.Add(this.btnAddItem);
            this.grpProductInfo.Controls.Add(this.txtPrice);
            this.grpProductInfo.Controls.Add(this.txtColourFrame);
            this.grpProductInfo.Controls.Add(this.label4);
            this.grpProductInfo.Controls.Add(this.lblColourFrame);
            this.grpProductInfo.Controls.Add(this.label1);
            this.grpProductInfo.Controls.Add(this.txtDigitalOriginal);
            this.grpProductInfo.Controls.Add(this.txtDescription);
            this.grpProductInfo.Controls.Add(this.txtNumInStock);
            this.grpProductInfo.Controls.Add(this.txtCode);
            this.grpProductInfo.Controls.Add(this.label3);
            this.grpProductInfo.Controls.Add(this.lblDigitalOriginal);
            this.grpProductInfo.Controls.Add(this.label2);
            this.grpProductInfo.Location = new System.Drawing.Point(12, 194);
            this.grpProductInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProductInfo.Name = "grpProductInfo";
            this.grpProductInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProductInfo.Size = new System.Drawing.Size(464, 242);
            this.grpProductInfo.TabIndex = 13;
            this.grpProductInfo.TabStop = false;
            this.grpProductInfo.Text = "New Product Info";
            this.grpProductInfo.Visible = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(189, 186);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(87, 52);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(288, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(145, 107);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.grpProductInfo);
            this.Controls.Add(this.grpProductType);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            this.grpProductType.ResumeLayout(false);
            this.grpProductType.PerformLayout();
            this.grpProductInfo.ResumeLayout(false);
            this.grpProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProductType;
        private System.Windows.Forms.Button btnSelectType;
        private System.Windows.Forms.RadioButton radPhoto;
        private System.Windows.Forms.RadioButton radPainting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumInStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDigitalOriginal;
        private System.Windows.Forms.Label lblDigitalOriginal;
        private System.Windows.Forms.TextBox txtColourFrame;
        private System.Windows.Forms.Label lblColourFrame;
        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}