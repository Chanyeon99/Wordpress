﻿
namespace UserManagement
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkViewPass = new System.Windows.Forms.CheckBox();
            this.btnViewPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRequiredPassword = new System.Windows.Forms.Label();
            this.labelRequiredUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.checkViewPass);
            this.groupBox1.Controls.Add(this.btnViewPass);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelRequiredPassword);
            this.groupBox1.Controls.Add(this.labelRequiredUserName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(240, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(771, 402);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // checkViewPass
            // 
            this.checkViewPass.AutoSize = true;
            this.checkViewPass.Location = new System.Drawing.Point(591, 263);
            this.checkViewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkViewPass.Name = "checkViewPass";
            this.checkViewPass.Size = new System.Drawing.Size(114, 20);
            this.checkViewPass.TabIndex = 29;
            this.checkViewPass.Text = "Hiện mật khẩu";
            this.checkViewPass.UseVisualStyleBackColor = true;
            this.checkViewPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnViewPass
            // 
            this.btnViewPass.FlatAppearance.BorderSize = 0;
            this.btnViewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPass.Image = ((System.Drawing.Image)(resources.GetObject("btnViewPass.Image")));
            this.btnViewPass.Location = new System.Drawing.Point(548, 257);
            this.btnViewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(37, 25);
            this.btnViewPass.TabIndex = 28;
            this.btnViewPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 126);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Mật khẩu :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tài khoản :";
            // 
            // labelRequiredPassword
            // 
            this.labelRequiredPassword.AutoSize = true;
            this.labelRequiredPassword.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredPassword.Location = new System.Drawing.Point(309, 265);
            this.labelRequiredPassword.Name = "labelRequiredPassword";
            this.labelRequiredPassword.Size = new System.Drawing.Size(186, 16);
            this.labelRequiredPassword.TabIndex = 24;
            this.labelRequiredPassword.Text = "Mật khẩu không được để trống";
            this.labelRequiredPassword.Visible = false;
            // 
            // labelRequiredUserName
            // 
            this.labelRequiredUserName.AutoSize = true;
            this.labelRequiredUserName.ForeColor = System.Drawing.Color.Red;
            this.labelRequiredUserName.Location = new System.Drawing.Point(309, 176);
            this.labelRequiredUserName.Name = "labelRequiredUserName";
            this.labelRequiredUserName.Size = new System.Drawing.Size(223, 16);
            this.labelRequiredUserName.TabIndex = 23;
            this.labelRequiredUserName.Text = "Tên đăng nhập không được để trống";
            this.labelRequiredUserName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(371, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Đăng Nhập Hệ Thống";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(313, 302);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(399, 41);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPassword.Location = new System.Drawing.Point(313, 222);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(399, 34);
            this.txtPassword.TabIndex = 19;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged_1);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtUsername.Location = new System.Drawing.Point(312, 132);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(400, 34);
            this.txtUsername.TabIndex = 18;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(192)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1251, 726);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRequiredPassword;
        private System.Windows.Forms.Label labelRequiredUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox checkViewPass;
        private System.Windows.Forms.Button btnViewPass;
    }
}