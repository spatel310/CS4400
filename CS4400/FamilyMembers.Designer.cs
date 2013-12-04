namespace CS4400
{
    partial class FamilyMembers
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
            this.ReturnHome = new System.Windows.Forms.Button();
            this.DropOffGrid = new System.Windows.Forms.DataGridView();
            this.AddMembers = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DropOffGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(720, 49);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(105, 23);
            this.ReturnHome.TabIndex = 0;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // DropOffGrid
            // 
            this.DropOffGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DropOffGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DropOffGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DropOffGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Source,
            this.Quantity,
            this.DayOfBirth,
            this.MonthOfBirth,
            this.YearOfBirth});
            this.DropOffGrid.Location = new System.Drawing.Point(77, 83);
            this.DropOffGrid.Name = "DropOffGrid";
            this.DropOffGrid.Size = new System.Drawing.Size(748, 337);
            this.DropOffGrid.TabIndex = 3;
            // 
            // AddMembers
            // 
            this.AddMembers.Location = new System.Drawing.Point(77, 48);
            this.AddMembers.Name = "AddMembers";
            this.AddMembers.Size = new System.Drawing.Size(121, 23);
            this.AddMembers.TabIndex = 4;
            this.AddMembers.Text = "Add Family Members";
            this.AddMembers.UseVisualStyleBackColor = true;
            this.AddMembers.Click += new System.EventHandler(this.AddMembersClicked);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(224, 49);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 5;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.HeaderText = "First Name";
            this.Product.Name = "Product";
            // 
            // Source
            // 
            this.Source.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Source.HeaderText = "Last Name";
            this.Source.Name = "Source";
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Gender";
            this.Quantity.Name = "Quantity";
            // 
            // DayOfBirth
            // 
            this.DayOfBirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DayOfBirth.HeaderText = "Day Of Birth";
            this.DayOfBirth.Name = "DayOfBirth";
            // 
            // MonthOfBirth
            // 
            this.MonthOfBirth.HeaderText = "Month of Birth";
            this.MonthOfBirth.Name = "MonthOfBirth";
            this.MonthOfBirth.Width = 98;
            // 
            // YearOfBirth
            // 
            this.YearOfBirth.HeaderText = "Year of Birth";
            this.YearOfBirth.Name = "YearOfBirth";
            this.YearOfBirth.Width = 83;
            // 
            // FamilyMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.AddMembers);
            this.Controls.Add(this.DropOffGrid);
            this.Controls.Add(this.ReturnHome);
            this.Name = "FamilyMembers";
            this.Text = "FamilyMembers";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.DropOffGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.DataGridView DropOffGrid;
        private System.Windows.Forms.Button AddMembers;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Source;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfBirth;
    }
}