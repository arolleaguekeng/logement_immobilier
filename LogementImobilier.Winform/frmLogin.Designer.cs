namespace LogementImobilier.Winform
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
            this.panelEmail = new System.Windows.Forms.Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnValidate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineName = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnt_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelEmail.SuspendLayout();
            this.panelPassword.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.lineName);
            this.panelEmail.Controls.Add(this.btnNext);
            this.panelEmail.Controls.Add(this.tbEmail);
            this.panelEmail.Location = new System.Drawing.Point(87, 145);
            this.panelEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(376, 292);
            this.panelEmail.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.Animated = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.BorderRadius = 15;
            this.btnNext.BorderThickness = 2;
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.CustomImages.Parent = this.btnNext;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.DisabledState.Parent = this.btnNext;
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.FillColor2 = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNext.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Location = new System.Drawing.Point(103, 135);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.ShadowDecoration.Depth = 5;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(179, 49);
            this.btnNext.TabIndex = 12;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Animated = true;
            this.tbEmail.BackColor = System.Drawing.Color.Red;
            this.tbEmail.BorderColor = System.Drawing.Color.White;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.Parent = this.tbEmail;
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.FocusedState.Parent = this.tbEmail;
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.Location = new System.Drawing.Point(24, 31);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Enter your email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            this.tbEmail.Size = new System.Drawing.Size(336, 50);
            this.tbEmail.TabIndex = 11;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.pictureBox1);
            this.panelPassword.Controls.Add(this.bnt_back);
            this.panelPassword.Controls.Add(this.linkLabel1);
            this.panelPassword.Controls.Add(this.tbPassword);
            this.panelPassword.Controls.Add(this.btnValidate);
            this.panelPassword.Location = new System.Drawing.Point(87, 145);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(376, 292);
            this.panelPassword.TabIndex = 13;
            // 
            // tbPassword
            // 
            this.tbPassword.Animated = true;
            this.tbPassword.BorderColor = System.Drawing.Color.White;
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.DefaultText = "";
            this.tbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.DisabledState.Parent = this.tbPassword;
            this.tbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPassword.FocusedState.Parent = this.tbPassword;
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.Location = new System.Drawing.Point(20, 31);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "Enter your password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
            this.tbPassword.Size = new System.Drawing.Size(336, 50);
            this.tbPassword.TabIndex = 13;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btnValidate
            // 
            this.btnValidate.Animated = true;
            this.btnValidate.BackColor = System.Drawing.Color.Transparent;
            this.btnValidate.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnValidate.BorderRadius = 15;
            this.btnValidate.BorderThickness = 2;
            this.btnValidate.CheckedState.Parent = this.btnValidate;
            this.btnValidate.CustomImages.Parent = this.btnValidate;
            this.btnValidate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnValidate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnValidate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValidate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnValidate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnValidate.DisabledState.Parent = this.btnValidate;
            this.btnValidate.FillColor = System.Drawing.Color.Transparent;
            this.btnValidate.FillColor2 = System.Drawing.Color.Transparent;
            this.btnValidate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnValidate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnValidate.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnValidate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnValidate.HoverState.Parent = this.btnValidate;
            this.btnValidate.Location = new System.Drawing.Point(99, 137);
            this.btnValidate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnValidate.ShadowDecoration.Depth = 5;
            this.btnValidate.ShadowDecoration.Parent = this.btnValidate;
            this.btnValidate.Size = new System.Drawing.Size(179, 49);
            this.btnValidate.TabIndex = 12;
            this.btnValidate.Text = "Validate";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1233, 42);
            this.panel1.TabIndex = 14;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(1183, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(50, 42);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(21, 100);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 17);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.panel2);
            this.guna2ShadowPanel1.Controls.Add(this.panelEmail);
            this.guna2ShadowPanel1.Controls.Add(this.panelPassword);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(359, 75);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(548, 459);
            this.guna2ShadowPanel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 52);
            this.panel2.TabIndex = 15;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(498, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(50, 52);
            this.guna2Button1.TabIndex = 64;
            this.guna2Button1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(218, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(558, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Housing";
            // 
            // lineName
            // 
            this.lineName.BackColor = System.Drawing.Color.Black;
            this.lineName.Location = new System.Drawing.Point(24, 78);
            this.lineName.Name = "lineName";
            this.lineName.Size = new System.Drawing.Size(336, 2);
            this.lineName.TabIndex = 72;
            this.lineName.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(20, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 2);
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // bnt_back
            // 
            this.bnt_back.Animated = true;
            this.bnt_back.BackColor = System.Drawing.Color.Transparent;
            this.bnt_back.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_back.BorderRadius = 15;
            this.bnt_back.BorderThickness = 2;
            this.bnt_back.CheckedState.Parent = this.bnt_back;
            this.bnt_back.CustomImages.Parent = this.bnt_back;
            this.bnt_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bnt_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bnt_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bnt_back.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bnt_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bnt_back.DisabledState.Parent = this.bnt_back;
            this.bnt_back.FillColor = System.Drawing.Color.Transparent;
            this.bnt_back.FillColor2 = System.Drawing.Color.Transparent;
            this.bnt_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_back.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_back.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bnt_back.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_back.HoverState.ForeColor = System.Drawing.Color.White;
            this.bnt_back.HoverState.Image = global::LogementImobilier.Winform.Properties.Resources.back_32px;
            this.bnt_back.HoverState.Parent = this.bnt_back;
            this.bnt_back.Image = global::LogementImobilier.Winform.Properties.Resources.back_blue_32px;
            this.bnt_back.Location = new System.Drawing.Point(3, 241);
            this.bnt_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bnt_back.Name = "bnt_back";
            this.bnt_back.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bnt_back.ShadowDecoration.Depth = 5;
            this.bnt_back.ShadowDecoration.Parent = this.bnt_back;
            this.bnt_back.Size = new System.Drawing.Size(56, 49);
            this.bnt_back.TabIndex = 15;
            this.bnt_back.Click += new System.EventHandler(this.bnt_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::LogementImobilier.Winform.Properties.Resources.wallpaper_meuble;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1233, 581);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1233, 581);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserConnect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelEmail.ResumeLayout(false);
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2GradientButton btnNext;
        private System.Windows.Forms.Panel panelPassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnValidate;
        private Guna.UI2.WinForms.Guna2TextBox tbPassword;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton bnt_back;
        private System.Windows.Forms.PictureBox lineName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}