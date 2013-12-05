namespace CS4400
{
    partial class ViewBag
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
            this.BagContentsTable = new System.Windows.Forms.DataGridView();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.ReturnToBagList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BagContentsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // BagContentsTable
            // 
            this.BagContentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BagContentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BagContentsTable.Location = new System.Drawing.Point(124, 59);
            this.BagContentsTable.Name = "BagContentsTable";
            this.BagContentsTable.ReadOnly = true;
            this.BagContentsTable.Size = new System.Drawing.Size(340, 390);
            this.BagContentsTable.TabIndex = 0;
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(674, 59);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(105, 23);
            this.ReturnHome.TabIndex = 1;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // ReturnToBagList
            // 
            this.ReturnToBagList.Location = new System.Drawing.Point(674, 89);
            this.ReturnToBagList.Name = "ReturnToBagList";
            this.ReturnToBagList.Size = new System.Drawing.Size(105, 23);
            this.ReturnToBagList.TabIndex = 2;
            this.ReturnToBagList.Text = "Return To Bag List";
            this.ReturnToBagList.UseVisualStyleBackColor = true;
            this.ReturnToBagList.Click += new System.EventHandler(this.ReturnToBagListClicked);
            // 
            // ViewBag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.ReturnToBagList);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.BagContentsTable);
            this.Name = "ViewBag";
            this.Text = "ViewBag";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BagContentsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BagContentsTable;
        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.Button ReturnToBagList;
    }
}