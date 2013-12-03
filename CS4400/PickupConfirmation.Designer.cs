namespace CS4400
{
    partial class PickupConfirmation
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
            this.BagContents = new System.Windows.Forms.DataGridView();
            this.ReturnHome = new System.Windows.Forms.Button();
            this.ReturnToPickupSignInList = new System.Windows.Forms.Button();
            this.CompletePickup = new System.Windows.Forms.Button();
            this.AreYouSure = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BagContents)).BeginInit();
            this.SuspendLayout();
            // 
            // BagContents
            // 
            this.BagContents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BagContents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BagContents.Location = new System.Drawing.Point(140, 99);
            this.BagContents.Name = "BagContents";
            this.BagContents.Size = new System.Drawing.Size(303, 262);
            this.BagContents.TabIndex = 0;
            // 
            // ReturnHome
            // 
            this.ReturnHome.Location = new System.Drawing.Point(662, 53);
            this.ReturnHome.Name = "ReturnHome";
            this.ReturnHome.Size = new System.Drawing.Size(125, 23);
            this.ReturnHome.TabIndex = 1;
            this.ReturnHome.Text = "Return Home";
            this.ReturnHome.UseVisualStyleBackColor = true;
            this.ReturnHome.Click += new System.EventHandler(this.ReturnHomeClicked);
            // 
            // ReturnToPickupSignInList
            // 
            this.ReturnToPickupSignInList.Location = new System.Drawing.Point(662, 82);
            this.ReturnToPickupSignInList.Name = "ReturnToPickupSignInList";
            this.ReturnToPickupSignInList.Size = new System.Drawing.Size(125, 23);
            this.ReturnToPickupSignInList.TabIndex = 2;
            this.ReturnToPickupSignInList.Text = "Return To Sign-In List";
            this.ReturnToPickupSignInList.UseVisualStyleBackColor = true;
            this.ReturnToPickupSignInList.Click += new System.EventHandler(this.ReturnToSignInListClicked);
            // 
            // CompletePickup
            // 
            this.CompletePickup.Location = new System.Drawing.Point(140, 387);
            this.CompletePickup.Name = "CompletePickup";
            this.CompletePickup.Size = new System.Drawing.Size(75, 23);
            this.CompletePickup.TabIndex = 3;
            this.CompletePickup.Text = "Complete Pickup";
            this.CompletePickup.UseVisualStyleBackColor = true;
            this.CompletePickup.Click += new System.EventHandler(this.CompletePickupClicked);
            // 
            // AreYouSure
            // 
            this.AreYouSure.AutoSize = true;
            this.AreYouSure.Location = new System.Drawing.Point(221, 392);
            this.AreYouSure.Name = "AreYouSure";
            this.AreYouSure.Size = new System.Drawing.Size(0, 13);
            this.AreYouSure.TabIndex = 4;
            // 
            // PickupConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 521);
            this.Controls.Add(this.AreYouSure);
            this.Controls.Add(this.CompletePickup);
            this.Controls.Add(this.ReturnToPickupSignInList);
            this.Controls.Add(this.ReturnHome);
            this.Controls.Add(this.BagContents);
            this.Name = "PickupConfirmation";
            this.Text = "PickupConfirmation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.BagContents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BagContents;
        private System.Windows.Forms.Button ReturnHome;
        private System.Windows.Forms.Button ReturnToPickupSignInList;
        private System.Windows.Forms.Button CompletePickup;
        private System.Windows.Forms.Label AreYouSure;
    }
}