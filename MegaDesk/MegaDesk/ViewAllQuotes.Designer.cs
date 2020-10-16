namespace MegaDesk
{
    partial class ViewAllQuotes
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
            this.lvQuotes = new System.Windows.Forms.ListView();
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateCreated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.surfaceArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drawerCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.material = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shippingMethod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.shippingCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpQuote = new System.Windows.Forms.TableLayoutPanel();
            this.lblShippingCost = new System.Windows.Forms.Label();
            this.lblShippingMethod = new System.Windows.Forms.Label();
            this.lblMaterialCost = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.lblDrawerCost = new System.Windows.Forms.Label();
            this.lblPricePerDrawer = new System.Windows.Forms.Label();
            this.lblSizeCost = new System.Windows.Forms.Label();
            this.lblTotalSizeIn = new System.Windows.Forms.Label();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblBaseSizeIncluded = new System.Windows.Forms.Label();
            this.lblCostPerIn = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.tlpQuote.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // lvQuotes
            // 
            this.lvQuotes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerName,
            this.dateCreated,
            this.surfaceArea,
            this.sizeCost,
            this.drawerCost,
            this.material,
            this.materialCost,
            this.shippingMethod,
            this.shippingCost,
            this.totalCost});
            this.lvQuotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvQuotes.FullRowSelect = true;
            this.lvQuotes.GridLines = true;
            this.lvQuotes.HideSelection = false;
            this.lvQuotes.Location = new System.Drawing.Point(8, 24);
            this.lvQuotes.Name = "lvQuotes";
            this.lvQuotes.Size = new System.Drawing.Size(561, 438);
            this.lvQuotes.TabIndex = 0;
            this.lvQuotes.UseCompatibleStateImageBehavior = false;
            this.lvQuotes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvQuotes_ColumnClick);
            this.lvQuotes.SelectedIndexChanged += new System.EventHandler(this.lvQuotes_SelectedIndexChanged);
            // 
            // customerName
            // 
            this.customerName.Text = "Customer Name";
            // 
            // dateCreated
            // 
            this.dateCreated.Text = "Date Created";
            // 
            // surfaceArea
            // 
            this.surfaceArea.Text = "Surface Area";
            // 
            // sizeCost
            // 
            this.sizeCost.Text = "Size Cost";
            // 
            // drawerCost
            // 
            this.drawerCost.Text = "Drawer Cost";
            // 
            // material
            // 
            this.material.Text = "Material";
            // 
            // materialCost
            // 
            this.materialCost.Text = "Material Cost";
            // 
            // shippingMethod
            // 
            this.shippingMethod.Text = "Shipping Method";
            // 
            // shippingCost
            // 
            this.shippingCost.Text = "Shipping Cost";
            // 
            // totalCost
            // 
            this.totalCost.Text = "Total Cost";
            // 
            // tlpQuote
            // 
            this.tlpQuote.ColumnCount = 3;
            this.tlpQuote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpQuote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpQuote.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpQuote.Controls.Add(this.lblShippingCost, 2, 11);
            this.tlpQuote.Controls.Add(this.lblShippingMethod, 2, 10);
            this.tlpQuote.Controls.Add(this.lblMaterialCost, 2, 9);
            this.tlpQuote.Controls.Add(this.lblMaterial, 2, 8);
            this.tlpQuote.Controls.Add(this.lblDrawerCost, 2, 7);
            this.tlpQuote.Controls.Add(this.lblPricePerDrawer, 2, 6);
            this.tlpQuote.Controls.Add(this.lblSizeCost, 2, 5);
            this.tlpQuote.Controls.Add(this.lblTotalSizeIn, 2, 4);
            this.tlpQuote.Controls.Add(this.lblBasePrice, 2, 1);
            this.tlpQuote.Controls.Add(this.label22, 1, 3);
            this.tlpQuote.Controls.Add(this.label21, 0, 12);
            this.tlpQuote.Controls.Add(this.label9, 0, 2);
            this.tlpQuote.Controls.Add(this.label8, 0, 1);
            this.tlpQuote.Controls.Add(this.label10, 0, 0);
            this.tlpQuote.Controls.Add(this.label11, 0, 3);
            this.tlpQuote.Controls.Add(this.label12, 0, 4);
            this.tlpQuote.Controls.Add(this.label13, 0, 5);
            this.tlpQuote.Controls.Add(this.label14, 0, 6);
            this.tlpQuote.Controls.Add(this.label15, 0, 7);
            this.tlpQuote.Controls.Add(this.label16, 0, 8);
            this.tlpQuote.Controls.Add(this.label17, 0, 9);
            this.tlpQuote.Controls.Add(this.label18, 0, 10);
            this.tlpQuote.Controls.Add(this.label19, 0, 11);
            this.tlpQuote.Controls.Add(this.label20, 1, 1);
            this.tlpQuote.Controls.Add(this.label23, 1, 4);
            this.tlpQuote.Controls.Add(this.label24, 1, 5);
            this.tlpQuote.Controls.Add(this.label25, 1, 6);
            this.tlpQuote.Controls.Add(this.label26, 1, 7);
            this.tlpQuote.Controls.Add(this.label27, 1, 9);
            this.tlpQuote.Controls.Add(this.label28, 1, 11);
            this.tlpQuote.Controls.Add(this.label29, 1, 12);
            this.tlpQuote.Controls.Add(this.lblCustomerName, 2, 0);
            this.tlpQuote.Controls.Add(this.lblBaseSizeIncluded, 2, 2);
            this.tlpQuote.Controls.Add(this.lblCostPerIn, 2, 3);
            this.tlpQuote.Controls.Add(this.lblTotalCost, 2, 12);
            this.tlpQuote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpQuote.Location = new System.Drawing.Point(8, 24);
            this.tlpQuote.Name = "tlpQuote";
            this.tlpQuote.RowCount = 13;
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.692308F));
            this.tlpQuote.Size = new System.Drawing.Size(248, 438);
            this.tlpQuote.TabIndex = 2;
            // 
            // lblShippingCost
            // 
            this.lblShippingCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShippingCost.AutoSize = true;
            this.lblShippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblShippingCost.Location = new System.Drawing.Point(159, 363);
            this.lblShippingCost.Name = "lblShippingCost";
            this.lblShippingCost.Size = new System.Drawing.Size(86, 33);
            this.lblShippingCost.TabIndex = 24;
            this.lblShippingCost.Text = "...";
            this.lblShippingCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShippingMethod
            // 
            this.lblShippingMethod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShippingMethod.AutoSize = true;
            this.lblShippingMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblShippingMethod.Location = new System.Drawing.Point(159, 330);
            this.lblShippingMethod.Name = "lblShippingMethod";
            this.lblShippingMethod.Size = new System.Drawing.Size(86, 33);
            this.lblShippingMethod.TabIndex = 24;
            this.lblShippingMethod.Text = "...";
            this.lblShippingMethod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaterialCost
            // 
            this.lblMaterialCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaterialCost.AutoSize = true;
            this.lblMaterialCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMaterialCost.Location = new System.Drawing.Point(159, 297);
            this.lblMaterialCost.Name = "lblMaterialCost";
            this.lblMaterialCost.Size = new System.Drawing.Size(86, 33);
            this.lblMaterialCost.TabIndex = 24;
            this.lblMaterialCost.Text = "...";
            this.lblMaterialCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMaterial
            // 
            this.lblMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblMaterial.Location = new System.Drawing.Point(159, 264);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(86, 33);
            this.lblMaterial.TabIndex = 24;
            this.lblMaterial.Text = "...";
            this.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDrawerCost
            // 
            this.lblDrawerCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDrawerCost.AutoSize = true;
            this.lblDrawerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblDrawerCost.Location = new System.Drawing.Point(159, 231);
            this.lblDrawerCost.Name = "lblDrawerCost";
            this.lblDrawerCost.Size = new System.Drawing.Size(86, 33);
            this.lblDrawerCost.TabIndex = 24;
            this.lblDrawerCost.Text = "...";
            this.lblDrawerCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPricePerDrawer
            // 
            this.lblPricePerDrawer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPricePerDrawer.AutoSize = true;
            this.lblPricePerDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblPricePerDrawer.Location = new System.Drawing.Point(159, 198);
            this.lblPricePerDrawer.Name = "lblPricePerDrawer";
            this.lblPricePerDrawer.Size = new System.Drawing.Size(86, 33);
            this.lblPricePerDrawer.TabIndex = 24;
            this.lblPricePerDrawer.Text = "...";
            this.lblPricePerDrawer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSizeCost
            // 
            this.lblSizeCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSizeCost.AutoSize = true;
            this.lblSizeCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblSizeCost.Location = new System.Drawing.Point(159, 165);
            this.lblSizeCost.Name = "lblSizeCost";
            this.lblSizeCost.Size = new System.Drawing.Size(86, 33);
            this.lblSizeCost.TabIndex = 24;
            this.lblSizeCost.Text = "...";
            this.lblSizeCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalSizeIn
            // 
            this.lblTotalSizeIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalSizeIn.AutoSize = true;
            this.lblTotalSizeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTotalSizeIn.Location = new System.Drawing.Point(159, 132);
            this.lblTotalSizeIn.Name = "lblTotalSizeIn";
            this.lblTotalSizeIn.Size = new System.Drawing.Size(86, 33);
            this.lblTotalSizeIn.TabIndex = 24;
            this.lblTotalSizeIn.Text = "...";
            this.lblTotalSizeIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBasePrice.Location = new System.Drawing.Point(159, 33);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(86, 33);
            this.lblBasePrice.TabIndex = 24;
            this.lblBasePrice.Text = "...";
            this.lblBasePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(137, 99);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(16, 33);
            this.label22.TabIndex = 34;
            this.label22.Text = "$";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 396);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(128, 42);
            this.label21.TabIndex = 34;
            this.label21.Text = "Total Cost";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 33);
            this.label9.TabIndex = 22;
            this.label9.Text = "Base Size Included";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 33);
            this.label8.TabIndex = 21;
            this.label8.Text = "Base Price";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 33);
            this.label10.TabIndex = 23;
            this.label10.Text = "Customer";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 33);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cost Per In²";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 33);
            this.label12.TabIndex = 25;
            this.label12.Text = "Total Size In²";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 165);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 33);
            this.label13.TabIndex = 26;
            this.label13.Text = "Size Cost";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 198);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 33);
            this.label14.TabIndex = 27;
            this.label14.Text = "Price Per Drawer";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 33);
            this.label15.TabIndex = 28;
            this.label15.Text = "Drawer Cost";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 33);
            this.label16.TabIndex = 29;
            this.label16.Text = "Material";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 33);
            this.label17.TabIndex = 30;
            this.label17.Text = "Material Cost";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 330);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 33);
            this.label18.TabIndex = 31;
            this.label18.Text = "Shipping Method";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 363);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 33);
            this.label19.TabIndex = 32;
            this.label19.Text = "Shipping Cost";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(137, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(16, 33);
            this.label20.TabIndex = 33;
            this.label20.Text = "$";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(137, 132);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(16, 33);
            this.label23.TabIndex = 35;
            this.label23.Text = "$";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(137, 165);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(16, 33);
            this.label24.TabIndex = 36;
            this.label24.Text = "$";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(137, 198);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(16, 33);
            this.label25.TabIndex = 37;
            this.label25.Text = "$";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label26
            // 
            this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(137, 231);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(16, 33);
            this.label26.TabIndex = 38;
            this.label26.Text = "$";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(137, 297);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(16, 33);
            this.label27.TabIndex = 39;
            this.label27.Text = "$";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(137, 363);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(16, 33);
            this.label28.TabIndex = 40;
            this.label28.Text = "$";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(137, 396);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(16, 42);
            this.label29.TabIndex = 41;
            this.label29.Text = "$";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(159, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(86, 33);
            this.lblCustomerName.TabIndex = 42;
            this.lblCustomerName.Text = "...";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblBaseSizeIncluded
            // 
            this.lblBaseSizeIncluded.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaseSizeIncluded.AutoSize = true;
            this.lblBaseSizeIncluded.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBaseSizeIncluded.Location = new System.Drawing.Point(159, 66);
            this.lblBaseSizeIncluded.Name = "lblBaseSizeIncluded";
            this.lblBaseSizeIncluded.Size = new System.Drawing.Size(86, 33);
            this.lblBaseSizeIncluded.TabIndex = 43;
            this.lblBaseSizeIncluded.Text = "...";
            this.lblBaseSizeIncluded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCostPerIn
            // 
            this.lblCostPerIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCostPerIn.AutoSize = true;
            this.lblCostPerIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCostPerIn.Location = new System.Drawing.Point(159, 99);
            this.lblCostPerIn.Name = "lblCostPerIn";
            this.lblCostPerIn.Size = new System.Drawing.Size(86, 33);
            this.lblCostPerIn.TabIndex = 44;
            this.lblCostPerIn.Text = "...";
            this.lblCostPerIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(159, 396);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(86, 42);
            this.lblTotalCost.TabIndex = 45;
            this.lblTotalCost.Text = "...";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvQuotes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(577, 470);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Desk Quotes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tlpQuote);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(595, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(264, 470);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quote Detail";
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
            this.btnClose.Location = new System.Drawing.Point(780, 493);
            this.btnClose.Margin = new System.Windows.Forms.Padding(8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(8);
            this.btnClose.Size = new System.Drawing.Size(71, 45);
            this.btnClose.TabIndex = 9;
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
            this.dgvQuotes.Location = new System.Drawing.Point(20, 515);
            this.dgvQuotes.Name = "dgvQuotes";
            this.dgvQuotes.Size = new System.Drawing.Size(561, 150);
            this.dgvQuotes.TabIndex = 10;
            this.dgvQuotes.SelectionChanged += new System.EventHandler(this.dgvQuotes_SelectionChanged);
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
            this.dgvColumnShippingCost.HeaderText = "Shipping Cost";
            this.dgvColumnShippingCost.Name = "dgvColumnShippingCost";
            this.dgvColumnShippingCost.ReadOnly = true;
            // 
            // dgvColumnTotalCost
            // 
            this.dgvColumnTotalCost.HeaderText = "Total Cost";
            this.dgvColumnTotalCost.Name = "dgvColumnTotalCost";
            this.dgvColumnTotalCost.ReadOnly = true;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(203)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(872, 796);
            this.Controls.Add(this.dgvQuotes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Desk Quotes";
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            this.tlpQuote.ResumeLayout(false);
            this.tlpQuote.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvQuotes;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader dateCreated;
        private System.Windows.Forms.ColumnHeader surfaceArea;
        private System.Windows.Forms.ColumnHeader sizeCost;
        private System.Windows.Forms.ColumnHeader drawerCost;
        private System.Windows.Forms.ColumnHeader material;
        private System.Windows.Forms.ColumnHeader materialCost;
        private System.Windows.Forms.ColumnHeader shippingMethod;
        private System.Windows.Forms.ColumnHeader shippingCost;
        private System.Windows.Forms.ColumnHeader totalCost;
        private System.Windows.Forms.TableLayoutPanel tlpQuote;
        private System.Windows.Forms.Label lblShippingCost;
        private System.Windows.Forms.Label lblShippingMethod;
        private System.Windows.Forms.Label lblMaterialCost;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.Label lblDrawerCost;
        private System.Windows.Forms.Label lblPricePerDrawer;
        private System.Windows.Forms.Label lblSizeCost;
        private System.Windows.Forms.Label lblTotalSizeIn;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblBaseSizeIncluded;
        private System.Windows.Forms.Label lblCostPerIn;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
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