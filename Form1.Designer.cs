using System;
using System.Drawing;
using System.Windows.Forms;

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
            this.BookingPanel = new System.Windows.Forms.Panel();
            this.ToOnlBillPanelBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionImg = new System.Windows.Forms.PictureBox();
            this.PenddingOrderList = new System.Windows.Forms.FlowLayoutPanel();
            this.ProductsCb = new System.Windows.Forms.ComboBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.QuantityTxtBox = new System.Windows.Forms.TextBox();
            this.OnlBillPanel = new System.Windows.Forms.Panel();
            this.TotalPriceOrderedLabel = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.BackToBookingBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.OrderedItemFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.loginPanel.SuspendLayout();
            this.signupPanel.SuspendLayout();
            this.BookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionImg)).BeginInit();
            this.OnlBillPanel.SuspendLayout();
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
            this.fLPTable.Location = new System.Drawing.Point(9, 3);
            this.fLPTable.Name = "fLPTable";
            this.fLPTable.Size = new System.Drawing.Size(969, 767);
            this.fLPTable.TabIndex = 12;
            this.fLPTable.Visible = false;
            // 
            // BookingPanel
            // 
            this.BookingPanel.Controls.Add(this.ToOnlBillPanelBtn);
            this.BookingPanel.Controls.Add(this.label10);
            this.BookingPanel.Controls.Add(this.label13);
            this.BookingPanel.Controls.Add(this.label12);
            this.BookingPanel.Controls.Add(this.label11);
            this.BookingPanel.Controls.Add(this.OrderBtn);
            this.BookingPanel.Controls.Add(this.TotalPriceLabel);
            this.BookingPanel.Controls.Add(this.DescriptionLabel);
            this.BookingPanel.Controls.Add(this.DescriptionImg);
            this.BookingPanel.Controls.Add(this.PenddingOrderList);
            this.BookingPanel.Controls.Add(this.ProductsCb);
            this.BookingPanel.Controls.Add(this.AddProduct);
            this.BookingPanel.Controls.Add(this.PriceLabel);
            this.BookingPanel.Controls.Add(this.QuantityTxtBox);
            this.BookingPanel.Location = new System.Drawing.Point(3, 3);
            this.BookingPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BookingPanel.Name = "BookingPanel";
            this.BookingPanel.Size = new System.Drawing.Size(975, 767);
            this.BookingPanel.TabIndex = 14;
            this.BookingPanel.Visible = false;
            // 
            // ToOnlBillPanelBtn
            // 
            this.ToOnlBillPanelBtn.AutoSize = true;
            this.ToOnlBillPanelBtn.Enabled = false;
            this.ToOnlBillPanelBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToOnlBillPanelBtn.Location = new System.Drawing.Point(726, 42);
            this.ToOnlBillPanelBtn.Name = "ToOnlBillPanelBtn";
            this.ToOnlBillPanelBtn.Size = new System.Drawing.Size(191, 42);
            this.ToOnlBillPanelBtn.TabIndex = 12;
            this.ToOnlBillPanelBtn.Text = "Xem Hóa Đơn";
            this.ToOnlBillPanelBtn.UseVisualStyleBackColor = true;
            this.ToOnlBillPanelBtn.Click += new System.EventHandler(this.ToOnlBillPanelBtn_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(435, 105);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(518, 58);
            this.label10.TabIndex = 0;
            this.label10.Text = "Pendding Order List";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(459, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 29);
            this.label13.TabIndex = 11;
            this.label13.Text = "Đơn giá";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(289, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 29);
            this.label12.TabIndex = 10;
            this.label12.Text = "Số lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 29);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tên sản phẩm";
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.OrderBtn.Enabled = false;
            this.OrderBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderBtn.Location = new System.Drawing.Point(642, 706);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(131, 42);
            this.OrderBtn.TabIndex = 8;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceLabel.Location = new System.Drawing.Point(435, 672);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(270, 29);
            this.TotalPriceLabel.TabIndex = 7;
            this.TotalPriceLabel.Text = "Tổng hóa đơn dự kiến: 0$";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(22, 548);
            this.DescriptionLabel.MaximumSize = new System.Drawing.Size(365, 0);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(129, 29);
            this.DescriptionLabel.TabIndex = 6;
            this.DescriptionLabel.Text = "Description";
            // 
            // DescriptionImg
            // 
            this.DescriptionImg.Location = new System.Drawing.Point(18, 105);
            this.DescriptionImg.Name = "DescriptionImg";
            this.DescriptionImg.Size = new System.Drawing.Size(377, 420);
            this.DescriptionImg.TabIndex = 5;
            this.DescriptionImg.TabStop = false;
            // 
            // PenddingOrderList
            // 
            this.PenddingOrderList.AutoScroll = true;
            this.PenddingOrderList.AutoScrollMinSize = new System.Drawing.Size(0, 450);
            this.PenddingOrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PenddingOrderList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PenddingOrderList.Location = new System.Drawing.Point(435, 163);
            this.PenddingOrderList.Name = "PenddingOrderList";
            this.PenddingOrderList.Size = new System.Drawing.Size(518, 489);
            this.PenddingOrderList.TabIndex = 4;
            this.PenddingOrderList.WrapContents = false;
            // 
            // ProductsCb
            // 
            this.ProductsCb.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsCb.FormattingEnabled = true;
            this.ProductsCb.Location = new System.Drawing.Point(14, 44);
            this.ProductsCb.Margin = new System.Windows.Forms.Padding(0);
            this.ProductsCb.Name = "ProductsCb";
            this.ProductsCb.Size = new System.Drawing.Size(271, 37);
            this.ProductsCb.TabIndex = 0;
            this.ProductsCb.SelectedIndexChanged += new System.EventHandler(this.ProductCBSelectedValueChanged);
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.Location = new System.Drawing.Point(558, 44);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(96, 37);
            this.AddProduct.TabIndex = 3;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(469, 48);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(63, 29);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // QuantityTxtBox
            // 
            this.QuantityTxtBox.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTxtBox.Location = new System.Drawing.Point(289, 44);
            this.QuantityTxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.QuantityTxtBox.Name = "QuantityTxtBox";
            this.QuantityTxtBox.Size = new System.Drawing.Size(166, 36);
            this.QuantityTxtBox.TabIndex = 1;
            this.QuantityTxtBox.Text = "Enter quantity...";
            this.QuantityTxtBox.Enter += new System.EventHandler(this.RemoveQuantityPlaceHolder);
            this.QuantityTxtBox.Leave += new System.EventHandler(this.AddQuantityPlaceHolder);
            // 
            // OnlBillPanel
            // 
            this.OnlBillPanel.Controls.Add(this.TotalPriceOrderedLabel);
            this.OnlBillPanel.Controls.Add(this.PayBtn);
            this.OnlBillPanel.Controls.Add(this.BackToBookingBtn);
            this.OnlBillPanel.Controls.Add(this.label14);
            this.OnlBillPanel.Controls.Add(this.OrderedItemFLP);
            this.OnlBillPanel.Location = new System.Drawing.Point(0, 0);
            this.OnlBillPanel.Margin = new System.Windows.Forms.Padding(0);
            this.OnlBillPanel.Name = "OnlBillPanel";
            this.OnlBillPanel.Size = new System.Drawing.Size(978, 775);
            this.OnlBillPanel.TabIndex = 12;
            this.OnlBillPanel.Visible = false;
            // 
            // TotalPriceOrderedLabel
            // 
            this.TotalPriceOrderedLabel.AutoSize = true;
            this.TotalPriceOrderedLabel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPriceOrderedLabel.Location = new System.Drawing.Point(227, 657);
            this.TotalPriceOrderedLabel.Name = "TotalPriceOrderedLabel";
            this.TotalPriceOrderedLabel.Size = new System.Drawing.Size(153, 29);
            this.TotalPriceOrderedLabel.TabIndex = 9;
            this.TotalPriceOrderedLabel.Text = "Tổng hóa đơn";
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.Lime;
            this.PayBtn.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayBtn.Location = new System.Drawing.Point(226, 693);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(500, 65);
            this.PayBtn.TabIndex = 8;
            this.PayBtn.Text = "Thanh Toán";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // BackToBookingBtn
            // 
            this.BackToBookingBtn.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToBookingBtn.Location = new System.Drawing.Point(27, 40);
            this.BackToBookingBtn.Name = "BackToBookingBtn";
            this.BackToBookingBtn.Size = new System.Drawing.Size(110, 53);
            this.BackToBookingBtn.TabIndex = 7;
            this.BackToBookingBtn.Text = "Back";
            this.BackToBookingBtn.UseVisualStyleBackColor = true;
            this.BackToBookingBtn.Click += new System.EventHandler(this.BackToBookingBtn_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(226, 17);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 2, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(500, 77);
            this.label14.TabIndex = 5;
            this.label14.Text = "Ordered Item List";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderedItemFLP
            // 
            this.OrderedItemFLP.AutoScroll = true;
            this.OrderedItemFLP.AutoScrollMinSize = new System.Drawing.Size(0, 450);
            this.OrderedItemFLP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OrderedItemFLP.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.OrderedItemFLP.Location = new System.Drawing.Point(226, 94);
            this.OrderedItemFLP.Name = "OrderedItemFLP";
            this.OrderedItemFLP.Size = new System.Drawing.Size(500, 552);
            this.OrderedItemFLP.TabIndex = 6;
            this.OrderedItemFLP.WrapContents = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 782);
            this.Controls.Add(this.BookingPanel);
            this.Controls.Add(this.ShowSignupBtn);
            this.Controls.Add(this.ShowLoginBtn);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.signupPanel);
            this.Controls.Add(this.fLPTable);
            this.Controls.Add(this.OnlBillPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            this.BookingPanel.ResumeLayout(false);
            this.BookingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionImg)).EndInit();
            this.OnlBillPanel.ResumeLayout(false);
            this.OnlBillPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel BookingPanel;
        private System.Windows.Forms.ComboBox ProductsCb;
        private System.Windows.Forms.TextBox QuantityTxtBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.FlowLayoutPanel PenddingOrderList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.PictureBox DescriptionImg;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Button OrderBtn;
        private Label label13;
        private Label label12;
        private Label label11;
        private Panel OnlBillPanel;
        private Label label14;
        private FlowLayoutPanel OrderedItemFLP;
        private Button BackToBookingBtn;
        private Button PayBtn;
        private Label TotalPriceOrderedLabel;
        private Button ToOnlBillPanelBtn;
    }
}

