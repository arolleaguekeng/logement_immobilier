namespace LogementImobilier.Winform
{
    partial class frmAddHouse
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
            this.label10 = new System.Windows.Forms.Label();
            this.nudShowers = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbbLocation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nudRooms = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.starNotation = new Guna.UI2.WinForms.Guna2RatingStar();
            this.nudExibition = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudKitchen = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tbId = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.chbTerasse = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chbParking = new Guna.UI2.WinForms.Guna2CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.nudLevel = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.btnClosePanel = new Guna.UI2.WinForms.Guna2Button();
            this.lbMessages = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panelMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(508, 73);
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
            this.nudShowers.Location = new System.Drawing.Point(522, 174);
            this.nudShowers.Margin = new System.Windows.Forms.Padding(5);
            this.nudShowers.Name = "nudShowers";
            this.nudShowers.ShadowDecoration.Parent = this.nudShowers;
            this.nudShowers.Size = new System.Drawing.Size(74, 34);
            this.nudShowers.TabIndex = 21;
            this.nudShowers.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudShowers.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // cbbLocation
            // 
            this.cbbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocation.BorderColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.cbbLocation.Location = new System.Drawing.Point(521, 102);
            this.cbbLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbLocation.Name = "cbbLocation";
            this.cbbLocation.ShadowDecoration.Parent = this.cbbLocation;
            this.cbbLocation.Size = new System.Drawing.Size(285, 36);
            this.cbbLocation.TabIndex = 35;
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
            this.nudRooms.Location = new System.Drawing.Point(522, 259);
            this.nudRooms.Margin = new System.Windows.Forms.Padding(5);
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.ShadowDecoration.Parent = this.nudRooms;
            this.nudRooms.Size = new System.Drawing.Size(74, 34);
            this.nudRooms.TabIndex = 16;
            this.nudRooms.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudRooms.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(516, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Roms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(824, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kitchens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(517, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Showers";
            // 
            // starNotation
            // 
            this.starNotation.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.starNotation.Location = new System.Drawing.Point(520, 339);
            this.starNotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.starNotation.Name = "starNotation";
            this.starNotation.RatingColor = System.Drawing.Color.Gold;
            this.starNotation.Size = new System.Drawing.Size(124, 33);
            this.starNotation.TabIndex = 18;
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
            this.nudExibition.Location = new System.Drawing.Point(655, 174);
            this.nudExibition.Margin = new System.Windows.Forms.Padding(5);
            this.nudExibition.Name = "nudExibition";
            this.nudExibition.ShadowDecoration.Parent = this.nudExibition;
            this.nudExibition.Size = new System.Drawing.Size(74, 34);
            this.nudExibition.TabIndex = 29;
            this.nudExibition.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudExibition.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(651, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Exhibition";
            // 
            // nudKitchen
            // 
            this.nudKitchen.BackColor = System.Drawing.Color.Transparent;
            this.nudKitchen.BorderRadius = 8;
            this.nudKitchen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudKitchen.DisabledState.Parent = this.nudKitchen;
            this.nudKitchen.FocusedState.Parent = this.nudKitchen;
            this.nudKitchen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKitchen.ForeColor = System.Drawing.Color.Black;
            this.nudKitchen.Location = new System.Drawing.Point(829, 100);
            this.nudKitchen.Margin = new System.Windows.Forms.Padding(5);
            this.nudKitchen.Name = "nudKitchen";
            this.nudKitchen.ShadowDecoration.Parent = this.nudKitchen;
            this.nudKitchen.Size = new System.Drawing.Size(74, 34);
            this.nudKitchen.TabIndex = 21;
            this.nudKitchen.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudKitchen.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(505, 314);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Notation";
            // 
            // tbId
            // 
            this.tbId.Animated = true;
            this.tbId.BackColor = System.Drawing.Color.Transparent;
            this.tbId.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbId.BorderRadius = 8;
            this.tbId.BorderThickness = 2;
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
            this.tbId.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbId.HoverState.Parent = this.tbId;
            this.tbId.Location = new System.Drawing.Point(38, 100);
            this.tbId.Margin = new System.Windows.Forms.Padding(5);
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.PlaceholderText = "Enter id of Housing";
            this.tbId.SelectedText = "";
            this.tbId.ShadowDecoration.Parent = this.tbId;
            this.tbId.Size = new System.Drawing.Size(282, 33);
            this.tbId.TabIndex = 53;
            // 
            // tbName
            // 
            this.tbName.Animated = true;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbName.BorderRadius = 8;
            this.tbName.BorderThickness = 2;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(38, 160);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "Enter name of Housing";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(282, 33);
            this.tbName.TabIndex = 54;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderRadius = 15;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(772, 447);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.ShadowDecoration.Depth = 5;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Size = new System.Drawing.Size(131, 41);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbTerasse
            // 
            this.chbTerasse.AutoSize = true;
            this.chbTerasse.BackColor = System.Drawing.SystemColors.Control;
            this.chbTerasse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chbTerasse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTerasse.CheckedState.BorderRadius = 0;
            this.chbTerasse.CheckedState.BorderThickness = 0;
            this.chbTerasse.CheckedState.FillColor = System.Drawing.Color.Purple;
            this.chbTerasse.CheckMarkColor = System.Drawing.Color.Purple;
            this.chbTerasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTerasse.Location = new System.Drawing.Point(686, 348);
            this.chbTerasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbTerasse.Name = "chbTerasse";
            this.chbTerasse.Size = new System.Drawing.Size(92, 24);
            this.chbTerasse.TabIndex = 57;
            this.chbTerasse.Text = "Terasse";
            this.chbTerasse.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTerasse.UncheckedState.BorderRadius = 0;
            this.chbTerasse.UncheckedState.BorderThickness = 0;
            this.chbTerasse.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTerasse.UseVisualStyleBackColor = false;
            // 
            // chbParking
            // 
            this.chbParking.AutoSize = true;
            this.chbParking.BackColor = System.Drawing.SystemColors.Control;
            this.chbParking.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chbParking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbParking.CheckedState.BorderRadius = 0;
            this.chbParking.CheckedState.BorderThickness = 0;
            this.chbParking.CheckedState.FillColor = System.Drawing.Color.Purple;
            this.chbParking.CheckMarkColor = System.Drawing.Color.Purple;
            this.chbParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParking.Location = new System.Drawing.Point(817, 348);
            this.chbParking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chbParking.Name = "chbParking";
            this.chbParking.Size = new System.Drawing.Size(87, 24);
            this.chbParking.TabIndex = 58;
            this.chbParking.Text = "Parking";
            this.chbParking.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbParking.UncheckedState.BorderRadius = 0;
            this.chbParking.UncheckedState.BorderThickness = 0;
            this.chbParking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbParking.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Estimation of price : ";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Purple;
            this.lbPrice.Location = new System.Drawing.Point(215, 367);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(111, 32);
            this.lbPrice.TabIndex = 60;
            this.lbPrice.Text = "0 FCFA";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.Transparent;
            this.nudLevel.BorderRadius = 8;
            this.nudLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudLevel.DisabledState.Parent = this.nudLevel;
            this.nudLevel.FocusedState.Parent = this.nudLevel;
            this.nudLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.ForeColor = System.Drawing.Color.Black;
            this.nudLevel.Location = new System.Drawing.Point(658, 259);
            this.nudLevel.Margin = new System.Windows.Forms.Padding(5);
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.ShadowDecoration.Parent = this.nudLevel;
            this.nudLevel.Size = new System.Drawing.Size(74, 34);
            this.nudLevel.TabIndex = 61;
            this.nudLevel.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudLevel.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(652, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 62;
            this.label1.Text = "Levels";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2ShadowPanel1.Controls.Add(this.panelMessage);
            this.guna2ShadowPanel1.Controls.Add(this.tbId);
            this.guna2ShadowPanel1.Controls.Add(this.richTextBox1);
            this.guna2ShadowPanel1.Controls.Add(this.tbName);
            this.guna2ShadowPanel1.Controls.Add(this.chbParking);
            this.guna2ShadowPanel1.Controls.Add(this.nudLevel);
            this.guna2ShadowPanel1.Controls.Add(this.chbTerasse);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.linkLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.starNotation);
            this.guna2ShadowPanel1.Controls.Add(this.label9);
            this.guna2ShadowPanel1.Controls.Add(this.label7);
            this.guna2ShadowPanel1.Controls.Add(this.label10);
            this.guna2ShadowPanel1.Controls.Add(this.btnSave);
            this.guna2ShadowPanel1.Controls.Add(this.cbbLocation);
            this.guna2ShadowPanel1.Controls.Add(this.nudShowers);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.nudRooms);
            this.guna2ShadowPanel1.Controls.Add(this.lbPrice);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.nudExibition);
            this.guna2ShadowPanel1.Controls.Add(this.label8);
            this.guna2ShadowPanel1.Controls.Add(this.label4);
            this.guna2ShadowPanel1.Controls.Add(this.nudKitchen);
            this.guna2ShadowPanel1.Controls.Add(this.label3);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1016, 540);
            this.guna2ShadowPanel1.TabIndex = 63;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.Moccasin;
            this.panelMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMessage.Controls.Add(this.btnClosePanel);
            this.panelMessage.Controls.Add(this.lbMessages);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMessage.Location = new System.Drawing.Point(0, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(1014, 22);
            this.panelMessage.TabIndex = 67;
            this.panelMessage.Visible = false;
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
            this.btnClosePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClosePanel.FillColor = System.Drawing.Color.Transparent;
            this.btnClosePanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanel.ForeColor = System.Drawing.Color.Black;
            this.btnClosePanel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnClosePanel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClosePanel.HoverState.Parent = this.btnClosePanel;
            this.btnClosePanel.Location = new System.Drawing.Point(1000, 0);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.ShadowDecoration.Parent = this.btnClosePanel;
            this.btnClosePanel.Size = new System.Drawing.Size(10, 18);
            this.btnClosePanel.TabIndex = 4;
            this.btnClosePanel.Text = "X";
            // 
            // lbMessages
            // 
            this.lbMessages.AutoSize = true;
            this.lbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessages.ForeColor = System.Drawing.Color.Purple;
            this.lbMessages.Location = new System.Drawing.Point(9, -1);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(79, 20);
            this.lbMessages.TabIndex = 2;
            this.lbMessages.Text = "Welcome";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(38, 240);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 73);
            this.richTextBox1.TabIndex = 66;
            this.richTextBox1.Text = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(574, 404);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(232, 29);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Other caracateristics";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(33, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "Description";
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAddHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 540);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddHouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmAddHouse";
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudShowers;
        private Guna.UI2.WinForms.Guna2ComboBox cbbLocation;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2RatingStar starNotation;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudExibition;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudKitchen;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbId;
        private Guna.UI2.WinForms.Guna2TextBox tbName;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2CheckBox chbTerasse;
        private Guna.UI2.WinForms.Guna2CheckBox chbParking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudLevel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.Panel panelMessage;
        private Guna.UI2.WinForms.Guna2Button btnClosePanel;
        public System.Windows.Forms.Label lbMessages;
        private System.Windows.Forms.Timer timer1;
    }
}