namespace MegaDesk
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvQuotes = new System.Windows.Forms.DataGridView();
            this.dgvColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnShippingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnShippingMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTotalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnSizeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnDrawerCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnMaterialCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnShippingCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvColumnTotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvQuotes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(651, 470);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Quotes";
            // 
            // cbSurfaceMaterial
            // 
            this.cbSurfaceMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.cbSurfaceMaterial.FormattingEnabled = true;
            this.cbSurfaceMaterial.Location = new System.Drawing.Point(142, 10);
            this.cbSurfaceMaterial.Margin = new System.Windows.Forms.Padding(8);
            this.cbSurfaceMaterial.Name = "cbSurfaceMaterial";
            this.cbSurfaceMaterial.Size = new System.Drawing.Size(242, 25);
            this.cbSurfaceMaterial.TabIndex = 5;
            this.cbSurfaceMaterial.SelectedValueChanged += new System.EventHandler(this.cbSurfaceMaterial_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filter By Material";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AutoSize = true;
            this.btnClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(86)))), ((int)(((byte)(161)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.btnClose.Location = new System.Drawing.Point(584, 527);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(8);
            this.btnClose.Size = new System.Drawing.Size(71, 45);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvQuotes
            // 
            this.dgvQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColumnName,
            this.dgvColumnShippingDate,
            this.dgvColumnShippingMethod,
            this.dgvColumnTotalSize,
            this.dgvColumnSizeCost,
            this.dgvColumnDrawerCost,
            this.dgvColumnMaterial,
            this.dgvColumnMaterialCost,
            this.dgvColumnShippingCost,
            this.dgvColumnTotalCost});
            this.dgvQuotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuotes.Location = new System.Drawing.Point(8, 24);
            this.dgvQuotes.Name = "dgvQuotes";
            this.dgvQuotes.Size = new System.Drawing.Size(635, 438);
            this.dgvQuotes.TabIndex = 25;
            // 
            // dgvColumnName
            // 
            this.dgvColumnName.HeaderText = "Name";
            this.dgvColumnName.Name = "dgvColumnName";
            this.dgvColumnName.ReadOnly = true;
            // 
            // dgvColumnShippingDate
            // 
            this.dgvColumnShippingDate.HeaderText = "Shipping Date";
            this.dgvColumnShippingDate.Name = "dgvColumnShippingDate";
            this.dgvColumnShippingDate.ReadOnly = true;
            // 
            // dgvColumnShippingMethod
            // 
            this.dgvColumnShippingMethod.HeaderText = "Shipping Method";
            this.dgvColumnShippingMethod.Name = "dgvColumnShippingMethod";
            this.dgvColumnShippingMethod.ReadOnly = true;
            // 
            // dgvColumnTotalSize
            // 
            this.dgvColumnTotalSize.HeaderText = "Total Size";
            this.dgvColumnTotalSize.Name = "dgvColumnTotalSize";
            this.dgvColumnTotalSize.ReadOnly = true;
            // 
            // dgvColumnSizeCost
            // 
            this.dgvColumnSizeCost.HeaderText = "Size Cost";
            this.dgvColumnSizeCost.Name = "dgvColumnSizeCost";
            this.dgvColumnSizeCost.ReadOnly = true;
            // 
            // dgvColumnDrawerCost
            // 
            this.dgvColumnDrawerCost.HeaderText = "Drawer Cost";
            this.dgvColumnDrawerCost.Name = "dgvColumnDrawerCost";
            this.dgvColumnDrawerCost.ReadOnly = true;
            // 
            // dgvColumnMaterial
            // 
            this.dgvColumnMaterial.HeaderText = "Material";
            this.dgvColumnMaterial.Name = "dgvColumnMaterial";
            this.dgvColumnMaterial.ReadOnly = true;
            // 
            // dgvColumnMaterialCost
            // 
            this.dgvColumnMaterialCost.HeaderText = "Material Cost";
            this.dgvColumnMaterialCost.Name = "dgvColumnMaterialCost";
            this.dgvColumnMaterialCost.ReadOnly = true;
            // 
            // dgvColumnShippingCost
            // 
            this.dgvColumnShippingCost.HeaderText = "ShippingCost";
            this.dgvColumnShippingCost.Name = "dgvColumnShippingCost";
            this.dgvColumnShippingCost.ReadOnly = true;
            // 
            // dgvColumnTotalCost
            // 
            this.dgvColumnTotalCost.HeaderText = "Total Cost";
            this.dgvColumnTotalCost.Name = "dgvColumnTotalCost";
            this.dgvColumnTotalCost.ReadOnly = true;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(671, 587);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSurfaceMaterial);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Quotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSurfaceMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnShippingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnShippingMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTotalSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnSizeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnDrawerCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnMaterialCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnShippingCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvColumnTotalCost;
    }
}