namespace LogementImobilier.Winform
{
    partial class frmMessageBox
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
            this.lbMessages = new System.Windows.Forms.Label();
            this.btnClosePanel = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelMessage = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMessages
            // 
            this.lbMessages.AutoSize = true;
            this.lbMessages.BackColor = System.Drawing.Color.Transparent;
            this.lbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessages.ForeColor = System.Drawing.Color.White;
            this.lbMessages.Location = new System.Drawing.Point(61, 26);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(133, 32);
            this.lbMessages.TabIndex = 2;
            this.lbMessages.Text = "Welcome";
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.Animated = true;
            this.btnClosePanel.CheckedState.Parent = this.btnClosePanel;
            this.btnClosePanel.CustomImages.Parent = this.btnClosePanel;
            this.btnClosePanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClosePanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClosePanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClosePanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClosePanel.DisabledState.Parent = this.btnClosePanel;
            this.btnClosePanel.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClosePanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanel.ForeColor = System.Drawing.Color.White;
            this.btnClosePanel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClosePanel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClosePanel.HoverState.Parent = this.btnClosePanel;
            this.btnClosePanel.Location = new System.Drawing.Point(464, 3);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.ShadowDecoration.Parent = this.btnClosePanel;
            this.btnClosePanel.Size = new System.Drawing.Size(38, 31);
            this.btnClosePanel.TabIndex = 4;
            this.btnClosePanel.Text = "X";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::LogementImobilier.Winform.Properties.Resources.notification_26px;
            this.pictureBox4.Location = new System.Drawing.Point(3, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderColor = System.Drawing.Color.White;
            this.guna2GradientButton1.BorderRadius = 15;
            this.guna2GradientButton1.BorderThickness = 2;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.DisabledState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.guna2GradientButton1.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(195, 155);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2GradientButton1.ShadowDecoration.Depth = 5;
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(131, 41);
            this.guna2GradientButton1.TabIndex = 56;
            this.guna2GradientButton1.Text = "OK";
            // 
            // panelMessage
            // 
            this.panelMessage.Controls.Add(this.guna2GradientButton1);
            this.panelMessage.Controls.Add(this.pictureBox4);
            this.panelMessage.Controls.Add(this.btnClosePanel);
            this.panelMessage.Controls.Add(this.lbMessages);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMessage.FillColor = System.Drawing.Color.Purple;
            this.panelMessage.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.panelMessage.Location = new System.Drawing.Point(0, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.ShadowDecoration.Parent = this.panelMessage;
            this.panelMessage.Size = new System.Drawing.Size(502, 207);
            this.panelMessage.TabIndex = 74;
            this.panelMessage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMessage_Paint);
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 207);
            this.Controls.Add(this.panelMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageBox";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lbMessages;
        private Guna.UI2.WinForms.Guna2Button btnClosePanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMessage;
    }
}