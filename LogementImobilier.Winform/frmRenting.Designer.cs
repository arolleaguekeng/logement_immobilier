namespace LogementImobilier.Winform
{
    partial class frmRenting
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.cbbLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.chbParking = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbTerasse = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudShowers = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nudRooms = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStars = new Guna.UI2.WinForms.Guna2RatingStar();
            this.nudExibition = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudKitchens = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelcontein = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSee = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lineName = new System.Windows.Forms.PictureBox();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchens)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.Controls.Add(this.guna2Button1);
            this.panelRight.Controls.Add(this.btnClose);
            this.panelRight.Controls.Add(this.cbbLocation);
            this.panelRight.Controls.Add(this.nudPrice);
            this.panelRight.Controls.Add(this.chbParking);
            this.panelRight.Controls.Add(this.chbTerasse);
            this.panelRight.Controls.Add(this.label10);
            this.panelRight.Controls.Add(this.nudShowers);
            this.panelRight.Controls.Add(this.nudRooms);
            this.panelRight.Controls.Add(this.label2);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.btnStars);
            this.panelRight.Controls.Add(this.nudExibition);
            this.panelRight.Controls.Add(this.label1);
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.nudKitchens);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(1198, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(155, 690);
            this.panelRight.TabIndex = 38;
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
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(120, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(34, 28);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_3);
            // 
            // cbbLocation
            // 
            this.cbbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocation.BorderColor = System.Drawing.Color.Purple;
            this.cbbLocation.BorderRadius = 8;
            this.cbbLocation.BorderThickness = 2;
            this.cbbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocation.FocusedColor = System.Drawing.Color.Purple;
            this.cbbLocation.FocusedState.BorderColor = System.Drawing.Color.Purple;
            this.cbbLocation.FocusedState.Parent = this.cbbLocation;
            this.cbbLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbLocation.ForeColor = System.Drawing.Color.Black;
            this.cbbLocation.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.cbbLocation.HoverState.Parent = this.cbbLocation;
            this.cbbLocation.ItemHeight = 30;
            this.cbbLocation.Items.AddRange(new object[] {
            "Bafoussam",
            "Douala",
            "Kribi",
            "Limbé",
            "Maroua",
            "Garoua",
            "Nkongsamba",
            "Dschang"});
            this.cbbLocation.ItemsAppearance.Parent = this.cbbLocation;
            this.cbbLocation.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Purple;
            this.cbbLocation.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbbLocation.Location = new System.Drawing.Point(6, 43);
            this.cbbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLocation.Name = "cbbLocation";
            this.cbbLocation.ShadowDecoration.Parent = this.cbbLocation;
            this.cbbLocation.Size = new System.Drawing.Size(138, 36);
            this.cbbLocation.TabIndex = 62;
            this.cbbLocation.SelectedIndexChanged += new System.EventHandler(this.cbbLocation_SelectedIndexChanged);
            // 
            // nudPrice
            // 
            this.nudPrice.BackColor = System.Drawing.Color.Transparent;
            this.nudPrice.BorderRadius = 8;
            this.nudPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudPrice.DisabledState.Parent = this.nudPrice;
            this.nudPrice.FocusedState.Parent = this.nudPrice;
            this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrice.ForeColor = System.Drawing.Color.Black;
            this.nudPrice.Location = new System.Drawing.Point(7, 468);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(5);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ShadowDecoration.Parent = this.nudPrice;
            this.nudPrice.Size = new System.Drawing.Size(141, 26);
            this.nudPrice.TabIndex = 59;
            this.nudPrice.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudPrice.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudPrice.ValueChanged += new System.EventHandler(this.nudPrice_ValueChanged);
            // 
            // chbParking
            // 
            this.chbParking.AutoSize = true;
            this.chbParking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chbParking.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chbParking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbParking.CheckedState.BorderRadius = 0;
            this.chbParking.CheckedState.BorderThickness = 0;
            this.chbParking.CheckedState.FillColor = System.Drawing.Color.Purple;
            this.chbParking.CheckMarkColor = System.Drawing.Color.Purple;
            this.chbParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParking.ForeColor = System.Drawing.Color.White;
            this.chbParking.Location = new System.Drawing.Point(65, 116);
            this.chbParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbParking.Name = "chbParking";
            this.chbParking.Size = new System.Drawing.Size(87, 24);
            this.chbParking.TabIndex = 61;
            this.chbParking.Text = "Parking";
            this.chbParking.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbParking.UncheckedState.BorderRadius = 0;
            this.chbParking.UncheckedState.BorderThickness = 0;
            this.chbParking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbParking.UseVisualStyleBackColor = false;
            // 
            // chbTerasse
            // 
            this.chbTerasse.AutoSize = true;
            this.chbTerasse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chbTerasse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chbTerasse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTerasse.CheckedState.BorderRadius = 0;
            this.chbTerasse.CheckedState.BorderThickness = 0;
            this.chbTerasse.CheckedState.FillColor = System.Drawing.Color.Purple;
            this.chbTerasse.CheckMarkColor = System.Drawing.Color.Purple;
            this.chbTerasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTerasse.ForeColor = System.Drawing.Color.White;
            this.chbTerasse.Location = new System.Drawing.Point(65, 88);
            this.chbTerasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbTerasse.Name = "chbTerasse";
            this.chbTerasse.Size = new System.Drawing.Size(92, 24);
            this.chbTerasse.TabIndex = 60;
            this.chbTerasse.Text = "Terasse";
            this.chbTerasse.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTerasse.UncheckedState.BorderRadius = 0;
            this.chbTerasse.UncheckedState.BorderThickness = 0;
            this.chbTerasse.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTerasse.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(4, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Location";
            // 
            // nudShowers
            // 
            this.nudShowers.BackColor = System.Drawing.Color.Transparent;
            this.nudShowers.BorderRadius = 8;
            this.nudShowers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudShowers.DisabledState.Parent = this.nudShowers;
            this.nudShowers.FocusedState.Parent = this.nudShowers;
            this.nudShowers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudShowers.ForeColor = System.Drawing.Color.Black;
            this.nudShowers.Location = new System.Drawing.Point(65, 230);
            this.nudShowers.Margin = new System.Windows.Forms.Padding(5);
            this.nudShowers.Name = "nudShowers";
            this.nudShowers.ShadowDecoration.Parent = this.nudShowers;
            this.nudShowers.Size = new System.Drawing.Size(75, 28);
            this.nudShowers.TabIndex = 21;
            this.nudShowers.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudShowers.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudShowers.ValueChanged += new System.EventHandler(this.nudShowers_ValueChanged);
            // 
            // nudRooms
            // 
            this.nudRooms.BackColor = System.Drawing.Color.Transparent;
            this.nudRooms.BorderRadius = 8;
            this.nudRooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRooms.DisabledState.Parent = this.nudRooms;
            this.nudRooms.FocusedState.Parent = this.nudRooms;
            this.nudRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRooms.ForeColor = System.Drawing.Color.Black;
            this.nudRooms.Location = new System.Drawing.Point(65, 352);
            this.nudRooms.Margin = new System.Windows.Forms.Padding(5);
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.ShadowDecoration.Parent = this.nudRooms;
            this.nudRooms.Size = new System.Drawing.Size(75, 28);
            this.nudRooms.TabIndex = 16;
            this.nudRooms.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudRooms.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudRooms.ValueChanged += new System.EventHandler(this.nudRooms_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(61, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Roms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kitchens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Showers";
            // 
            // btnStars
            // 
            this.btnStars.BorderColor = System.Drawing.Color.White;
            this.btnStars.Location = new System.Drawing.Point(26, 399);
            this.btnStars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStars.Name = "btnStars";
            this.btnStars.RatingColor = System.Drawing.Color.Gold;
            this.btnStars.Size = new System.Drawing.Size(124, 33);
            this.btnStars.TabIndex = 18;
            this.btnStars.ValueChanged += new System.EventHandler(this.btnStars_ValueChanged);
            // 
            // nudExibition
            // 
            this.nudExibition.BackColor = System.Drawing.Color.Transparent;
            this.nudExibition.BorderRadius = 8;
            this.nudExibition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudExibition.DisabledState.Parent = this.nudExibition;
            this.nudExibition.FocusedState.Parent = this.nudExibition;
            this.nudExibition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExibition.ForeColor = System.Drawing.Color.Black;
            this.nudExibition.Location = new System.Drawing.Point(65, 292);
            this.nudExibition.Margin = new System.Windows.Forms.Padding(5);
            this.nudExibition.Name = "nudExibition";
            this.nudExibition.ShadowDecoration.Parent = this.nudExibition;
            this.nudExibition.Size = new System.Drawing.Size(75, 28);
            this.nudExibition.TabIndex = 29;
            this.nudExibition.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudExibition.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudExibition.ValueChanged += new System.EventHandler(this.nudExibition_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(61, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Exhibition";
            // 
            // nudKitchens
            // 
            this.nudKitchens.BackColor = System.Drawing.Color.Transparent;
            this.nudKitchens.BorderRadius = 8;
            this.nudKitchens.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudKitchens.DisabledState.Parent = this.nudKitchens;
            this.nudKitchens.FocusedState.Parent = this.nudKitchens;
            this.nudKitchens.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKitchens.ForeColor = System.Drawing.Color.Black;
            this.nudKitchens.Location = new System.Drawing.Point(65, 171);
            this.nudKitchens.Margin = new System.Windows.Forms.Padding(5);
            this.nudKitchens.Name = "nudKitchens";
            this.nudKitchens.ShadowDecoration.Parent = this.nudKitchens;
            this.nudKitchens.Size = new System.Drawing.Size(75, 28);
            this.nudKitchens.TabIndex = 21;
            this.nudKitchens.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudKitchens.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudKitchens.ValueChanged += new System.EventHandler(this.nudKitchens_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lineName);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2ComboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 59);
            this.panel1.TabIndex = 66;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.White;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.Purple;
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.Purple;
            this.guna2ComboBox1.FocusedState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ComboBox1.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.guna2ComboBox1.HoverState.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Bafoussam",
            "Douala",
            "Kribi",
            "Limbé",
            "Maroua",
            "Garoua",
            "Nkongsamba",
            "Dschang"});
            this.guna2ComboBox1.ItemsAppearance.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Purple;
            this.guna2ComboBox1.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.guna2ComboBox1.Location = new System.Drawing.Point(358, 15);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.ShadowDecoration.Parent = this.guna2ComboBox1;
            this.guna2ComboBox1.Size = new System.Drawing.Size(138, 36);
            this.guna2ComboBox1.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(216, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(21, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Housing found";
            // 
            // panelcontein
            // 
            this.panelcontein.AutoScroll = true;
            this.panelcontein.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelcontein.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelcontein.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontein.Location = new System.Drawing.Point(0, 59);
            this.panelcontein.Name = "panelcontein";
            this.panelcontein.Size = new System.Drawing.Size(1168, 631);
            this.panelcontein.TabIndex = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogementImobilier.Winform.Properties.Resources.filter_32px;
            this.pictureBox1.Location = new System.Drawing.Point(317, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // btnSee
            // 
            this.btnSee.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSee.CheckedState.Parent = this.btnSee;
            this.btnSee.CustomImages.Parent = this.btnSee;
            this.btnSee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSee.DisabledState.Parent = this.btnSee;
            this.btnSee.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSee.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSee.ForeColor = System.Drawing.Color.White;
            this.btnSee.HoverState.Parent = this.btnSee;
            this.btnSee.Image = global::LogementImobilier.Winform.Properties.Resources.back_32px;
            this.btnSee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSee.Location = new System.Drawing.Point(1168, 0);
            this.btnSee.Name = "btnSee";
            this.btnSee.ShadowDecoration.Parent = this.btnSee;
            this.btnSee.Size = new System.Drawing.Size(30, 690);
            this.btnSee.TabIndex = 64;
            this.btnSee.Visible = false;
            this.btnSee.Click += new System.EventHandler(this.btnSee_Click);
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
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::LogementImobilier.Winform.Properties.Resources.forward_32px;
            this.guna2Button1.ImageSize = new System.Drawing.Size(20, 35);
            this.guna2Button1.Location = new System.Drawing.Point(-1, 244);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(34, 43);
            this.guna2Button1.TabIndex = 64;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // lineName
            // 
            this.lineName.BackColor = System.Drawing.Color.Black;
            this.lineName.Location = new System.Drawing.Point(358, 43);
            this.lineName.Name = "lineName";
            this.lineName.Size = new System.Drawing.Size(138, 2);
            this.lineName.TabIndex = 72;
            this.lineName.TabStop = false;
            // 
            // frmRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 690);
            this.Controls.Add(this.panelcontein);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSee);
            this.Controls.Add(this.panelRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRenting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenting";
            this.Load += new System.EventHandler(this.frmRenting_Load);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchens)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRight;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocation;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPrice;
        private Guna.UI2.WinForms.Guna2CheckBox chbParking;
        private Guna.UI2.WinForms.Guna2CheckBox chbTerasse;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudShowers;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RatingStar btnStars;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudExibition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudKitchens;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnSee;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel panelcontein;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lineName;
    }
}