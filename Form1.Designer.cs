using System;

namespace resaurant_management_windows
{
    partial class MainForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.matchLabel = new System.Windows.Forms.Label();
            this.SignupPasswordConfirm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.SignupPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SignupUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ShowLoginBtn = new System.Windows.Forms.Button();
            this.ShowSignupBtn = new System.Windows.Forms.Button();
            this.fLPTable = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductsCb = new System.Windows.Forms.ComboBox();
            this.BookingProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.PriceTxtBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.signupPanel.SuspendLayout();
            this.BookingProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.button1);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.LoginBtn);
            this.loginPanel.Controls.Add(this.LoginPassword);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.LoginUsername);
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Location = new System.Drawing.Point(231, 76);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(463, 527);
            this.loginPanel.TabIndex = 1;
            this.loginPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(345, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sign up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ShowSignupPanel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Don\'t have account ?";
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.Location = new System.Drawing.Point(163, 288);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(99, 32);
            this.LoginBtn.TabIndex = 6;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.HandleLogin);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword.Location = new System.Drawing.Point(163, 235);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(175, 30);
            this.LoginPassword.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "User name";
            // 
            // LoginUsername
            // 
            this.LoginUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUsername.Location = new System.Drawing.Point(163, 154);
            this.LoginUsername.Name = "LoginUsername";
            this.LoginUsername.Size = new System.Drawing.Size(175, 30);
            this.LoginUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // signupPanel
            // 
            this.signupPanel.Controls.Add(this.matchLabel);
            this.signupPanel.Controls.Add(this.SignupPasswordConfirm);
            this.signupPanel.Controls.Add(this.label9);
            this.signupPanel.Controls.Add(this.button3);
            this.signupPanel.Controls.Add(this.label5);
            this.signupPanel.Controls.Add(this.SignupBtn);
            this.signupPanel.Controls.Add(this.SignupPassword);
            this.signupPanel.Controls.Add(this.label6);
            this.signupPanel.Controls.Add(this.label7);
            this.signupPanel.Controls.Add(this.SignupUsername);
            this.signupPanel.Controls.Add(this.label8);
            this.signupPanel.Location = new System.Drawing.Point(231, 76);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(463, 524);
            this.signupPanel.TabIndex = 9;
            this.signupPanel.Visible = false;
            // 
            // matchLabel
            // 
            this.matchLabel.AutoSize = true;
            this.matchLabel.Location = new System.Drawing.Point(159, 325);
            this.matchLabel.Name = "matchLabel";
            this.matchLabel.Size = new System.Drawing.Size(0, 16);
            this.matchLabel.TabIndex = 19;
            // 
            // SignupPasswordConfirm
            // 
            this.SignupPasswordConfirm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupPasswordConfirm.Location = new System.Drawing.Point(155, 286);
            this.SignupPasswordConfirm.Name = "SignupPasswordConfirm";
            this.SignupPasswordConfirm.PasswordChar = '*';
            this.SignupPasswordConfirm.Size = new System.Drawing.Size(175, 30);
            this.SignupPasswordConfirm.TabIndex = 13;
            this.SignupPasswordConfirm.TextChanged += new System.EventHandler(this.SignupPasswordConfirm_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(155, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password Confirm";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(353, 396);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 17;
            this.button3.Text = "Login";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ShowLoginPanel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 22);
            this.label5.TabIndex = 16;
            this.label5.Text = "Already have account ?";
            // 
            // SignupBtn
            // 
            this.SignupBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.Location = new System.Drawing.Point(155, 347);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(99, 32);
            this.SignupBtn.TabIndex = 14;
            this.SignupBtn.Text = "Sign up";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // SignupPassword
            // 
            this.SignupPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupPassword.Location = new System.Drawing.Point(155, 208);
            this.SignupPassword.Name = "SignupPassword";
            this.SignupPassword.PasswordChar = '*';
            this.SignupPassword.Size = new System.Drawing.Size(175, 30);
            this.SignupPassword.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(155, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(155, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "User name";
            // 
            // SignupUsername
            // 
            this.SignupUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupUsername.Location = new System.Drawing.Point(155, 135);
            this.SignupUsername.Name = "SignupUsername";
            this.SignupUsername.Size = new System.Drawing.Size(175, 30);
            this.SignupUsername.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(203, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sign up";
            // 
            // ShowLoginBtn
            // 
            this.ShowLoginBtn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowLoginBtn.Location = new System.Drawing.Point(280, 280);
            this.ShowLoginBtn.Name = "ShowLoginBtn";
            this.ShowLoginBtn.Size = new System.Drawing.Size(220, 110);
            this.ShowLoginBtn.TabIndex = 10;
            this.ShowLoginBtn.Text = "Login";
            this.ShowLoginBtn.UseVisualStyleBackColor = true;
            this.ShowLoginBtn.Click += new System.EventHandler(this.ShowLoginBtn_Click);
            // 
            // ShowSignupBtn
            // 
            this.ShowSignupBtn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowSignupBtn.Location = new System.Drawing.Point(500, 280);
            this.ShowSignupBtn.Name = "ShowSignupBtn";
            this.ShowSignupBtn.Size = new System.Drawing.Size(220, 110);
            this.ShowSignupBtn.TabIndex = 11;
            this.ShowSignupBtn.Text = "Sign up";
            this.ShowSignupBtn.UseVisualStyleBackColor = true;
            this.ShowSignupBtn.Click += new System.EventHandler(this.ShowSignupBtn_Click);
            // 
            // fLPTable
            // 
            this.fLPTable.AutoScroll = true;
            this.fLPTable.AutoSize = true;
            this.fLPTable.Location = new System.Drawing.Point(9, 3);
            this.fLPTable.Name = "fLPTable";
            this.fLPTable.Size = new System.Drawing.Size(969, 774);
            this.fLPTable.TabIndex = 12;
            this.fLPTable.Visible = false;
            // 
            // ProductsCb
            // 
            this.ProductsCb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsCb.Location = new System.Drawing.Point(3, 3);
            this.ProductsCb.Name = "ProductsCb";
            this.ProductsCb.Size = new System.Drawing.Size(274, 37);
            this.ProductsCb.TabIndex = 0;
            this.ProductsCb.SelectedIndexChanged += new System.EventHandler(this.ProductCBSelectedValueChanged);
            // 
            // BookingProduct
            // 
            this.BookingProduct.AutoScroll = true;
            this.BookingProduct.AutoSize = true;
            this.BookingProduct.Controls.Add(this.ProductsCb);
            this.BookingProduct.Controls.Add(this.PriceTxtBox);
            this.BookingProduct.Location = new System.Drawing.Point(3, 3);
            this.BookingProduct.Name = "BookingProduct";
            this.BookingProduct.Size = new System.Drawing.Size(975, 774);
            this.BookingProduct.TabIndex = 13;
            this.BookingProduct.Visible = false;
            // 
            // PriceTxtBox
            // 
            this.PriceTxtBox.Enabled = false;
            this.PriceTxtBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTxtBox.Location = new System.Drawing.Point(283, 3);
            this.PriceTxtBox.Name = "PriceTxtBox";
            this.PriceTxtBox.Size = new System.Drawing.Size(80, 36);
            this.PriceTxtBox.TabIndex = 1;
            this.PriceTxtBox.Text = "Price";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 782);
            this.Controls.Add(this.ShowSignupBtn);
            this.Controls.Add(this.ShowLoginBtn);
            this.Controls.Add(this.signupPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.BookingProduct);
            this.Controls.Add(this.fLPTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resaurant";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            this.BookingProduct.ResumeLayout(false);
            this.BookingProduct.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ShowSignupBtn_Click(object sender, EventArgs e)
        {
            this.ShowSignupBtn.Visible = false;
            this.ShowLoginBtn.Visible = false;
            this.signupPanel.Visible = true;
        }

        private void ShowLoginBtn_Click(object sender, System.EventArgs e)
        {
            this.ShowSignupBtn.Visible = false;
            this.ShowLoginBtn.Visible = false;
            this.loginPanel.Visible = true;
        }

        #endregion
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SignupBtn;
        private System.Windows.Forms.TextBox SignupPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SignupUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SignupPasswordConfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ShowLoginBtn;
        private System.Windows.Forms.Button ShowSignupBtn;
        private System.Windows.Forms.Label matchLabel;
        private System.Windows.Forms.FlowLayoutPanel fLPTable;
        private System.Windows.Forms.ComboBox ProductsCb;
        private System.Windows.Forms.FlowLayoutPanel BookingProduct;
        private System.Windows.Forms.TextBox PriceTxtBox;
    }
}

