namespace ELAB_Information
{
    partial class register
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
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backMenu = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(91, 121);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(180, 21);
            this.username.TabIndex = 1;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(91, 166);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(180, 21);
            this.password.TabIndex = 3;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // checkPassword
            // 
            this.checkPassword.Location = new System.Drawing.Point(91, 215);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.PasswordChar = '*';
            this.checkPassword.Size = new System.Drawing.Size(180, 21);
            this.checkPassword.TabIndex = 5;
            this.checkPassword.TextChanged += new System.EventHandler(this.checkPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码";
            // 
            // backMenu
            // 
            this.backMenu.Location = new System.Drawing.Point(49, 266);
            this.backMenu.Name = "backMenu";
            this.backMenu.Size = new System.Drawing.Size(92, 28);
            this.backMenu.TabIndex = 6;
            this.backMenu.Text = "返回";
            this.backMenu.UseVisualStyleBackColor = true;
            this.backMenu.Click += new System.EventHandler(this.backMenu_Click);
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(164, 266);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(92, 28);
            this.check.TabIndex = 7;
            this.check.Text = "确认";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 323);
            this.Controls.Add(this.check);
            this.Controls.Add(this.backMenu);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "register";
            this.Text = "注册";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox checkPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backMenu;
        private System.Windows.Forms.Button check;
    }
}