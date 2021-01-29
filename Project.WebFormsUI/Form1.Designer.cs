
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
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.tbxProduct = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategories.SuspendLayout();
            this.gbxProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.Location = new System.Drawing.Point(35, 295);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(751, 190);
            this.dgwProduct.TabIndex = 0;
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
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(35, 45);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Kategori";
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
            // tbxProduct
            // 
            this.tbxProduct.Location = new System.Drawing.Point(125, 44);
            this.tbxProduct.Name = "tbxProduct";
            this.tbxProduct.Size = new System.Drawing.Size(199, 20);
            this.tbxProduct.TabIndex = 2;
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
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 528);
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
    }
}

