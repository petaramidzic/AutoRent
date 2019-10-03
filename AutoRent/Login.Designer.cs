namespace AutoRent
{
    partial class frmLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtboxUserLogin = new System.Windows.Forms.TextBox();
            this.txtboxUserPass = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(167, 99);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Uloguj se";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtboxUserLogin
            // 
            this.txtboxUserLogin.Location = new System.Drawing.Point(142, 22);
            this.txtboxUserLogin.Name = "txtboxUserLogin";
            this.txtboxUserLogin.Size = new System.Drawing.Size(100, 20);
            this.txtboxUserLogin.TabIndex = 1;
            // 
            // txtboxUserPass
            // 
            this.txtboxUserPass.Location = new System.Drawing.Point(142, 59);
            this.txtboxUserPass.Name = "txtboxUserPass";
            this.txtboxUserPass.Size = new System.Drawing.Size(100, 20);
            this.txtboxUserPass.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(58, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Korisnicko ime:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(58, 62);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(47, 13);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Lozinka:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 171);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtboxUserPass);
            this.Controls.Add(this.txtboxUserLogin);
            this.Controls.Add(this.btnLogin);
            this.Name = "frmLogin";
            this.Text = "Logovanje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtboxUserLogin;
        private System.Windows.Forms.TextBox txtboxUserPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
    }
}

