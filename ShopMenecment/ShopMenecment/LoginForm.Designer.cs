namespace ShopMenecment
{
    partial class LoginForm
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
            this.txbusername = new System.Windows.Forms.TextBox();
            this.txbpassword = new System.Windows.Forms.TextBox();
            this.lblusername = new System.Windows.Forms.Label();
            this.Lblpassword = new System.Windows.Forms.Label();
            this.Btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbusername
            // 
            this.txbusername.Location = new System.Drawing.Point(222, 32);
            this.txbusername.Name = "txbusername";
            this.txbusername.Size = new System.Drawing.Size(100, 20);
            this.txbusername.TabIndex = 0;
            // 
            // txbpassword
            // 
            this.txbpassword.Location = new System.Drawing.Point(222, 92);
            this.txbpassword.Name = "txbpassword";
            this.txbpassword.Size = new System.Drawing.Size(100, 20);
            this.txbpassword.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(154, 32);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(55, 13);
            this.lblusername.TabIndex = 2;
            this.lblusername.Text = "Username";
            // 
            // Lblpassword
            // 
            this.Lblpassword.AutoSize = true;
            this.Lblpassword.Location = new System.Drawing.Point(154, 92);
            this.Lblpassword.Name = "Lblpassword";
            this.Lblpassword.Size = new System.Drawing.Size(53, 13);
            this.Lblpassword.TabIndex = 3;
            this.Lblpassword.Text = "Password";
            // 
            // Btnlogin
            // 
            this.Btnlogin.Location = new System.Drawing.Point(264, 142);
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Size = new System.Drawing.Size(75, 23);
            this.Btnlogin.TabIndex = 4;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.Lblpassword);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.txbpassword);
            this.Controls.Add(this.txbusername);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbusername;
        private System.Windows.Forms.TextBox txbpassword;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label Lblpassword;
        private System.Windows.Forms.Button Btnlogin;
    }
}