namespace CS4400
{
    partial class HomeForm
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
            this.Pickups = new System.Windows.Forms.Button();
            this.Bags = new System.Windows.Forms.Button();
            this.Dropoffs = new System.Windows.Forms.Button();
            this.ClientList = new System.Windows.Forms.Button();
            this.ServiceReport = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.NewClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Pickups
            // 
            this.Pickups.Location = new System.Drawing.Point(311, 176);
            this.Pickups.Name = "Pickups";
            this.Pickups.Size = new System.Drawing.Size(75, 23);
            this.Pickups.TabIndex = 0;
            this.Pickups.Text = "Pickups";
            this.Pickups.UseVisualStyleBackColor = true;
            this.Pickups.Click += new System.EventHandler(this.PickupsClicked);
            // 
            // Bags
            // 
            this.Bags.Location = new System.Drawing.Point(418, 176);
            this.Bags.Name = "Bags";
            this.Bags.Size = new System.Drawing.Size(75, 23);
            this.Bags.TabIndex = 1;
            this.Bags.Text = "Bags";
            this.Bags.UseVisualStyleBackColor = true;
            this.Bags.Click += new System.EventHandler(this.BagsClicked);
            // 
            // Dropoffs
            // 
            this.Dropoffs.Location = new System.Drawing.Point(533, 176);
            this.Dropoffs.Name = "Dropoffs";
            this.Dropoffs.Size = new System.Drawing.Size(75, 23);
            this.Dropoffs.TabIndex = 2;
            this.Dropoffs.Text = "Drop Offs";
            this.Dropoffs.UseVisualStyleBackColor = true;
            this.Dropoffs.Click += new System.EventHandler(this.DropoffsClicked);
            // 
            // ClientList
            // 
            this.ClientList.Location = new System.Drawing.Point(310, 244);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(75, 23);
            this.ClientList.TabIndex = 3;
            this.ClientList.Text = "Client List";
            this.ClientList.UseVisualStyleBackColor = true;
            this.ClientList.Click += new System.EventHandler(this.ClientsClicked);
            // 
            // ServiceReport
            // 
            this.ServiceReport.Location = new System.Drawing.Point(418, 244);
            this.ServiceReport.Name = "ServiceReport";
            this.ServiceReport.Size = new System.Drawing.Size(75, 23);
            this.ServiceReport.TabIndex = 4;
            this.ServiceReport.Text = "Service Report";
            this.ServiceReport.UseVisualStyleBackColor = true;
            this.ServiceReport.Click += new System.EventHandler(this.ServiceReportClicked);
            // 
            // Products
            // 
            this.Products.Location = new System.Drawing.Point(533, 244);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(75, 23);
            this.Products.TabIndex = 5;
            this.Products.Text = "Products";
            this.Products.UseVisualStyleBackColor = true;
            this.Products.Click += new System.EventHandler(this.ProductsClicked);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(787, 45);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(75, 23);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Log Out";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.LogoutClicked);
            // 
            // NewClient
            // 
            this.NewClient.Location = new System.Drawing.Point(311, 274);
            this.NewClient.Name = "NewClient";
            this.NewClient.Size = new System.Drawing.Size(75, 23);
            this.NewClient.TabIndex = 7;
            this.NewClient.Text = "New Client";
            this.NewClient.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.NewClient);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.ServiceReport);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.Dropoffs);
            this.Controls.Add(this.Bags);
            this.Controls.Add(this.Pickups);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "HomeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Pickups;
        private System.Windows.Forms.Button Bags;
        private System.Windows.Forms.Button Dropoffs;
        private System.Windows.Forms.Button ClientList;
        private System.Windows.Forms.Button ServiceReport;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button NewClient;

    }
}