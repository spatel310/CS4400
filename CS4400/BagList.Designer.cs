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
            this.listBox1 = new System.Windows.Forms.ListBox();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(214, 176);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            // 
            // BagList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 512);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ReturnHome);
            this.Name = "BagList";
            this.Text = "BagList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.ListBox listBox1;
    }
}