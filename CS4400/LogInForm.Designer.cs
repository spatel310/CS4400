namespace CS4400
{
    partial class LogInForm
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
            this.LogIn = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(351, 231);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "Log In";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogInClicked);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(351, 205);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 1;
            this.Password.Text = "password";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(351, 179);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 20);
            this.Username.TabIndex = 2;
            this.Username.Text = "username";
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 412);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LogIn);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
    }

}

