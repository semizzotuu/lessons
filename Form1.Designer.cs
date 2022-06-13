namespace EntityFrameworkDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbx2 = new System.Windows.Forms.GroupBox();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblStockAmountUpdate = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblNameUpdate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.tbxStockAmount = new System.Windows.Forms.TextBox();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.tbxUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.getById = new System.Windows.Forms.Button();
            this.gbx2.SuspendLayout();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(273, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(389, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(213, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // gbx2
            // 
            this.gbx2.Controls.Add(this.tbxStockAmountUpdate);
            this.gbx2.Controls.Add(this.lblStockAmountUpdate);
            this.gbx2.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbx2.Controls.Add(this.tbxNameUpdate);
            this.gbx2.Controls.Add(this.lblUnitPriceUpdate);
            this.gbx2.Controls.Add(this.lblNameUpdate);
            this.gbx2.Location = new System.Drawing.Point(383, 149);
            this.gbx2.Name = "gbx2";
            this.gbx2.Size = new System.Drawing.Size(219, 153);
            this.gbx2.TabIndex = 15;
            this.gbx2.TabStop = false;
            this.gbx2.Text = "Update a products";
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(97, 99);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(82, 23);
            this.tbxStockAmountUpdate.TabIndex = 6;
            // 
            // lblStockAmountUpdate
            // 
            this.lblStockAmountUpdate.AutoSize = true;
            this.lblStockAmountUpdate.Location = new System.Drawing.Point(8, 99);
            this.lblStockAmountUpdate.Name = "lblStockAmountUpdate";
            this.lblStockAmountUpdate.Size = new System.Drawing.Size(83, 15);
            this.lblStockAmountUpdate.TabIndex = 5;
            this.lblStockAmountUpdate.Text = "Stock Amount";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(97, 59);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(82, 23);
            this.tbxUnitPriceUpdate.TabIndex = 4;
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(97, 21);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(82, 23);
            this.tbxNameUpdate.TabIndex = 3;
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(8, 59);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(58, 15);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "Unit Price";
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(8, 21);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(39, 15);
            this.lblNameUpdate.TabIndex = 1;
            this.lblNameUpdate.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.tbxStockAmount);
            this.gb1.Controls.Add(this.lblStockAmount);
            this.gb1.Controls.Add(this.tbxUnitPrice);
            this.gb1.Controls.Add(this.tbxName);
            this.gb1.Controls.Add(this.lblUnitPrice);
            this.gb1.Controls.Add(this.lblName);
            this.gb1.Location = new System.Drawing.Point(12, 149);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(219, 153);
            this.gb1.TabIndex = 13;
            this.gb1.TabStop = false;
            this.gb1.Text = "Add a products";
            // 
            // tbxStockAmount
            // 
            this.tbxStockAmount.Location = new System.Drawing.Point(97, 99);
            this.tbxStockAmount.Name = "tbxStockAmount";
            this.tbxStockAmount.Size = new System.Drawing.Size(82, 23);
            this.tbxStockAmount.TabIndex = 6;
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(8, 99);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(83, 15);
            this.lblStockAmount.TabIndex = 5;
            this.lblStockAmount.Text = "Stock Amount";
            // 
            // tbxUnitPrice
            // 
            this.tbxUnitPrice.Location = new System.Drawing.Point(97, 59);
            this.tbxUnitPrice.Name = "tbxUnitPrice";
            this.tbxUnitPrice.Size = new System.Drawing.Size(82, 23);
            this.tbxUnitPrice.TabIndex = 4;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(97, 21);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(82, 23);
            this.tbxName.TabIndex = 3;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(8, 59);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(58, 15);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 12);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowTemplate.Height = 25;
            this.dgwProducts.Size = new System.Drawing.Size(590, 120);
            this.dgwProducts.TabIndex = 12;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick_1);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(237, 282);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(138, 23);
            this.tbxSearch.TabIndex = 18;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(289, 264);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(42, 15);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Search";
            // 
            // getById
            // 
            this.getById.Location = new System.Drawing.Point(273, 208);
            this.getById.Name = "getById";
            this.getById.Size = new System.Drawing.Size(75, 23);
            this.getById.TabIndex = 20;
            this.getById.Text = "button1";
            this.getById.UseVisualStyleBackColor = true;
            this.getById.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 372);
            this.Controls.Add(this.getById);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbx2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx2.ResumeLayout(false);
            this.gbx2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox gbx2;
        private TextBox tbxStockAmountUpdate;
        private Label lblStockAmountUpdate;
        private TextBox tbxUnitPriceUpdate;
        private TextBox tbxNameUpdate;
        private Label lblUnitPriceUpdate;
        private Label lblNameUpdate;
        private Button btnAdd;
        private GroupBox gb1;
        private TextBox tbxStockAmount;
        private Label lblStockAmount;
        private TextBox tbxUnitPrice;
        private TextBox tbxName;
        private Label lblUnitPrice;
        private Label lblName;
        private DataGridView dgwProducts;
        private TextBox tbxSearch;
        private Label lblSearch;
        private Button getById;
    }
}