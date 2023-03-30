namespace OliveiraTaylorOOPFinalProject
{
    partial class Checkout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.lstOrdersInCart = new System.Windows.Forms.ListBox();
            this.grpConfirmOrder = new System.Windows.Forms.GroupBox();
            this.txtCreditNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpProfile = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblStreetNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpConfirmOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstOrdersInCart
            // 
            this.lstOrdersInCart.FormattingEnabled = true;
            this.lstOrdersInCart.ItemHeight = 16;
            this.lstOrdersInCart.Location = new System.Drawing.Point(84, 46);
            this.lstOrdersInCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstOrdersInCart.Name = "lstOrdersInCart";
            this.lstOrdersInCart.Size = new System.Drawing.Size(377, 164);
            this.lstOrdersInCart.TabIndex = 0;
            // 
            // grpConfirmOrder
            // 
            this.grpConfirmOrder.Controls.Add(this.label5);
            this.grpConfirmOrder.Controls.Add(this.lblTotal);
            this.grpConfirmOrder.Controls.Add(this.txtCreditNum);
            this.grpConfirmOrder.Controls.Add(this.label3);
            this.grpConfirmOrder.Controls.Add(this.btnBack);
            this.grpConfirmOrder.Controls.Add(this.btnConfirmOrder);
            this.grpConfirmOrder.Controls.Add(this.cboPaymentMethod);
            this.grpConfirmOrder.Controls.Add(this.label2);
            this.grpConfirmOrder.Controls.Add(this.label1);
            this.grpConfirmOrder.Controls.Add(this.lstOrdersInCart);
            this.grpConfirmOrder.Location = new System.Drawing.Point(13, 14);
            this.grpConfirmOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConfirmOrder.Name = "grpConfirmOrder";
            this.grpConfirmOrder.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpConfirmOrder.Size = new System.Drawing.Size(551, 425);
            this.grpConfirmOrder.TabIndex = 1;
            this.grpConfirmOrder.TabStop = false;
            this.grpConfirmOrder.Text = "Your Order";
            // 
            // txtCreditNum
            // 
            this.txtCreditNum.Location = new System.Drawing.Point(215, 299);
            this.txtCreditNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreditNum.Name = "txtCreditNum";
            this.txtCreditNum.Size = new System.Drawing.Size(247, 22);
            this.txtCreditNum.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last 4 digits of card:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(84, 348);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 57);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to Store";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(376, 348);
            this.btnConfirmOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(85, 57);
            this.btnConfirmOrder.TabIndex = 4;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            // 
            // cboPaymentMethod
            // 
            this.cboPaymentMethod.FormattingEnabled = true;
            this.cboPaymentMethod.Location = new System.Drawing.Point(215, 263);
            this.cboPaymentMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPaymentMethod.Name = "cboPaymentMethod";
            this.cboPaymentMethod.Size = new System.Drawing.Size(247, 24);
            this.cboPaymentMethod.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment methods:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(607, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grpProfile
            // 
            this.grpProfile.Controls.Add(this.lblUserName);
            this.grpProfile.Controls.Add(this.lblCountry);
            this.grpProfile.Controls.Add(this.lblPostalCode);
            this.grpProfile.Controls.Add(this.lblProvince);
            this.grpProfile.Controls.Add(this.lblCity);
            this.grpProfile.Controls.Add(this.lblStreetName);
            this.grpProfile.Controls.Add(this.lblStreetNum);
            this.grpProfile.Controls.Add(this.label4);
            this.grpProfile.Controls.Add(this.lblCustomerName);
            this.grpProfile.Cursor = System.Windows.Forms.Cursors.PanSW;
            this.grpProfile.Location = new System.Drawing.Point(571, 132);
            this.grpProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProfile.Name = "grpProfile";
            this.grpProfile.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProfile.Size = new System.Drawing.Size(219, 306);
            this.grpProfile.TabIndex = 3;
            this.grpProfile.TabStop = false;
            this.grpProfile.Text = "Your Profile";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(7, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 16);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "Username";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(24, 272);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(52, 16);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Country";
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(24, 240);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(78, 16);
            this.lblPostalCode.TabIndex = 6;
            this.lblPostalCode.Text = "PostalCode";
            // 
            // lblProvince
            // 
            this.lblProvince.AutoSize = true;
            this.lblProvince.Location = new System.Drawing.Point(24, 208);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(60, 16);
            this.lblProvince.TabIndex = 5;
            this.lblProvince.Text = "Province";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(24, 176);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(29, 16);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Location = new System.Drawing.Point(24, 144);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(79, 16);
            this.lblStreetName.TabIndex = 3;
            this.lblStreetName.Text = "StreetName";
            // 
            // lblStreetNum
            // 
            this.lblStreetNum.AutoSize = true;
            this.lblStreetNum.Location = new System.Drawing.Point(24, 112);
            this.lblStreetNum.Name = "lblStreetNum";
            this.lblStreetNum.Size = new System.Drawing.Size(70, 16);
            this.lblStreetNum.TabIndex = 2;
            this.lblStreetNum.Text = "StreetNum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(7, 50);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(113, 16);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(360, 215);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(102, 31);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Order Total:";
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpProfile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpConfirmOrder);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.grpConfirmOrder.ResumeLayout(false);
            this.grpConfirmOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpProfile.ResumeLayout(false);
            this.grpProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOrdersInCart;
        private System.Windows.Forms.GroupBox grpConfirmOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCreditNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.ComboBox cboPaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpProfile;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblStreetNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
    }
}