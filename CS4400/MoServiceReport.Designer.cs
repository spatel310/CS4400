namespace CS4400
{
    partial class MoServiceReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.Active = new System.Windows.Forms.Button();
            this.LastMonth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Service Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(576, 337);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(735, 83);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(103, 23);
            this.ReturnHome.TabIndex = 2;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHome_Click);
            // 
            // Active
            // 
            this.Active.Location = new System.Drawing.Point(306, 52);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(75, 23);
            this.Active.TabIndex = 3;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = true;
            this.Active.Click += new System.EventHandler(this.Active_Click);
            // 
            // LastMonth
            // 
            this.LastMonth.Location = new System.Drawing.Point(427, 51);
            this.LastMonth.Name = "LastMonth";
            this.LastMonth.Size = new System.Drawing.Size(75, 23);
            this.LastMonth.TabIndex = 4;
            this.LastMonth.Text = "Last Month";
            this.LastMonth.UseVisualStyleBackColor = true;
            this.LastMonth.Click += new System.EventHandler(this.LastMonth_Click);
            // 
            // MoServiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.LastMonth);
            this.Controls.Add(this.Active);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "MoServiceReport";
            this.Text = "Monthly Service Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.Button Active;
        private System.Windows.Forms.Button LastMonth;
    }
}