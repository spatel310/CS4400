namespace CS4400
{
    partial class PickupSignInList
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
            this.PickUpSignInListTable = new System.Windows.Forms.DataGridView();
            this.EnterDay = new System.Windows.Forms.Button();
            this.DayNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PickUpSignInListTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(762, 49);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(94, 23);
            this.ReturnHome.TabIndex = 1;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // PickUpSignInListTable
            // 
            this.PickUpSignInListTable.AllowUserToAddRows = false;
            this.PickUpSignInListTable.AllowUserToDeleteRows = false;
            this.PickUpSignInListTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PickUpSignInListTable.Location = new System.Drawing.Point(139, 161);
            this.PickUpSignInListTable.Name = "PickUpSignInListTable";
            this.PickUpSignInListTable.ReadOnly = true;
            this.PickUpSignInListTable.ShowEditingIcon = false;
            this.PickUpSignInListTable.Size = new System.Drawing.Size(150, 150);
            this.PickUpSignInListTable.TabIndex = 2;
            // 
            // EnterDay
            // 
            this.EnterDay.Location = new System.Drawing.Point(164, 82);
            this.EnterDay.Name = "EnterDay";
            this.EnterDay.Size = new System.Drawing.Size(75, 23);
            this.EnterDay.TabIndex = 3;
            this.EnterDay.Text = "Enter Day";
            this.EnterDay.UseVisualStyleBackColor = true;
            this.EnterDay.Click += new System.EventHandler(this.EnterDayClicked);
            // 
            // DayNumber
            // 
            this.DayNumber.Location = new System.Drawing.Point(257, 84);
            this.DayNumber.Name = "DayNumber";
            this.DayNumber.Size = new System.Drawing.Size(32, 20);
            this.DayNumber.TabIndex = 4;
            // 
            // PickupSignInList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.DayNumber);
            this.Controls.Add(this.EnterDay);
            this.Controls.Add(this.PickUpSignInListTable);
            this.Controls.Add(this.ReturnHome);
            this.Name = "PickupSignInList";
            this.Text = "PickupSignInList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PickUpSignInListTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.DataGridView PickUpSignInListTable;
        private System.Windows.Forms.Button EnterDay;
        private System.Windows.Forms.TextBox DayNumber;
    }
}