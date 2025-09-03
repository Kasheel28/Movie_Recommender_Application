namespace Movie_Recommender_Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(387, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(170, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(170, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.username.Location = new System.Drawing.Point(358, 174);
            this.username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(181, 41);
            this.username.TabIndex = 3;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.password.Location = new System.Drawing.Point(358, 235);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(181, 41);
            this.password.TabIndex = 4;
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.loginbtn.Location = new System.Drawing.Point(382, 329);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(156, 59);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.register.Location = new System.Drawing.Point(410, 391);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(108, 25);
            this.register.TabIndex = 6;
            this.register.TabStop = true;
            this.register.Text = "New User?";
            this.register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.register_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.register);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.LinkLabel register;
    }
}

