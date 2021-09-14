
namespace UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel_Login = new System.Windows.Forms.Panel();
            this.panel_SignUp = new System.Windows.Forms.Panel();
            this.PhoneText = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDText = new Guna.UI2.WinForms.Guna2TextBox();
            this.PWText = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button_OK = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button_IDcheck = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ImageButton_SignUp_Exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button_SignUp = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ImageButton_Login_Exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Button_Login = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox_PW = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox_ID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel_Login_PW = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel_Login_ID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_Login.SuspendLayout();
            this.panel_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.White;
            this.panel_Login.Controls.Add(this.panel_SignUp);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Controls.Add(this.guna2Button_SignUp);
            this.panel_Login.Controls.Add(this.guna2ImageButton_Login_Exit);
            this.panel_Login.Controls.Add(this.guna2Button_Login);
            this.panel_Login.Controls.Add(this.guna2TextBox_PW);
            this.panel_Login.Controls.Add(this.guna2TextBox_ID);
            this.panel_Login.Controls.Add(this.guna2HtmlLabel_Login_PW);
            this.panel_Login.Controls.Add(this.guna2HtmlLabel_Login_ID);
            this.panel_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Login.Location = new System.Drawing.Point(5, 5);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(411, 311);
            this.panel_Login.TabIndex = 0;
            this.panel_Login.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Login_MouseDown);
            // 
            // panel_SignUp
            // 
            this.panel_SignUp.BackColor = System.Drawing.Color.White;
            this.panel_SignUp.Controls.Add(this.PhoneText);
            this.panel_SignUp.Controls.Add(this.IDText);
            this.panel_SignUp.Controls.Add(this.PWText);
            this.panel_SignUp.Controls.Add(this.NameText);
            this.panel_SignUp.Controls.Add(this.guna2Button_OK);
            this.panel_SignUp.Controls.Add(this.guna2Button_IDcheck);
            this.panel_SignUp.Controls.Add(this.label6);
            this.panel_SignUp.Controls.Add(this.label5);
            this.panel_SignUp.Controls.Add(this.label4);
            this.panel_SignUp.Controls.Add(this.label3);
            this.panel_SignUp.Controls.Add(this.label2);
            this.panel_SignUp.Controls.Add(this.guna2ImageButton_SignUp_Exit);
            this.panel_SignUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_SignUp.Location = new System.Drawing.Point(0, 0);
            this.panel_SignUp.Name = "panel_SignUp";
            this.panel_SignUp.Size = new System.Drawing.Size(411, 311);
            this.panel_SignUp.TabIndex = 0;
            this.panel_SignUp.Visible = false;
            this.panel_SignUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_SignUp_MouseDown);
            // 
            // PhoneText
            // 
            this.PhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneText.DefaultText = "";
            this.PhoneText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneText.DisabledState.Parent = this.PhoneText;
            this.PhoneText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneText.FocusedState.Parent = this.PhoneText;
            this.PhoneText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PhoneText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneText.HoverState.Parent = this.PhoneText;
            this.PhoneText.Location = new System.Drawing.Point(94, 239);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.PasswordChar = '\0';
            this.PhoneText.PlaceholderText = "";
            this.PhoneText.SelectedText = "";
            this.PhoneText.ShadowDecoration.Parent = this.PhoneText;
            this.PhoneText.Size = new System.Drawing.Size(222, 23);
            this.PhoneText.TabIndex = 4;
            // 
            // IDText
            // 
            this.IDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDText.DefaultText = "";
            this.IDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDText.DisabledState.Parent = this.IDText;
            this.IDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDText.FocusedState.Parent = this.IDText;
            this.IDText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDText.HoverState.Parent = this.IDText;
            this.IDText.Location = new System.Drawing.Point(94, 81);
            this.IDText.Name = "IDText";
            this.IDText.PasswordChar = '\0';
            this.IDText.PlaceholderText = "";
            this.IDText.SelectedText = "";
            this.IDText.ShadowDecoration.Parent = this.IDText;
            this.IDText.Size = new System.Drawing.Size(222, 23);
            this.IDText.TabIndex = 1;
            this.IDText.TextChanged += new System.EventHandler(this.IDText_TextChanged);
            // 
            // PWText
            // 
            this.PWText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PWText.DefaultText = "";
            this.PWText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PWText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PWText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PWText.DisabledState.Parent = this.PWText;
            this.PWText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PWText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PWText.FocusedState.Parent = this.PWText;
            this.PWText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PWText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PWText.HoverState.Parent = this.PWText;
            this.PWText.Location = new System.Drawing.Point(94, 133);
            this.PWText.Name = "PWText";
            this.PWText.PasswordChar = '*';
            this.PWText.PlaceholderText = "";
            this.PWText.SelectedText = "";
            this.PWText.ShadowDecoration.Parent = this.PWText;
            this.PWText.Size = new System.Drawing.Size(222, 23);
            this.PWText.TabIndex = 2;
            // 
            // NameText
            // 
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.DefaultText = "";
            this.NameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.DisabledState.Parent = this.NameText;
            this.NameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.FocusedState.Parent = this.NameText;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.HoverState.Parent = this.NameText;
            this.NameText.Location = new System.Drawing.Point(94, 186);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.PlaceholderText = "";
            this.NameText.SelectedText = "";
            this.NameText.ShadowDecoration.Parent = this.NameText;
            this.NameText.Size = new System.Drawing.Size(222, 23);
            this.NameText.TabIndex = 3;
            // 
            // guna2Button_OK
            // 
            this.guna2Button_OK.CheckedState.Parent = this.guna2Button_OK;
            this.guna2Button_OK.CustomImages.Parent = this.guna2Button_OK;
            this.guna2Button_OK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_OK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_OK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_OK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_OK.DisabledState.Parent = this.guna2Button_OK;
            this.guna2Button_OK.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.guna2Button_OK.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_OK.ForeColor = System.Drawing.Color.White;
            this.guna2Button_OK.HoverState.Parent = this.guna2Button_OK;
            this.guna2Button_OK.Location = new System.Drawing.Point(94, 268);
            this.guna2Button_OK.Name = "guna2Button_OK";
            this.guna2Button_OK.ShadowDecoration.Parent = this.guna2Button_OK;
            this.guna2Button_OK.Size = new System.Drawing.Size(222, 40);
            this.guna2Button_OK.TabIndex = 5;
            this.guna2Button_OK.Text = "가입하기";
            this.guna2Button_OK.Click += new System.EventHandler(this.guna2Button_OK_Click);
            // 
            // guna2Button_IDcheck
            // 
            this.guna2Button_IDcheck.CheckedState.Parent = this.guna2Button_IDcheck;
            this.guna2Button_IDcheck.CustomImages.Parent = this.guna2Button_IDcheck;
            this.guna2Button_IDcheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_IDcheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_IDcheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_IDcheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_IDcheck.DisabledState.Parent = this.guna2Button_IDcheck;
            this.guna2Button_IDcheck.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.guna2Button_IDcheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button_IDcheck.ForeColor = System.Drawing.Color.White;
            this.guna2Button_IDcheck.HoverState.Parent = this.guna2Button_IDcheck;
            this.guna2Button_IDcheck.Location = new System.Drawing.Point(226, 57);
            this.guna2Button_IDcheck.Name = "guna2Button_IDcheck";
            this.guna2Button_IDcheck.ShadowDecoration.Parent = this.guna2Button_IDcheck;
            this.guna2Button_IDcheck.Size = new System.Drawing.Size(90, 21);
            this.guna2Button_IDcheck.TabIndex = 0;
            this.guna2Button_IDcheck.Text = "ID중복확인";
            this.guna2Button_IDcheck.Click += new System.EventHandler(this.guna2Button_IDcheck_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.Location = new System.Drawing.Point(92, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "PH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(91, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label4.Location = new System.Drawing.Point(92, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label2.Location = new System.Drawing.Point(88, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "청약 분양 정보 조회";
            // 
            // guna2ImageButton_SignUp_Exit
            // 
            this.guna2ImageButton_SignUp_Exit.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton_SignUp_Exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton_SignUp_Exit.CheckedState.Parent = this.guna2ImageButton_SignUp_Exit;
            this.guna2ImageButton_SignUp_Exit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton_SignUp_Exit.HoverState.Parent = this.guna2ImageButton_SignUp_Exit;
            this.guna2ImageButton_SignUp_Exit.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton_SignUp_Exit.Image")));
            this.guna2ImageButton_SignUp_Exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton_SignUp_Exit.ImageRotate = 0F;
            this.guna2ImageButton_SignUp_Exit.Location = new System.Drawing.Point(356, 12);
            this.guna2ImageButton_SignUp_Exit.Name = "guna2ImageButton_SignUp_Exit";
            this.guna2ImageButton_SignUp_Exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton_SignUp_Exit.PressedState.Parent = this.guna2ImageButton_SignUp_Exit;
            this.guna2ImageButton_SignUp_Exit.ShadowDecoration.Parent = this.guna2ImageButton_SignUp_Exit;
            this.guna2ImageButton_SignUp_Exit.Size = new System.Drawing.Size(40, 41);
            this.guna2ImageButton_SignUp_Exit.TabIndex = 0;
            this.guna2ImageButton_SignUp_Exit.Click += new System.EventHandler(this.guna2ImageButton_SignUp_Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.label1.Location = new System.Drawing.Point(88, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "청약 분양 정보 조회";
            // 
            // guna2Button_SignUp
            // 
            this.guna2Button_SignUp.CheckedState.Parent = this.guna2Button_SignUp;
            this.guna2Button_SignUp.CustomImages.Parent = this.guna2Button_SignUp;
            this.guna2Button_SignUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_SignUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_SignUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_SignUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_SignUp.DisabledState.Parent = this.guna2Button_SignUp;
            this.guna2Button_SignUp.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.guna2Button_SignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.guna2Button_SignUp.ForeColor = System.Drawing.Color.White;
            this.guna2Button_SignUp.HoverState.Parent = this.guna2Button_SignUp;
            this.guna2Button_SignUp.Location = new System.Drawing.Point(235, 217);
            this.guna2Button_SignUp.Name = "guna2Button_SignUp";
            this.guna2Button_SignUp.ShadowDecoration.Parent = this.guna2Button_SignUp;
            this.guna2Button_SignUp.Size = new System.Drawing.Size(86, 26);
            this.guna2Button_SignUp.TabIndex = 0;
            this.guna2Button_SignUp.Text = "회원가입";
            this.guna2Button_SignUp.Click += new System.EventHandler(this.guna2Button_SignUp_Click);
            // 
            // guna2ImageButton_Login_Exit
            // 
            this.guna2ImageButton_Login_Exit.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton_Login_Exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton_Login_Exit.CheckedState.Parent = this.guna2ImageButton_Login_Exit;
            this.guna2ImageButton_Login_Exit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton_Login_Exit.HoverState.Parent = this.guna2ImageButton_Login_Exit;
            this.guna2ImageButton_Login_Exit.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton_Login_Exit.Image")));
            this.guna2ImageButton_Login_Exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton_Login_Exit.ImageRotate = 0F;
            this.guna2ImageButton_Login_Exit.Location = new System.Drawing.Point(356, 12);
            this.guna2ImageButton_Login_Exit.Name = "guna2ImageButton_Login_Exit";
            this.guna2ImageButton_Login_Exit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton_Login_Exit.PressedState.Parent = this.guna2ImageButton_Login_Exit;
            this.guna2ImageButton_Login_Exit.ShadowDecoration.Parent = this.guna2ImageButton_Login_Exit;
            this.guna2ImageButton_Login_Exit.Size = new System.Drawing.Size(40, 41);
            this.guna2ImageButton_Login_Exit.TabIndex = 0;
            this.guna2ImageButton_Login_Exit.Click += new System.EventHandler(this.guna2ImageButton_Login_Exit_Click);
            // 
            // guna2Button_Login
            // 
            this.guna2Button_Login.CheckedState.Parent = this.guna2Button_Login;
            this.guna2Button_Login.CustomImages.Parent = this.guna2Button_Login;
            this.guna2Button_Login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button_Login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button_Login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button_Login.DisabledState.Parent = this.guna2Button_Login;
            this.guna2Button_Login.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.guna2Button_Login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button_Login.ForeColor = System.Drawing.Color.White;
            this.guna2Button_Login.HoverState.Parent = this.guna2Button_Login;
            this.guna2Button_Login.Location = new System.Drawing.Point(75, 217);
            this.guna2Button_Login.Name = "guna2Button_Login";
            this.guna2Button_Login.ShadowDecoration.Parent = this.guna2Button_Login;
            this.guna2Button_Login.Size = new System.Drawing.Size(154, 26);
            this.guna2Button_Login.TabIndex = 0;
            this.guna2Button_Login.Text = "로그인";
            this.guna2Button_Login.Click += new System.EventHandler(this.guna2Button_Login_Click);
            // 
            // guna2TextBox_PW
            // 
            this.guna2TextBox_PW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_PW.DefaultText = "";
            this.guna2TextBox_PW.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_PW.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_PW.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_PW.DisabledState.Parent = this.guna2TextBox_PW;
            this.guna2TextBox_PW.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_PW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_PW.FocusedState.Parent = this.guna2TextBox_PW;
            this.guna2TextBox_PW.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_PW.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_PW.HoverState.Parent = this.guna2TextBox_PW;
            this.guna2TextBox_PW.Location = new System.Drawing.Point(132, 148);
            this.guna2TextBox_PW.Name = "guna2TextBox_PW";
            this.guna2TextBox_PW.PasswordChar = '*';
            this.guna2TextBox_PW.PlaceholderText = "";
            this.guna2TextBox_PW.SelectedText = "";
            this.guna2TextBox_PW.ShadowDecoration.Parent = this.guna2TextBox_PW;
            this.guna2TextBox_PW.Size = new System.Drawing.Size(189, 39);
            this.guna2TextBox_PW.TabIndex = 2;
            this.guna2TextBox_PW.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.guna2TextBox_PW_KeyPress);
            // 
            // guna2TextBox_ID
            // 
            this.guna2TextBox_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox_ID.DefaultText = "";
            this.guna2TextBox_ID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox_ID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox_ID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_ID.DisabledState.Parent = this.guna2TextBox_ID;
            this.guna2TextBox_ID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox_ID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_ID.FocusedState.Parent = this.guna2TextBox_ID;
            this.guna2TextBox_ID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox_ID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox_ID.HoverState.Parent = this.guna2TextBox_ID;
            this.guna2TextBox_ID.Location = new System.Drawing.Point(132, 90);
            this.guna2TextBox_ID.Name = "guna2TextBox_ID";
            this.guna2TextBox_ID.PasswordChar = '\0';
            this.guna2TextBox_ID.PlaceholderText = "";
            this.guna2TextBox_ID.SelectedText = "";
            this.guna2TextBox_ID.ShadowDecoration.Parent = this.guna2TextBox_ID;
            this.guna2TextBox_ID.Size = new System.Drawing.Size(189, 39);
            this.guna2TextBox_ID.TabIndex = 1;
            // 
            // guna2HtmlLabel_Login_PW
            // 
            this.guna2HtmlLabel_Login_PW.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel_Login_PW.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel_Login_PW.Location = new System.Drawing.Point(75, 148);
            this.guna2HtmlLabel_Login_PW.Name = "guna2HtmlLabel_Login_PW";
            this.guna2HtmlLabel_Login_PW.Size = new System.Drawing.Size(42, 39);
            this.guna2HtmlLabel_Login_PW.TabIndex = 0;
            this.guna2HtmlLabel_Login_PW.Text = "PW";
            // 
            // guna2HtmlLabel_Login_ID
            // 
            this.guna2HtmlLabel_Login_ID.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel_Login_ID.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel_Login_ID.Location = new System.Drawing.Point(75, 90);
            this.guna2HtmlLabel_Login_ID.Name = "guna2HtmlLabel_Login_ID";
            this.guna2HtmlLabel_Login_ID.Size = new System.Drawing.Size(34, 39);
            this.guna2HtmlLabel_Login_ID.TabIndex = 0;
            this.guna2HtmlLabel_Login_ID.Text = "I D";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 56;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 56;
            this.guna2Elipse2.TargetControl = this.panel_Login;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 56;
            this.guna2Elipse3.TargetControl = this.panel_SignUp;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(421, 321);
            this.Controls.Add(this.panel_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_SignUp.ResumeLayout(false);
            this.panel_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Login;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button_Login;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_PW;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox_ID;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton_Login_Exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button_SignUp;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel_SignUp;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton_SignUp_Exit;
        private Guna.UI2.WinForms.Guna2Button guna2Button_OK;
        private Guna.UI2.WinForms.Guna2Button guna2Button_IDcheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel_Login_PW;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel_Login_ID;
        private Guna.UI2.WinForms.Guna2TextBox PhoneText;
        private Guna.UI2.WinForms.Guna2TextBox IDText;
        private Guna.UI2.WinForms.Guna2TextBox PWText;
        private Guna.UI2.WinForms.Guna2TextBox NameText;
    }
}