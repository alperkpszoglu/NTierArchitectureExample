
namespace Project.WebFormsUI
{
    partial class Products
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategories = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxCategoryAdd = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxStockAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.ProductAddQuantityperUnit = new System.Windows.Forms.Label();
            this.produtAddStockCount = new System.Windows.Forms.Label();
            this.produtAddPrice = new System.Windows.Forms.Label();
            this.produtAddCategory = new System.Windows.Forms.Label();
            this.tbxProductAdd = new System.Windows.Forms.TextBox();
            this.produtAddName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblStockUpdate = new System.Windows.Forms.Label();
            this.lblProductPriceUpdate = new System.Windows.Forms.Label();
            this.lblProductCategoryUpdate = new System.Windows.Forms.Label();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategories.SuspendLayout();
            this.gbxProducts.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.Location = new System.Drawing.Point(35, 295);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(751, 190);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategories
            // 
            this.gbxCategories.Controls.Add(this.cbxCategory);
            this.gbxCategories.Controls.Add(this.lblCategoryName);
            this.gbxCategories.Location = new System.Drawing.Point(35, 34);
            this.gbxCategories.Name = "gbxCategories";
            this.gbxCategories.Size = new System.Drawing.Size(751, 100);
            this.gbxCategories.TabIndex = 1;
            this.gbxCategories.TabStop = false;
            this.gbxCategories.Text = "Kategoriye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(134, 45);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(190, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(35, 45);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Kategori";
            // 
            // gbxProducts
            // 
            this.gbxProducts.Controls.Add(this.tbxProduct);
            this.gbxProducts.Controls.Add(this.lblProductName);
            this.gbxProducts.Location = new System.Drawing.Point(35, 150);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Size = new System.Drawing.Size(751, 100);
            this.gbxProducts.TabIndex = 2;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "Ürün Adına Göre Ara";
            // 
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(125, 44);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(199, 20);
            this.tbxProduct.TabIndex = 2;
            this.tbxProduct.TextChanged += new System.EventHandler(this.tbxProduct_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(35, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(48, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Ürün Adı";
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxCategoryAdd);
            this.gbxProductAdd.Controls.Add(this.btnAdd);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.gbxProductAdd.Controls.Add(this.tbxStockAdd);
            this.gbxProductAdd.Controls.Add(this.tbxUnitPriceAdd);
            this.gbxProductAdd.Controls.Add(this.ProductAddQuantityperUnit);
            this.gbxProductAdd.Controls.Add(this.produtAddStockCount);
            this.gbxProductAdd.Controls.Add(this.produtAddPrice);
            this.gbxProductAdd.Controls.Add(this.produtAddCategory);
            this.gbxProductAdd.Controls.Add(this.tbxProductAdd);
            this.gbxProductAdd.Controls.Add(this.produtAddName);
            this.gbxProductAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxProductAdd.Location = new System.Drawing.Point(35, 510);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(645, 176);
            this.gbxProductAdd.TabIndex = 3;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "Ürün Ekle";
            // 
            // cbxCategoryAdd
            // 
            this.cbxCategoryAdd.FormattingEnabled = true;
            this.cbxCategoryAdd.Location = new System.Drawing.Point(101, 90);
            this.cbxCategoryAdd.Name = "cbxCategoryAdd";
            this.cbxCategoryAdd.Size = new System.Drawing.Size(197, 21);
            this.cbxCategoryAdd.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(434, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(414, 90);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(198, 20);
            this.tbxQuantityPerUnitAdd.TabIndex = 9;
            // 
            // tbxStockAdd
            // 
            this.tbxStockAdd.Location = new System.Drawing.Point(414, 43);
            this.tbxStockAdd.Name = "tbxStockAdd";
            this.tbxStockAdd.Size = new System.Drawing.Size(198, 20);
            this.tbxStockAdd.TabIndex = 12;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(100, 133);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(198, 20);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // ProductAddQuantityperUnit
            // 
            this.ProductAddQuantityperUnit.AutoSize = true;
            this.ProductAddQuantityperUnit.Location = new System.Drawing.Point(349, 90);
            this.ProductAddQuantityperUnit.Name = "ProductAddQuantityperUnit";
            this.ProductAddQuantityperUnit.Size = new System.Drawing.Size(59, 13);
            this.ProductAddQuantityperUnit.TabIndex = 5;
            this.ProductAddQuantityperUnit.Text = "Birim Adedi";
            // 
            // produtAddStockCount
            // 
            this.produtAddStockCount.AutoSize = true;
            this.produtAddStockCount.Location = new System.Drawing.Point(349, 43);
            this.produtAddStockCount.Name = "produtAddStockCount";
            this.produtAddStockCount.Size = new System.Drawing.Size(59, 13);
            this.produtAddStockCount.TabIndex = 4;
            this.produtAddStockCount.Text = "Stok Adedi";
            // 
            // produtAddPrice
            // 
            this.produtAddPrice.AutoSize = true;
            this.produtAddPrice.Location = new System.Drawing.Point(48, 133);
            this.produtAddPrice.Name = "produtAddPrice";
            this.produtAddPrice.Size = new System.Drawing.Size(29, 13);
            this.produtAddPrice.TabIndex = 3;
            this.produtAddPrice.Text = "Fiyat";
            // 
            // produtAddCategory
            // 
            this.produtAddCategory.AutoSize = true;
            this.produtAddCategory.Location = new System.Drawing.Point(48, 90);
            this.produtAddCategory.Name = "produtAddCategory";
            this.produtAddCategory.Size = new System.Drawing.Size(46, 13);
            this.produtAddCategory.TabIndex = 2;
            this.produtAddCategory.Text = "Kategori";
            // 
            // tbxProductAdd
            // 
            this.tbxProductAdd.Location = new System.Drawing.Point(100, 43);
            this.tbxProductAdd.Name = "tbxProductAdd";
            this.tbxProductAdd.Size = new System.Drawing.Size(198, 20);
            this.tbxProductAdd.TabIndex = 1;
            // 
            // produtAddName
            // 
            this.produtAddName.AutoSize = true;
            this.produtAddName.Location = new System.Drawing.Point(46, 43);
            this.produtAddName.Name = "produtAddName";
            this.produtAddName.Size = new System.Drawing.Size(48, 13);
            this.produtAddName.TabIndex = 0;
            this.produtAddName.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategoryUpdate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.groupBox1.Controls.Add(this.tbxStockUpdate);
            this.groupBox1.Controls.Add(this.tbxUnitPriceUpdate);
            this.groupBox1.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.groupBox1.Controls.Add(this.lblStockUpdate);
            this.groupBox1.Controls.Add(this.lblProductPriceUpdate);
            this.groupBox1.Controls.Add(this.lblProductCategoryUpdate);
            this.groupBox1.Controls.Add(this.tbxProductNameUpdate);
            this.groupBox1.Controls.Add(this.lblProductNameUpdate);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(35, 711);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(645, 176);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(101, 90);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(197, 21);
            this.cbxCategoryUpdate.TabIndex = 11;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(434, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(141, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(414, 90);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(198, 20);
            this.tbxQuantityPerUnitUpdate.TabIndex = 9;
            // 
            // tbxStockUpdate
            // 
            this.tbxStockUpdate.Location = new System.Drawing.Point(414, 43);
            this.tbxStockUpdate.Name = "tbxStockUpdate";
            this.tbxStockUpdate.Size = new System.Drawing.Size(198, 20);
            this.tbxStockUpdate.TabIndex = 12;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(100, 133);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(198, 20);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(349, 90);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblQuantityPerUnitUpdate.TabIndex = 5;
            this.lblQuantityPerUnitUpdate.Text = "Birim Adedi";
            // 
            // lblStockUpdate
            // 
            this.lblStockUpdate.AutoSize = true;
            this.lblStockUpdate.Location = new System.Drawing.Point(349, 43);
            this.lblStockUpdate.Name = "lblStockUpdate";
            this.lblStockUpdate.Size = new System.Drawing.Size(59, 13);
            this.lblStockUpdate.TabIndex = 4;
            this.lblStockUpdate.Text = "Stok Adedi";
            // 
            // lblProductPriceUpdate
            // 
            this.lblProductPriceUpdate.AutoSize = true;
            this.lblProductPriceUpdate.Location = new System.Drawing.Point(48, 133);
            this.lblProductPriceUpdate.Name = "lblProductPriceUpdate";
            this.lblProductPriceUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblProductPriceUpdate.TabIndex = 3;
            this.lblProductPriceUpdate.Text = "Fiyat";
            // 
            // lblProductCategoryUpdate
            // 
            this.lblProductCategoryUpdate.AutoSize = true;
            this.lblProductCategoryUpdate.Location = new System.Drawing.Point(48, 90);
            this.lblProductCategoryUpdate.Name = "lblProductCategoryUpdate";
            this.lblProductCategoryUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblProductCategoryUpdate.TabIndex = 2;
            this.lblProductCategoryUpdate.Text = "Kategori";
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(100, 43);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(198, 20);
            this.tbxProductNameUpdate.TabIndex = 1;
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(46, 43);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(48, 13);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "Ürün Adı";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelete.Location = new System.Drawing.Point(703, 510);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 208);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 925);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxProducts);
            this.Controls.Add(this.gbxCategories);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Products";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategories.ResumeLayout(false);
            this.gbxCategories.PerformLayout();
            this.gbxProducts.ResumeLayout(false);
            this.gbxProducts.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategories;
        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox tbxProduct;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.TextBox tbxStockAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.Label ProductAddQuantityperUnit;
        private System.Windows.Forms.Label produtAddStockCount;
        private System.Windows.Forms.Label produtAddPrice;
        private System.Windows.Forms.Label produtAddCategory;
        private System.Windows.Forms.TextBox tbxProductAdd;
        private System.Windows.Forms.Label produtAddName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxCategoryAdd;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxStockUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblStockUpdate;
        private System.Windows.Forms.Label lblProductPriceUpdate;
        private System.Windows.Forms.Label lblProductCategoryUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

