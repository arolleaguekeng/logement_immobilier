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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelEmail = new System.Windows.Forms.Panel();
            this.lineName = new System.Windows.Forms.PictureBox();
            this.btnNext = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bnt_back = new Guna.UI2.WinForms.Guna2GradientButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tbPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnValidate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelLangguage = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnOk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.combLanguage = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).BeginInit();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelLangguage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.lineName);
            this.panelEmail.Controls.Add(this.btnNext);
            this.panelEmail.Controls.Add(this.tbEmail);
            resources.ApplyResources(this.panelEmail, "panelEmail");
            this.panelEmail.Name = "panelEmail";
            // 
            // lineName
            // 
            this.lineName.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lineName, "lineName");
            this.lineName.Name = "lineName";
            this.lineName.TabStop = false;
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
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNext.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnNext.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Name = "btnNext";
            this.btnNext.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNext.ShadowDecoration.Depth = 5;
            this.btnNext.ShadowDecoration.Parent = this.btnNext;
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
            resources.ApplyResources(this.tbEmail, "tbEmail");
            this.tbEmail.ForeColor = System.Drawing.Color.Black;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbEmail.HoverState.Parent = this.tbEmail;
            this.tbEmail.IconLeft = global::LogementImobilier.Winform.Properties.Resources.administrator_male_26px;
            this.tbEmail.IconLeftSize = new System.Drawing.Size(30, 30);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Enter your email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.ShadowDecoration.Parent = this.tbEmail;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.pictureBox1);
            this.panelPassword.Controls.Add(this.bnt_back);
            this.panelPassword.Controls.Add(this.linkLabel1);
            this.panelPassword.Controls.Add(this.tbPassword);
            this.panelPassword.Controls.Add(this.btnValidate);
            resources.ApplyResources(this.panelPassword, "panelPassword");
            this.panelPassword.Name = "panelPassword";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
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
            resources.ApplyResources(this.bnt_back, "bnt_back");
            this.bnt_back.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_back.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.bnt_back.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.bnt_back.HoverState.ForeColor = System.Drawing.Color.White;
            this.bnt_back.HoverState.Image = global::LogementImobilier.Winform.Properties.Resources.back_32px;
            this.bnt_back.HoverState.Parent = this.bnt_back;
            this.bnt_back.Image = global::LogementImobilier.Winform.Properties.Resources.back_blue_32px;
            this.bnt_back.Name = "bnt_back";
            this.bnt_back.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bnt_back.ShadowDecoration.Depth = 5;
            this.bnt_back.ShadowDecoration.Parent = this.bnt_back;
            this.bnt_back.Click += new System.EventHandler(this.bnt_back_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
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
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbPassword.HoverState.Parent = this.tbPassword;
            this.tbPassword.IconLeft = global::LogementImobilier.Winform.Properties.Resources.password_26px;
            this.tbPassword.IconRightSize = new System.Drawing.Size(40, 40);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '\0';
            this.tbPassword.PlaceholderText = "Enter your password";
            this.tbPassword.SelectedText = "";
            this.tbPassword.ShadowDecoration.Parent = this.tbPassword;
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
            resources.ApplyResources(this.btnValidate, "btnValidate");
            this.btnValidate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnValidate.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnValidate.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnValidate.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnValidate.HoverState.Parent = this.btnValidate;
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnValidate.ShadowDecoration.Depth = 5;
            this.btnValidate.ShadowDecoration.Parent = this.btnValidate;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // guna2ShadowPanel1
            // 
            resources.ApplyResources(this.guna2ShadowPanel1, "guna2ShadowPanel1");
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.panel2);
            this.guna2ShadowPanel1.Controls.Add(this.panelEmail);
            this.guna2ShadowPanel1.Controls.Add(this.panelPassword);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.label2);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
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
            resources.ApplyResources(this.guna2Button1, "guna2Button1");
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Image = global::LogementImobilier.Winform.Properties.Resources.wallpaper_meuble1;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panelLangguage
            // 
            resources.ApplyResources(this.panelLangguage, "panelLangguage");
            this.panelLangguage.BackColor = System.Drawing.Color.Transparent;
            this.panelLangguage.Controls.Add(this.panel3);
            this.panelLangguage.Controls.Add(this.panel5);
            this.panelLangguage.FillColor = System.Drawing.Color.White;
            this.panelLangguage.Name = "panelLangguage";
            this.panelLangguage.ShadowColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel3.Controls.Add(this.label3);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.combLanguage);
            this.panel5.Controls.Add(this.btnOk);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // btnOk
            // 
            this.btnOk.Animated = true;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOk.BorderRadius = 15;
            this.btnOk.BorderThickness = 2;
            this.btnOk.CheckedState.Parent = this.btnOk;
            this.btnOk.CustomImages.Parent = this.btnOk;
            this.btnOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOk.DisabledState.Parent = this.btnOk;
            this.btnOk.FillColor = System.Drawing.Color.Transparent;
            this.btnOk.FillColor2 = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnOk, "btnOk");
            this.btnOk.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOk.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnOk.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnOk.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnOk.HoverState.Parent = this.btnOk;
            this.btnOk.Name = "btnOk";
            this.btnOk.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOk.ShadowDecoration.Depth = 5;
            this.btnOk.ShadowDecoration.Parent = this.btnOk;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // combLanguage
            // 
            this.combLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.combLanguage, "combLanguage");
            this.combLanguage.FormattingEnabled = true;
            this.combLanguage.Name = "combLanguage";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelLangguage);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelEmail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelLangguage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private Guna.UI2.WinForms.Guna2ShadowPanel panelLangguage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2GradientButton btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combLanguage;
    }
}