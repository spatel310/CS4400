namespace CS4400
{
    partial class BagList
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
            this.BagListTable = new System.Windows.Forms.DataGridView();
            this.ViewBag = new System.Windows.Forms.Button();
            this.EditBag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BagListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(746, 56);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(106, 23);
            this.ReturnHome.TabIndex = 0;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // BagListTable
            // 
            this.BagListTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BagListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BagListTable.Location = new System.Drawing.Point(46, 56);
            this.BagListTable.Name = "BagListTable";
            this.BagListTable.ReadOnly = true;
            this.BagListTable.Size = new System.Drawing.Size(639, 329);
            this.BagListTable.TabIndex = 1;
            this.BagListTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BagSelected);
            // 
            // ViewBag
            // 
            this.ViewBag.Location = new System.Drawing.Point(62, 407);
            this.ViewBag.Name = "ViewBag";
            this.ViewBag.Size = new System.Drawing.Size(75, 23);
            this.ViewBag.TabIndex = 2;
            this.ViewBag.Text = "View Bag";
            this.ViewBag.UseVisualStyleBackColor = true;
            this.ViewBag.Click += new System.EventHandler(this.ViewBagClicked);
            // 
            // EditBag
            // 
            this.EditBag.Location = new System.Drawing.Point(176, 407);
            this.EditBag.Name = "EditBag";
            this.EditBag.Size = new System.Drawing.Size(75, 23);
            this.EditBag.TabIndex = 3;
            this.EditBag.Text = "Edit Bag";
            this.EditBag.UseVisualStyleBackColor = true;
            this.EditBag.Click += new System.EventHandler(this.EditBagClicked);
            // 
            // BagList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.EditBag);
            this.Controls.Add(this.ViewBag);
            this.Controls.Add(this.BagListTable);
            this.Controls.Add(this.ReturnHome);
            this.Name = "BagList";
            this.Text = "BagList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BagListTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.DataGridView BagListTable;
        private System.Windows.Forms.Button ViewBag;
        private System.Windows.Forms.Button EditBag;
    }
}