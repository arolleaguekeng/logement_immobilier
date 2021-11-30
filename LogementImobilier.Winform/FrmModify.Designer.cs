
namespace LogementImobilier.Winform
{
    partial class FrmModify
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
            this.btnmodify = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btndelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.listUser = new System.Windows.Forms.ListView();
            this.Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbfullname = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.lineId = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmodify
            // 
            this.btnmodify.Animated = true;
            this.btnmodify.BackColor = System.Drawing.Color.Transparent;
            this.btnmodify.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmodify.BorderRadius = 15;
            this.btnmodify.BorderThickness = 2;
            this.btnmodify.CheckedState.Parent = this.btnmodify;
            this.btnmodify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodify.CustomImages.Parent = this.btnmodify;
            this.btnmodify.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmodify.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmodify.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmodify.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmodify.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmodify.DisabledState.Parent = this.btnmodify;
            this.btnmodify.FillColor = System.Drawing.Color.Transparent;
            this.btnmodify.FillColor2 = System.Drawing.Color.Transparent;
            this.btnmodify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnmodify.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnmodify.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnmodify.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnmodify.HoverState.Parent = this.btnmodify;
            this.btnmodify.Location = new System.Drawing.Point(55, 321);
            this.btnmodify.Margin = new System.Windows.Forms.Padding(2);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnmodify.ShadowDecoration.Depth = 5;
            this.btnmodify.ShadowDecoration.Parent = this.btnmodify;
            this.btnmodify.Size = new System.Drawing.Size(98, 33);
            this.btnmodify.TabIndex = 76;
            this.btnmodify.Text = "Modify";
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btndelete
            // 
            this.btndelete.Animated = true;
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.BorderRadius = 15;
            this.btndelete.BorderThickness = 2;
            this.btndelete.CheckedState.Parent = this.btndelete;
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.CustomImages.Parent = this.btndelete;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.DisabledState.Parent = this.btndelete;
            this.btndelete.FillColor = System.Drawing.Color.Transparent;
            this.btndelete.FillColor2 = System.Drawing.Color.Transparent;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btndelete.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btndelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btndelete.HoverState.Parent = this.btndelete;
            this.btndelete.Location = new System.Drawing.Point(167, 321);
            this.btndelete.Margin = new System.Windows.Forms.Padding(2);
            this.btndelete.Name = "btndelete";
            this.btndelete.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btndelete.ShadowDecoration.Depth = 5;
            this.btndelete.ShadowDecoration.Parent = this.btndelete;
            this.btndelete.Size = new System.Drawing.Size(98, 33);
            this.btndelete.TabIndex = 77;
            this.btndelete.Text = "Delete";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // listUser
            // 
            this.listUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.Name,
            this.Password});
            this.listUser.FullRowSelect = true;
            this.listUser.HideSelection = false;
            this.listUser.Location = new System.Drawing.Point(299, 77);
            this.listUser.Name = "listUser";
            this.listUser.Size = new System.Drawing.Size(292, 277);
            this.listUser.TabIndex = 78;
            this.listUser.UseCompatibleStateImageBehavior = false;
            this.listUser.View = System.Windows.Forms.View.Details;
            this.listUser.SelectedIndexChanged += new System.EventHandler(this.listUser_SelectedIndexChanged);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 70;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Name.Width = 121;
            // 
            // Password
            // 
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Width = 93;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.tbfullname);
            this.flowLayoutPanel3.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(47, 152);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(218, 63);
            this.flowLayoutPanel3.TabIndex = 85;
            // 
            // tbfullname
            // 
            this.tbfullname.Animated = true;
            this.tbfullname.BackColor = System.Drawing.Color.Transparent;
            this.tbfullname.BorderColor = System.Drawing.Color.White;
            this.tbfullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbfullname.DefaultText = "";
            this.tbfullname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbfullname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbfullname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbfullname.DisabledState.Parent = this.tbfullname;
            this.tbfullname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbfullname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbfullname.FocusedState.Parent = this.tbfullname;
            this.tbfullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfullname.ForeColor = System.Drawing.Color.Black;
            this.tbfullname.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbfullname.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbfullname.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbfullname.HoverState.Parent = this.tbfullname;
            this.tbfullname.Location = new System.Drawing.Point(4, 4);
            this.tbfullname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbfullname.Name = "tbfullname";
            this.tbfullname.PasswordChar = '\0';
            this.tbfullname.PlaceholderText = "enter the Fullname";
            this.tbfullname.SelectedText = "";
            this.tbfullname.ShadowDecoration.Parent = this.tbfullname;
            this.tbfullname.Size = new System.Drawing.Size(212, 32);
            this.tbfullname.TabIndex = 53;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(2, 42);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(212, 2);
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.tbpassword);
            this.flowLayoutPanel2.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(47, 231);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(218, 63);
            this.flowLayoutPanel2.TabIndex = 84;
            // 
            // tbpassword
            // 
            this.tbpassword.Animated = true;
            this.tbpassword.BackColor = System.Drawing.Color.Transparent;
            this.tbpassword.BorderColor = System.Drawing.Color.White;
            this.tbpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpassword.DefaultText = "";
            this.tbpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpassword.DisabledState.Parent = this.tbpassword;
            this.tbpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpassword.FocusedState.Parent = this.tbpassword;
            this.tbpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbpassword.ForeColor = System.Drawing.Color.Black;
            this.tbpassword.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbpassword.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbpassword.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbpassword.HoverState.Parent = this.tbpassword;
            this.tbpassword.Location = new System.Drawing.Point(4, 4);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '\0';
            this.tbpassword.PlaceholderText = "Enter password";
            this.tbpassword.SelectedText = "";
            this.tbpassword.ShadowDecoration.Parent = this.tbpassword;
            this.tbpassword.Size = new System.Drawing.Size(212, 32);
            this.tbpassword.TabIndex = 53;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(2, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 2);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbId);
            this.flowLayoutPanel1.Controls.Add(this.lineId);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(47, 77);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 63);
            this.flowLayoutPanel1.TabIndex = 83;
            // 
            // tbId
            // 
            this.tbId.Animated = true;
            this.tbId.BackColor = System.Drawing.Color.Transparent;
            this.tbId.BorderColor = System.Drawing.Color.White;
            this.tbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbId.DefaultText = "";
            this.tbId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbId.DisabledState.Parent = this.tbId;
            this.tbId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbId.FocusedState.Parent = this.tbId;
            this.tbId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbId.ForeColor = System.Drawing.Color.Black;
            this.tbId.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbId.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbId.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbId.HoverState.Parent = this.tbId;
            this.tbId.Location = new System.Drawing.Point(4, 4);
            this.tbId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.PlaceholderText = "enter the Email";
            this.tbId.SelectedText = "";
            this.tbId.ShadowDecoration.Parent = this.tbId;
            this.tbId.Size = new System.Drawing.Size(212, 32);
            this.tbId.TabIndex = 53;
            // 
            // lineId
            // 
            this.lineId.BackColor = System.Drawing.Color.Black;
            this.lineId.Location = new System.Drawing.Point(2, 42);
            this.lineId.Margin = new System.Windows.Forms.Padding(2);
            this.lineId.Name = "lineId";
            this.lineId.Size = new System.Drawing.Size(212, 2);
            this.lineId.TabIndex = 70;
            this.lineId.TabStop = false;
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 420);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.listUser);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnmodify);
            //this.Name = "FrmModify";
            this.Text = "FrmModify";
            this.Load += new System.EventHandler(this.FrmModify_Load);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnmodify;
        private Guna.UI2.WinForms.Guna2GradientButton btndelete;
        private System.Windows.Forms.ListView listUser;
        private System.Windows.Forms.ColumnHeader Id;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Guna.UI2.WinForms.Guna2TextBox tbfullname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Guna.UI2.WinForms.Guna2TextBox tbpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox tbId;
        private System.Windows.Forms.PictureBox lineId;
    }
}