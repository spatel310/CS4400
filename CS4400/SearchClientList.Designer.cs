namespace CS4400
{
    partial class SearchClientList
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
            this.ClientList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.SearchBy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(764, 51);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(103, 23);
            this.ReturnHome.TabIndex = 0;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // ClientList
            // 
            this.ClientList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientList.Location = new System.Drawing.Point(67, 205);
            this.ClientList.Name = "ClientList";
            this.ClientList.Size = new System.Drawing.Size(800, 286);
            this.ClientList.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(673, 144);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 20);
            this.textBox2.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(64, 144);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(61, 13);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Last Name:";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(520, 144);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(61, 13);
            this.Telephone.TabIndex = 5;
            this.Telephone.Text = "Telephone:";
            // 
            // SearchBy
            // 
            this.SearchBy.AutoSize = true;
            this.SearchBy.Location = new System.Drawing.Point(64, 116);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(68, 13);
            this.SearchBy.TabIndex = 6;
            this.SearchBy.Text = "SEARCH BY";
            // 
            // SearchClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.SearchBy);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClientList);
            this.Controls.Add(this.ReturnHome);
            this.Name = "SearchClientList";
            this.Text = "SearchClientList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.DataGridView ClientList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label SearchBy;
    }
}