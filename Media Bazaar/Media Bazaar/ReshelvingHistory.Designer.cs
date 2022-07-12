namespace Media_Bazaar
{
    partial class ReshelvingHistory
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
            this.btnCloseReshelvingHistory = new System.Windows.Forms.Button();
            this.reShelvingDGVHistory = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.reShelvingDGVHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCloseReshelvingHistory
            // 
            this.btnCloseReshelvingHistory.Location = new System.Drawing.Point(294, 350);
            this.btnCloseReshelvingHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseReshelvingHistory.Name = "btnCloseReshelvingHistory";
            this.btnCloseReshelvingHistory.Size = new System.Drawing.Size(146, 27);
            this.btnCloseReshelvingHistory.TabIndex = 25;
            this.btnCloseReshelvingHistory.Text = "Close";
            this.btnCloseReshelvingHistory.UseVisualStyleBackColor = true;
            this.btnCloseReshelvingHistory.Click += new System.EventHandler(this.btnCloseReshelvingHistory_Click);
            // 
            // reShelvingDGVHistory
            // 
            this.reShelvingDGVHistory.AllowUserToAddRows = false;
            this.reShelvingDGVHistory.AllowUserToDeleteRows = false;
            this.reShelvingDGVHistory.AllowUserToResizeColumns = false;
            this.reShelvingDGVHistory.AllowUserToResizeRows = false;
            this.reShelvingDGVHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reShelvingDGVHistory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reShelvingDGVHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.reShelvingDGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reShelvingDGVHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.Status});
            this.reShelvingDGVHistory.Location = new System.Drawing.Point(2, 12);
            this.reShelvingDGVHistory.MultiSelect = false;
            this.reShelvingDGVHistory.Name = "reShelvingDGVHistory";
            this.reShelvingDGVHistory.RowHeadersVisible = false;
            this.reShelvingDGVHistory.RowHeadersWidth = 51;
            this.reShelvingDGVHistory.RowTemplate.Height = 29;
            this.reShelvingDGVHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reShelvingDGVHistory.Size = new System.Drawing.Size(754, 333);
            this.reShelvingDGVHistory.TabIndex = 35;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "RequestedAmount";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Department";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Specification";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // ReshelvingHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(759, 388);
            this.Controls.Add(this.reShelvingDGVHistory);
            this.Controls.Add(this.btnCloseReshelvingHistory);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReshelvingHistory";
            this.Text = "ReshelvingHistory";
            ((System.ComponentModel.ISupportInitialize)(this.reShelvingDGVHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCloseReshelvingHistory;
        private System.Windows.Forms.DataGridView reShelvingDGVHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}