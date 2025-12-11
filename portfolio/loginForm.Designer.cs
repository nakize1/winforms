using System.Drawing;
using System.Windows.Forms;

namespace portfolio
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.forgotLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.confirmTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.forgotLabel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.confirmTb);
            this.loginPanel.Controls.Add(this.passwordTb);
            this.loginPanel.Controls.Add(this.usernameTb);
            this.loginPanel.Controls.Add(this.registerBtn);
            this.loginPanel.Controls.Add(this.confirmBtn);
            this.loginPanel.Controls.Add(this.panel1);
            this.loginPanel.Location = new System.Drawing.Point(162, 117);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(783, 409);
            this.loginPanel.TabIndex = 0;
            // 
            // forgotLabel
            // 
            this.forgotLabel.AutoSize = true;
            this.forgotLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.forgotLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.forgotLabel.Location = new System.Drawing.Point(285, 268);
            this.forgotLabel.Name = "forgotLabel";
            this.forgotLabel.Size = new System.Drawing.Size(0, 20);
            this.forgotLabel.TabIndex = 4;
            this.forgotLabel.Visible = false;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(331, 13);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(101, 41);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Log In";
            // 
            // confirmTb
            // 
            this.confirmTb.ForeColor = System.Drawing.Color.Gray;
            this.confirmTb.Location = new System.Drawing.Point(289, 161);
            this.confirmTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmTb.Name = "confirmTb";
            this.confirmTb.PasswordChar = '●';
            this.confirmTb.Size = new System.Drawing.Size(187, 22);
            this.confirmTb.TabIndex = 2;
            this.confirmTb.Visible = false;
            // 
            // passwordTb
            // 
            this.passwordTb.ForeColor = System.Drawing.Color.Gray;
            this.passwordTb.Location = new System.Drawing.Point(289, 123);
            this.passwordTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '●';
            this.passwordTb.Size = new System.Drawing.Size(187, 22);
            this.passwordTb.TabIndex = 2;
            // 
            // usernameTb
            // 
            this.usernameTb.ForeColor = System.Drawing.Color.Gray;
            this.usernameTb.Location = new System.Drawing.Point(289, 85);
            this.usernameTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(187, 22);
            this.usernameTb.TabIndex = 1;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(311, 248);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(150, 25);
            this.registerBtn.TabIndex = 3;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.signupBtn_Click);
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(311, 200);
            this.confirmBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(150, 27);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "Log In";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Location = new System.Drawing.Point(232, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 233);
            this.panel1.TabIndex = 5;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1129, 598);
            this.Controls.Add(this.loginPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.Text = " ";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginPanel;
        private Label loginLabel;
        private Label forgotLabel;
        private TextBox confirmTb;
        private TextBox passwordTb;
        private TextBox usernameTb;
        private Button registerBtn;
        private Button confirmBtn;
        private Panel panel1;
    }
}
