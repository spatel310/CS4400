namespace CS4400
{
    partial class EditBag
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
            this.EditBagTable = new System.Windows.Forms.DataGridView();
            this.ReturnToBagList = new System.Windows.Forms.Button();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.UpdateBag = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.newProduct1 = new System.Windows.Forms.ComboBox();
            this.newProduct2 = new System.Windows.Forms.ComboBox();
            this.newProduct3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newProd1Quant = new System.Windows.Forms.TextBox();
            this.newProd2Quant = new System.Windows.Forms.TextBox();
            this.newProd3Quant = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EditBagTable)).BeginInit();
            this.SuspendLayout();
            // 
            // EditBagTable
            // 
            this.EditBagTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EditBagTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EditBagTable.Location = new System.Drawing.Point(159, 72);
            this.EditBagTable.Name = "EditBagTable";
            this.EditBagTable.Size = new System.Drawing.Size(395, 180);
            this.EditBagTable.TabIndex = 0;
            // 
            // ReturnToBagList
            // 
            this.ReturnToBagList.Location = new System.Drawing.Point(719, 102);
            this.ReturnToBagList.Name = "ReturnToBagList";
            this.ReturnToBagList.Size = new System.Drawing.Size(105, 23);
            this.ReturnToBagList.TabIndex = 4;
            this.ReturnToBagList.Text = "Return To Bag List";
            this.ReturnToBagList.UseVisualStyleBackColor = true;
            this.ReturnToBagList.Click += new System.EventHandler(this.ReturnToBagListClicked);
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(719, 72);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(105, 23);
            this.ReturnHome.TabIndex = 3;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // UpdateBag
            // 
            this.UpdateBag.Location = new System.Drawing.Point(159, 385);
            this.UpdateBag.Name = "UpdateBag";
            this.UpdateBag.Size = new System.Drawing.Size(75, 23);
            this.UpdateBag.TabIndex = 5;
            this.UpdateBag.Text = "Update Bag";
            this.UpdateBag.UseVisualStyleBackColor = true;
            this.UpdateBag.Click += new System.EventHandler(this.UpateBagClicked);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(253, 395);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 6;
            // 
            // newProduct1
            // 
            this.newProduct1.FormattingEnabled = true;
            this.newProduct1.Location = new System.Drawing.Point(159, 270);
            this.newProduct1.Name = "newProduct1";
            this.newProduct1.Size = new System.Drawing.Size(121, 21);
            this.newProduct1.TabIndex = 7;
            // 
            // newProduct2
            // 
            this.newProduct2.FormattingEnabled = true;
            this.newProduct2.Location = new System.Drawing.Point(159, 298);
            this.newProduct2.Name = "newProduct2";
            this.newProduct2.Size = new System.Drawing.Size(121, 21);
            this.newProduct2.TabIndex = 8;
            // 
            // newProduct3
            // 
            this.newProduct3.FormattingEnabled = true;
            this.newProduct3.Location = new System.Drawing.Point(159, 326);
            this.newProduct3.Name = "newProduct3";
            this.newProduct3.Size = new System.Drawing.Size(121, 21);
            this.newProduct3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Products to Bag";
            // 
            // newProd1Quant
            // 
            this.newProd1Quant.Location = new System.Drawing.Point(299, 270);
            this.newProd1Quant.Name = "newProd1Quant";
            this.newProd1Quant.Size = new System.Drawing.Size(48, 20);
            this.newProd1Quant.TabIndex = 11;
            // 
            // newProd2Quant
            // 
            this.newProd2Quant.Location = new System.Drawing.Point(299, 298);
            this.newProd2Quant.Name = "newProd2Quant";
            this.newProd2Quant.Size = new System.Drawing.Size(48, 20);
            this.newProd2Quant.TabIndex = 12;
            // 
            // newProd3Quant
            // 
            this.newProd3Quant.Location = new System.Drawing.Point(299, 326);
            this.newProd3Quant.Name = "newProd3Quant";
            this.newProd3Quant.Size = new System.Drawing.Size(48, 20);
            this.newProd3Quant.TabIndex = 13;
            // 
            // EditBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.newProd3Quant);
            this.Controls.Add(this.newProd2Quant);
            this.Controls.Add(this.newProd1Quant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProduct3);
            this.Controls.Add(this.newProduct2);
            this.Controls.Add(this.newProduct1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.UpdateBag);
            this.Controls.Add(this.ReturnToBagList);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.EditBagTable);
            this.Name = "EditBag";
            this.Text = "EditBag";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.EditBagTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EditBagTable;
        private System.Windows.Forms.Button ReturnToBagList;
        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.Button UpdateBag;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.ComboBox newProduct1;
        private System.Windows.Forms.ComboBox newProduct2;
        private System.Windows.Forms.ComboBox newProduct3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newProd1Quant;
        private System.Windows.Forms.TextBox newProd2Quant;
        private System.Windows.Forms.TextBox newProd3Quant;
    }
}