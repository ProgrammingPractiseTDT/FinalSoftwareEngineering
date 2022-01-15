namespace CompanyWinform
{
    partial class Login
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
            this.emailLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.confirmLoginButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // emailLogin
            // 
            this.emailLogin.Location = new System.Drawing.Point(128, 133);
            this.emailLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.Size = new System.Drawing.Size(360, 31);
            this.emailLogin.TabIndex = 1;
            this.emailLogin.Text = "admin1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 242);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(128, 272);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.PasswordChar = '*';
            this.passwordLogin.Size = new System.Drawing.Size(360, 31);
            this.passwordLogin.TabIndex = 3;
            this.passwordLogin.Text = "123456";
            // 
            // confirmLoginButton
            // 
            this.confirmLoginButton.Location = new System.Drawing.Point(106, 386);
            this.confirmLoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmLoginButton.Name = "confirmLoginButton";
            this.confirmLoginButton.Size = new System.Drawing.Size(136, 80);
            this.confirmLoginButton.TabIndex = 4;
            this.confirmLoginButton.Text = "Login";
            this.confirmLoginButton.UseVisualStyleBackColor = true;
            this.confirmLoginButton.Click += new System.EventHandler(this.confirmLoginButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 386);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 80);
            this.button2.TabIndex = 5;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(626, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirmLoginButton);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emailLogin);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Button confirmLoginButton;
        private System.Windows.Forms.Button button2;
    }
}

