namespace Media_Bazaar
{
    partial class DeletedItems
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
            this.dgvDeletedProducts = new System.Windows.Forms.DataGridView();
            this.dgvDeletedProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletedProductFIlterTb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDeletedProducts
            // 
            this.dgvDeletedProducts.AllowUserToAddRows = false;
            this.dgvDeletedProducts.AllowUserToDeleteRows = false;
            this.dgvDeletedProducts.AllowUserToResizeColumns = false;
            this.dgvDeletedProducts.AllowUserToResizeRows = false;
            this.dgvDeletedProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeletedProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDeletedProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDeletedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeletedProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvDeletedProductName,
            this.purchasePrice,
            this.sellPrice,
            this.manufacturer,
            this.location,
            this.description});
            this.dgvDeletedProducts.Location = new System.Drawing.Point(3, 51);
            this.dgvDeletedProducts.MultiSelect = false;
            this.dgvDeletedProducts.Name = "dgvDeletedProducts";
            this.dgvDeletedProducts.RowHeadersVisible = false;
            this.dgvDeletedProducts.RowHeadersWidth = 51;
            this.dgvDeletedProducts.RowTemplate.Height = 29;
            this.dgvDeletedProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDeletedProducts.Size = new System.Drawing.Size(1074, 387);
            this.dgvDeletedProducts.TabIndex = 31;
            // 
            // dgvDeletedProductName
            // 
            this.dgvDeletedProductName.HeaderText = "Product Name";
            this.dgvDeletedProductName.MinimumWidth = 6;
            this.dgvDeletedProductName.Name = "dgvDeletedProductName";
            this.dgvDeletedProductName.ReadOnly = true;
            // 
            // purchasePrice
            // 
            this.purchasePrice.HeaderText = "Purchase Price";
            this.purchasePrice.MinimumWidth = 8;
            this.purchasePrice.Name = "purchasePrice";
            this.purchasePrice.ReadOnly = true;
            // 
            // sellPrice
            // 
            this.sellPrice.HeaderText = "Sell Price";
            this.sellPrice.MinimumWidth = 8;
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.ReadOnly = true;
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.MinimumWidth = 8;
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.ReadOnly = true;
            // 
            // location
            // 
            this.location.HeaderText = "Location";
            this.location.MinimumWidth = 8;
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // description
            // 
            this.description.HeaderText = "Description";
            this.description.MinimumWidth = 8;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // deletedProductFIlterTb
            // 
            this.deletedProductFIlterTb.Location = new System.Drawing.Point(12, 18);
            this.deletedProductFIlterTb.Name = "deletedProductFIlterTb";
            this.deletedProductFIlterTb.PlaceholderText = "Type to filter items";
            this.deletedProductFIlterTb.Size = new System.Drawing.Size(308, 27);
            this.deletedProductFIlterTb.TabIndex = 46;
            this.deletedProductFIlterTb.TextChanged += new System.EventHandler(this.btnRefreshDeletedProducts_Click);
            // 
            // DeletedItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1078, 450);
            this.Controls.Add(this.deletedProductFIlterTb);
            this.Controls.Add(this.dgvDeletedProducts);
            this.Name = "DeletedItems";
            this.Text = "DeletedItems";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeletedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDeletedProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDeletedProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        public System.Windows.Forms.TextBox deletedProductFIlterTb;
    }
}