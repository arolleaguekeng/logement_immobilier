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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.chbParking = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbTerasse = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2GradientButton();
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
            this.lvShowHousing = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchens)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbLocation);
            this.panel1.Controls.Add(this.nudPrice);
            this.panel1.Controls.Add(this.chbParking);
            this.panel1.Controls.Add(this.chbTerasse);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.nudShowers);
            this.panel1.Controls.Add(this.nudRooms);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnStars);
            this.panel1.Controls.Add(this.nudExibition);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudKitchens);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1103, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 690);
            this.panel1.TabIndex = 38;
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
            this.cbbLocation.Location = new System.Drawing.Point(15, 37);
            this.cbbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLocation.Name = "cbbLocation";
            this.cbbLocation.ShadowDecoration.Parent = this.cbbLocation;
            this.cbbLocation.Size = new System.Drawing.Size(211, 36);
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
            this.nudPrice.Location = new System.Drawing.Point(15, 368);
            this.nudPrice.Margin = new System.Windows.Forms.Padding(5);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.ShadowDecoration.Parent = this.nudPrice;
            this.nudPrice.Size = new System.Drawing.Size(211, 33);
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
            this.chbParking.Location = new System.Drawing.Point(141, 77);
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
            this.chbTerasse.Location = new System.Drawing.Point(16, 77);
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
            // btnSearch
            // 
            this.btnSearch.Animated = true;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 15;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.DisabledState.Parent = this.btnSearch;
            this.btnSearch.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Location = new System.Drawing.Point(100, 428);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearch.ShadowDecoration.Depth = 5;
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(126, 36);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Seach";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 12);
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
            this.nudShowers.Location = new System.Drawing.Point(21, 247);
            this.nudShowers.Margin = new System.Windows.Forms.Padding(5);
            this.nudShowers.Name = "nudShowers";
            this.nudShowers.ShadowDecoration.Parent = this.nudShowers;
            this.nudShowers.Size = new System.Drawing.Size(75, 32);
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
            this.nudRooms.Location = new System.Drawing.Point(151, 165);
            this.nudRooms.Margin = new System.Windows.Forms.Padding(5);
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.ShadowDecoration.Parent = this.nudRooms;
            this.nudRooms.Size = new System.Drawing.Size(75, 32);
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
            this.label2.Location = new System.Drawing.Point(147, 136);
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
            this.label3.Location = new System.Drawing.Point(12, 136);
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
            this.label4.Location = new System.Drawing.Point(17, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Showers";
            // 
            // btnStars
            // 
            this.btnStars.BorderColor = System.Drawing.Color.White;
            this.btnStars.Location = new System.Drawing.Point(61, 300);
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
            this.nudExibition.Location = new System.Drawing.Point(151, 247);
            this.nudExibition.Margin = new System.Windows.Forms.Padding(5);
            this.nudExibition.Name = "nudExibition";
            this.nudExibition.ShadowDecoration.Parent = this.nudExibition;
            this.nudExibition.Size = new System.Drawing.Size(75, 32);
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
            this.label1.Location = new System.Drawing.Point(25, 335);
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
            this.label8.Location = new System.Drawing.Point(147, 222);
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
            this.nudKitchens.Location = new System.Drawing.Point(16, 165);
            this.nudKitchens.Margin = new System.Windows.Forms.Padding(5);
            this.nudKitchens.Name = "nudKitchens";
            this.nudKitchens.ShadowDecoration.Parent = this.nudKitchens;
            this.nudKitchens.Size = new System.Drawing.Size(75, 32);
            this.nudKitchens.TabIndex = 21;
            this.nudKitchens.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudKitchens.UpDownButtonForeColor = System.Drawing.Color.White;
            this.nudKitchens.ValueChanged += new System.EventHandler(this.nudKitchens_ValueChanged);
            // 
            // lvShowHousing
            // 
            this.lvShowHousing.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lvShowHousing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader10,
            this.columnHeader7,
            this.columnHeader9});
            this.lvShowHousing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvShowHousing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvShowHousing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShowHousing.FullRowSelect = true;
            this.lvShowHousing.GridLines = true;
            this.lvShowHousing.HideSelection = false;
            this.lvShowHousing.HoverSelection = true;
            this.lvShowHousing.Location = new System.Drawing.Point(0, 0);
            this.lvShowHousing.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.lvShowHousing.MultiSelect = false;
            this.lvShowHousing.Name = "lvShowHousing";
            this.lvShowHousing.ShowItemToolTips = true;
            this.lvShowHousing.Size = new System.Drawing.Size(1103, 690);
            this.lvShowHousing.TabIndex = 39;
            this.lvShowHousing.UseCompatibleStateImageBehavior = false;
            this.lvShowHousing.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Location";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 131;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Level";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "douch";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "salon";
            this.columnHeader5.Width = 68;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "cuisine";
            this.columnHeader6.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Parking";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Etage";
            this.columnHeader10.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            this.columnHeader7.Width = 148;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            this.columnHeader9.Width = 80;
            // 
            // frmRenting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1353, 690);
            this.Controls.Add(this.lvShowHousing);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRenting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenting";
            this.Load += new System.EventHandler(this.frmRenting_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocation;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudPrice;
        private Guna.UI2.WinForms.Guna2CheckBox chbParking;
        private Guna.UI2.WinForms.Guna2CheckBox chbTerasse;
        private Guna.UI2.WinForms.Guna2GradientButton btnSearch;
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
        private System.Windows.Forms.ListView lvShowHousing;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}