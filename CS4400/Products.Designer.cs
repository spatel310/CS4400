namespace CS4400
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
            this.ProductSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ListAllProducts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsTable = new System.Windows.Forms.DataGridView();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.CreateProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductSearch
            // 
            this.ProductSearch.Location = new System.Drawing.Point(188, 85);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(100, 20);
            this.ProductSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OR";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(104, 88);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(78, 13);
            this.ProductNameLabel.TabIndex = 3;
            this.ProductNameLabel.Text = "Product Name:";
            // 
            // ListAllProducts
            // 
            this.ListAllProducts.Location = new System.Drawing.Point(323, 82);
            this.ListAllProducts.Name = "ListAllProducts";
            this.ListAllProducts.Size = new System.Drawing.Size(99, 23);
            this.ListAllProducts.TabIndex = 4;
            this.ListAllProducts.Text = "List All Products";
            this.ListAllProducts.UseVisualStyleBackColor = true;
            this.ListAllProducts.Click += new System.EventHandler(this.ListAllProductsClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "SEARCH BY";
            // 
            // ProductsTable
            // 
            this.ProductsTable.AllowUserToAddRows = false;
            this.ProductsTable.AllowUserToDeleteRows = false;
            this.ProductsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsTable.Location = new System.Drawing.Point(107, 161);
            this.ProductsTable.Name = "ProductsTable";
            this.ProductsTable.ReadOnly = true;
            this.ProductsTable.Size = new System.Drawing.Size(642, 281);
            this.ProductsTable.TabIndex = 6;
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(719, 39);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(94, 23);
            this.ReturnHome.TabIndex = 7;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(188, 122);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 23);
            this.Search.TabIndex = 8;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.SearchClicked);
            // 
            // CreateProduct
            // 
            this.CreateProduct.Location = new System.Drawing.Point(323, 122);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(99, 23);
            this.CreateProduct.TabIndex = 9;
            this.CreateProduct.Text = "Create Product";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProductClicked);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.CreateProduct);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.ProductsTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListAllProducts);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductSearch);
            this.Name = "Products";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ProductsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProductSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Button ListAllProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductsTable;
        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button CreateProduct;
    }
}