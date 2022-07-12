namespace Media_Bazaar
{
    partial class AddProduct
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbManufacturer = new System.Windows.Forms.TextBox();
            this.tbSellPrice = new System.Windows.Forms.TextBox();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblNamePrdct = new System.Windows.Forms.Label();
            this.tbPricePrdct = new System.Windows.Forms.TextBox();
            this.tbNamePrdct = new System.Windows.Forms.TextBox();
            this.btnAddNewPrdct = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(46, 294);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(88, 20);
            this.lblDescription.TabIndex = 56;
            this.lblDescription.Text = "Desctiption:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(46, 244);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 20);
            this.lblLocation.TabIndex = 54;
            this.lblLocation.Text = "Location:";
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(44, 194);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(100, 20);
            this.lblManufacturer.TabIndex = 53;
            this.lblManufacturer.Text = "Manufacturer:";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(44, 144);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(72, 20);
            this.lblSellPrice.TabIndex = 52;
            this.lblSellPrice.Text = "Sell Price:";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(208, 291);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(164, 27);
            this.tbDescription.TabIndex = 51;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(208, 241);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(164, 27);
            this.tbLocation.TabIndex = 50;
            // 
            // tbManufacturer
            // 
            this.tbManufacturer.Location = new System.Drawing.Point(208, 188);
            this.tbManufacturer.Name = "tbManufacturer";
            this.tbManufacturer.Size = new System.Drawing.Size(164, 27);
            this.tbManufacturer.TabIndex = 49;
            // 
            // tbSellPrice
            // 
            this.tbSellPrice.Location = new System.Drawing.Point(208, 138);
            this.tbSellPrice.Name = "tbSellPrice";
            this.tbSellPrice.Size = new System.Drawing.Size(164, 27);
            this.tbSellPrice.TabIndex = 47;
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Location = new System.Drawing.Point(40, 95);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(106, 20);
            this.lblPurchasePrice.TabIndex = 46;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // lblNamePrdct
            // 
            this.lblNamePrdct.AutoSize = true;
            this.lblNamePrdct.Location = new System.Drawing.Point(44, 43);
            this.lblNamePrdct.Name = "lblNamePrdct";
            this.lblNamePrdct.Size = new System.Drawing.Size(52, 20);
            this.lblNamePrdct.TabIndex = 45;
            this.lblNamePrdct.Text = "Name:";
            // 
            // tbPricePrdct
            // 
            this.tbPricePrdct.Location = new System.Drawing.Point(208, 89);
            this.tbPricePrdct.Name = "tbPricePrdct";
            this.tbPricePrdct.Size = new System.Drawing.Size(164, 27);
            this.tbPricePrdct.TabIndex = 44;
            // 
            // tbNamePrdct
            // 
            this.tbNamePrdct.Location = new System.Drawing.Point(208, 37);
            this.tbNamePrdct.Name = "tbNamePrdct";
            this.tbNamePrdct.Size = new System.Drawing.Size(164, 27);
            this.tbNamePrdct.TabIndex = 43;
            // 
            // btnAddNewPrdct
            // 
            this.btnAddNewPrdct.Location = new System.Drawing.Point(172, 352);
            this.btnAddNewPrdct.Name = "btnAddNewPrdct";
            this.btnAddNewPrdct.Size = new System.Drawing.Size(98, 41);
            this.btnAddNewPrdct.TabIndex = 57;
            this.btnAddNewPrdct.Text = "Add";
            this.btnAddNewPrdct.UseVisualStyleBackColor = true;
            this.btnAddNewPrdct.Click += new System.EventHandler(this.btnAddNewPrdct_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(312, 352);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 41);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 420);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddNewPrdct);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblManufacturer);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.tbManufacturer);
            this.Controls.Add(this.tbSellPrice);
            this.Controls.Add(this.lblPurchasePrice);
            this.Controls.Add(this.lblNamePrdct);
            this.Controls.Add(this.tbPricePrdct);
            this.Controls.Add(this.tbNamePrdct);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.TextBox tbManufacturer;
        private System.Windows.Forms.TextBox tbSellPrice;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblNamePrdct;
        private System.Windows.Forms.TextBox tbPricePrdct;
        private System.Windows.Forms.TextBox tbNamePrdct;
        private System.Windows.Forms.Button btnAddNewPrdct;
        private System.Windows.Forms.Button btnCancel;
    }
}