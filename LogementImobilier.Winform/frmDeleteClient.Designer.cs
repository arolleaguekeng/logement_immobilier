namespace LogementImobilier.Winform
{
    partial class frmDeleteClient
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
            this.Text_box_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.numéro = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(39, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delete Client";
            // 
            // Text_box_name
            // 
            this.Text_box_name.Animated = true;
            this.Text_box_name.BorderRadius = 8;
            this.Text_box_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text_box_name.DefaultText = "";
            this.Text_box_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Text_box_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Text_box_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_box_name.DisabledState.Parent = this.Text_box_name;
            this.Text_box_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Text_box_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Text_box_name.FocusedState.Parent = this.Text_box_name;
            this.Text_box_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_box_name.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.Text_box_name.HoverState.Parent = this.Text_box_name;
            this.Text_box_name.Location = new System.Drawing.Point(38, 124);
            this.Text_box_name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_box_name.Name = "Text_box_name";
            this.Text_box_name.PasswordChar = '\0';
            this.Text_box_name.PlaceholderText = "";
            this.Text_box_name.SelectedText = "";
            this.Text_box_name.ShadowDecoration.Parent = this.Text_box_name;
            this.Text_box_name.Size = new System.Drawing.Size(163, 41);
            this.Text_box_name.TabIndex = 11;
            this.Text_box_name.TextChanged += new System.EventHandler(this.Text_box_name_TextChanged);
            // 
            // numéro
            // 
            this.numéro.Animated = true;
            this.numéro.BorderRadius = 8;
            this.numéro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numéro.DefaultText = "";
            this.numéro.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numéro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numéro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numéro.DisabledState.Parent = this.numéro;
            this.numéro.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numéro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numéro.FocusedState.Parent = this.numéro;
            this.numéro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numéro.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.numéro.HoverState.Parent = this.numéro;
            this.numéro.Location = new System.Drawing.Point(137, 196);
            this.numéro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numéro.Name = "numéro";
            this.numéro.PasswordChar = '\0';
            this.numéro.PlaceholderText = "";
            this.numéro.SelectedText = "";
            this.numéro.ShadowDecoration.Parent = this.numéro;
            this.numéro.Size = new System.Drawing.Size(183, 41);
            this.numéro.TabIndex = 12;
            this.numéro.TextChanged += new System.EventHandler(this.numéro_TextChanged);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Animated = true;
            this.ButtonDelete.BackColor = System.Drawing.Color.Transparent;
            this.ButtonDelete.BorderRadius = 25;
            this.ButtonDelete.CheckedState.Parent = this.ButtonDelete;
            this.ButtonDelete.CustomImages.Parent = this.ButtonDelete;
            this.ButtonDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonDelete.DisabledState.Parent = this.ButtonDelete;
            this.ButtonDelete.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.HoverState.Parent = this.ButtonDelete;
            this.ButtonDelete.Location = new System.Drawing.Point(118, 272);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButtonDelete.ShadowDecoration.Depth = 5;
            this.ButtonDelete.ShadowDecoration.Parent = this.ButtonDelete;
            this.ButtonDelete.Size = new System.Drawing.Size(134, 56);
            this.ButtonDelete.TabIndex = 13;
            this.ButtonDelete.Text = "Delete";
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(276, 65);
            this.guna2ProgressIndicator1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.ProgressColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2ProgressIndicator1.ShadowDecoration.Parent = this.guna2ProgressIndicator1;
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(68, 73);
            this.guna2ProgressIndicator1.TabIndex = 19;
            // 
            // frmDeleteClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 371);
            this.Controls.Add(this.guna2ProgressIndicator1);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.numéro);
            this.Controls.Add(this.Text_box_name);
            this.Controls.Add(this.label1);
            this.Name = "frmDeleteClient";
            this.Text = "frmDeleteClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox Text_box_name;
        private Guna.UI2.WinForms.Guna2TextBox numéro;
        private Guna.UI2.WinForms.Guna2GradientButton ButtonDelete;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
    }
}