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
            this.TelephoneTB = new System.Windows.Forms.TextBox();
            this.LastNameTB = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.SearchBy = new System.Windows.Forms.Label();
            this.SearchLastName = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.ClientList.ReadOnly = true;
            this.ClientList.Size = new System.Drawing.Size(800, 286);
            this.ClientList.TabIndex = 1;
            // 
            // TelephoneTB
            // 
            this.TelephoneTB.Location = new System.Drawing.Point(368, 144);
            this.TelephoneTB.Name = "TelephoneTB";
            this.TelephoneTB.Size = new System.Drawing.Size(164, 20);
            this.TelephoneTB.TabIndex = 2;
            // 
            // LastNameTB
            // 
            this.LastNameTB.Location = new System.Drawing.Point(131, 144);
            this.LastNameTB.Name = "LastNameTB";
            this.LastNameTB.Size = new System.Drawing.Size(164, 20);
            this.LastNameTB.TabIndex = 3;
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
            this.Telephone.Location = new System.Drawing.Point(301, 144);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(61, 13);
            this.Telephone.TabIndex = 5;
            this.Telephone.Text = "Telephone:";
            // 
            // SearchBy
            // 
            this.SearchBy.AutoSize = true;
            this.SearchBy.Location = new System.Drawing.Point(57, 118);
            this.SearchBy.Name = "SearchBy";
            this.SearchBy.Size = new System.Drawing.Size(68, 13);
            this.SearchBy.TabIndex = 6;
            this.SearchBy.Text = "SEARCH BY";
            // 
            // SearchLastName
            // 
            this.SearchLastName.Location = new System.Drawing.Point(131, 170);
            this.SearchLastName.Name = "SearchLastName";
            this.SearchLastName.Size = new System.Drawing.Size(164, 23);
            this.SearchLastName.TabIndex = 7;
            this.SearchLastName.Text = "Search by Last Name";
            this.SearchLastName.UseVisualStyleBackColor = true;
            this.SearchLastName.Click += new System.EventHandler(this.SearchLastNameClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(368, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Search by Telephone";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchTelephoneClicked);
            // 
            // SearchClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchLastName);
            this.Controls.Add(this.SearchBy);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.LastNameTB);
            this.Controls.Add(this.TelephoneTB);
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
        private System.Windows.Forms.TextBox TelephoneTB;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.Label SearchBy;
        private System.Windows.Forms.Button SearchLastName;
        private System.Windows.Forms.Button button1;
    }
}