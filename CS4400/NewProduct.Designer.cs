namespace CS4400
{
    partial class NewProduct
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
            this.SaveProduct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.CostPerUnitTB = new System.Windows.Forms.TextBox();
            this.SourceTB = new System.Windows.Forms.TextBox();
            this.ReturnToProducts = new System.Windows.Forms.Button();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveProduct
            // 
            this.SaveProduct.Location = new System.Drawing.Point(214, 76);
            this.SaveProduct.Name = "SaveProduct";
            this.SaveProduct.Size = new System.Drawing.Size(75, 23);
            this.SaveProduct.TabIndex = 0;
            this.SaveProduct.Text = "Save Product";
            this.SaveProduct.UseVisualStyleBackColor = true;
            this.SaveProduct.Click += new System.EventHandler(this.SaveProductClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cost Per Unit";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(214, 134);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 5;
            // 
            // CostPerUnitTB
            // 
            this.CostPerUnitTB.Location = new System.Drawing.Point(214, 186);
            this.CostPerUnitTB.Name = "CostPerUnitTB";
            this.CostPerUnitTB.Size = new System.Drawing.Size(100, 20);
            this.CostPerUnitTB.TabIndex = 6;
            // 
            // SourceTB
            // 
            this.SourceTB.Location = new System.Drawing.Point(214, 160);
            this.SourceTB.Name = "SourceTB";
            this.SourceTB.Size = new System.Drawing.Size(100, 20);
            this.SourceTB.TabIndex = 7;
            // 
            // ReturnToProducts
            // 
            this.ReturnToProducts.Location = new System.Drawing.Point(526, 76);
            this.ReturnToProducts.Name = "ReturnToProducts";
            this.ReturnToProducts.Size = new System.Drawing.Size(124, 23);
            this.ReturnToProducts.TabIndex = 8;
            this.ReturnToProducts.Text = "Return to Products";
            this.ReturnToProducts.UseVisualStyleBackColor = true;
            this.ReturnToProducts.Click += new System.EventHandler(this.ReturnToProductsClicked);
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(526, 47);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(124, 23);
            this.ReturnHome.TabIndex = 9;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.ReturnToProducts);
            this.Controls.Add(this.SourceTB);
            this.Controls.Add(this.CostPerUnitTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveProduct);
            this.Name = "NewProduct";
            this.Text = "New Product";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox CostPerUnitTB;
        private System.Windows.Forms.TextBox SourceTB;
        private System.Windows.Forms.Button ReturnToProducts;
        private System.Windows.Forms.Button ReturnHome;
    }
}