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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddHouse));
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.panelPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.lbItems = new System.Windows.Forms.Label();
            this.btnRemovePicture = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnAddpicture = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lineName = new System.Windows.Forms.PictureBox();
            this.lineId = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineId)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Name = "label10";
            // 
            // nudShowers
            // 
            this.nudShowers.BackColor = System.Drawing.Color.Transparent;
            this.nudShowers.BorderRadius = 8;
            this.nudShowers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudShowers.DisabledState.Parent = this.nudShowers;
            this.nudShowers.FocusedState.Parent = this.nudShowers;
            resources.ApplyResources(this.nudShowers, "nudShowers");
            this.nudShowers.ForeColor = System.Drawing.Color.Black;
            this.nudShowers.Name = "nudShowers";
            this.nudShowers.ShadowDecoration.Parent = this.nudShowers;
            this.nudShowers.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudShowers.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // cbbLocation
            // 
            this.cbbLocation.BackColor = System.Drawing.Color.Transparent;
            this.cbbLocation.BorderColor = System.Drawing.Color.White;
            this.cbbLocation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLocation.FocusedColor = System.Drawing.Color.Purple;
            this.cbbLocation.FocusedState.BorderColor = System.Drawing.Color.Purple;
            this.cbbLocation.FocusedState.Parent = this.cbbLocation;
            resources.ApplyResources(this.cbbLocation, "cbbLocation");
            this.cbbLocation.ForeColor = System.Drawing.Color.Black;
            this.cbbLocation.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.cbbLocation.HoverState.Parent = this.cbbLocation;
            this.cbbLocation.Items.AddRange(new object[] {
            resources.GetString("cbbLocation.Items"),
            resources.GetString("cbbLocation.Items1"),
            resources.GetString("cbbLocation.Items2"),
            resources.GetString("cbbLocation.Items3"),
            resources.GetString("cbbLocation.Items4"),
            resources.GetString("cbbLocation.Items5"),
            resources.GetString("cbbLocation.Items6"),
            resources.GetString("cbbLocation.Items7")});
            this.cbbLocation.ItemsAppearance.Parent = this.cbbLocation;
            this.cbbLocation.ItemsAppearance.SelectedBackColor = System.Drawing.Color.Purple;
            this.cbbLocation.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbbLocation.Name = "cbbLocation";
            this.cbbLocation.ShadowDecoration.Parent = this.cbbLocation;
            // 
            // nudRooms
            // 
            this.nudRooms.BackColor = System.Drawing.Color.Transparent;
            this.nudRooms.BorderRadius = 8;
            this.nudRooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudRooms.DisabledState.Parent = this.nudRooms;
            this.nudRooms.FocusedState.Parent = this.nudRooms;
            resources.ApplyResources(this.nudRooms, "nudRooms");
            this.nudRooms.ForeColor = System.Drawing.Color.Black;
            this.nudRooms.Name = "nudRooms";
            this.nudRooms.ShadowDecoration.Parent = this.nudRooms;
            this.nudRooms.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudRooms.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Name = "label4";
            // 
            // starNotation
            // 
            this.starNotation.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            resources.ApplyResources(this.starNotation, "starNotation");
            this.starNotation.Name = "starNotation";
            this.starNotation.RatingColor = System.Drawing.Color.Gold;
            // 
            // nudExibition
            // 
            this.nudExibition.BackColor = System.Drawing.Color.Transparent;
            this.nudExibition.BorderRadius = 8;
            this.nudExibition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudExibition.DisabledState.Parent = this.nudExibition;
            this.nudExibition.FocusedState.Parent = this.nudExibition;
            resources.ApplyResources(this.nudExibition, "nudExibition");
            this.nudExibition.ForeColor = System.Drawing.Color.Black;
            this.nudExibition.Name = "nudExibition";
            this.nudExibition.ShadowDecoration.Parent = this.nudExibition;
            this.nudExibition.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudExibition.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Name = "label8";
            // 
            // nudKitchen
            // 
            this.nudKitchen.BackColor = System.Drawing.Color.Transparent;
            this.nudKitchen.BorderRadius = 8;
            this.nudKitchen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudKitchen.DisabledState.Parent = this.nudKitchen;
            this.nudKitchen.FocusedState.Parent = this.nudKitchen;
            resources.ApplyResources(this.nudKitchen, "nudKitchen");
            this.nudKitchen.ForeColor = System.Drawing.Color.Black;
            this.nudKitchen.Name = "nudKitchen";
            this.nudKitchen.ShadowDecoration.Parent = this.nudKitchen;
            this.nudKitchen.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Name = "label7";
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
            resources.ApplyResources(this.tbId, "tbId");
            this.tbId.ForeColor = System.Drawing.Color.Black;
            this.tbId.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbId.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbId.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbId.HoverState.Parent = this.tbId;
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.PlaceholderText = "Entrez le Id de la maison";
            this.tbId.SelectedText = "";
            this.tbId.ShadowDecoration.Parent = this.tbId;
            // 
            // tbName
            // 
            this.tbName.Animated = true;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderColor = System.Drawing.Color.White;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbName.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbName.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "Entrez le nom de la maison ";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.FillColor2 = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSave.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.ShadowDecoration.Depth = 5;
            this.btnSave.ShadowDecoration.Parent = this.btnSave;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chbTerasse
            // 
            resources.ApplyResources(this.chbTerasse, "chbTerasse");
            this.chbTerasse.BackColor = System.Drawing.SystemColors.Control;
            this.chbTerasse.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chbTerasse.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbTerasse.CheckedState.BorderRadius = 0;
            this.chbTerasse.CheckedState.BorderThickness = 0;
            this.chbTerasse.CheckedState.FillColor = System.Drawing.Color.Purple;
            this.chbTerasse.CheckMarkColor = System.Drawing.Color.Purple;
            this.chbTerasse.Name = "chbTerasse";
            this.chbTerasse.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTerasse.UncheckedState.BorderRadius = 0;
            this.chbTerasse.UncheckedState.BorderThickness = 0;
            this.chbTerasse.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbTerasse.UseVisualStyleBackColor = false;
            // 
            // chbParking
            // 
            resources.ApplyResources(this.chbParking, "chbParking");
            this.chbParking.BackColor = System.Drawing.SystemColors.Control;
            this.chbParking.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chbParking.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbParking.CheckedState.BorderRadius = 0;
            this.chbParking.CheckedState.BorderThickness = 0;
            this.chbParking.CheckedState.FillColor = System.Drawing.Color.Purple;
            this.chbParking.CheckMarkColor = System.Drawing.Color.Purple;
            this.chbParking.Name = "chbParking";
            this.chbParking.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbParking.UncheckedState.BorderRadius = 0;
            this.chbParking.UncheckedState.BorderThickness = 0;
            this.chbParking.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbParking.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbPrice
            // 
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.ForeColor = System.Drawing.Color.Purple;
            this.lbPrice.Name = "lbPrice";
            // 
            // nudLevel
            // 
            this.nudLevel.BackColor = System.Drawing.Color.Transparent;
            this.nudLevel.BorderRadius = 8;
            this.nudLevel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudLevel.DisabledState.Parent = this.nudLevel;
            this.nudLevel.FocusedState.Parent = this.nudLevel;
            resources.ApplyResources(this.nudLevel, "nudLevel");
            this.nudLevel.ForeColor = System.Drawing.Color.Black;
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.ShadowDecoration.Parent = this.nudLevel;
            this.nudLevel.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.nudLevel.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2ShadowPanel1.Controls.Add(this.guna2ShadowPanel2);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.guna2ShadowPanel1, "guna2ShadowPanel1");
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.panelPicture);
            this.guna2ShadowPanel2.Controls.Add(this.lbItems);
            this.guna2ShadowPanel2.Controls.Add(this.btnRemovePicture);
            this.guna2ShadowPanel2.Controls.Add(this.btnAddpicture);
            this.guna2ShadowPanel2.Controls.Add(this.pictureBox2);
            this.guna2ShadowPanel2.Controls.Add(this.lineName);
            this.guna2ShadowPanel2.Controls.Add(this.lineId);
            this.guna2ShadowPanel2.Controls.Add(this.panel1);
            this.guna2ShadowPanel2.Controls.Add(this.nudRooms);
            this.guna2ShadowPanel2.Controls.Add(this.tbId);
            this.guna2ShadowPanel2.Controls.Add(this.label3);
            this.guna2ShadowPanel2.Controls.Add(this.nudKitchen);
            this.guna2ShadowPanel2.Controls.Add(this.tbName);
            this.guna2ShadowPanel2.Controls.Add(this.label4);
            this.guna2ShadowPanel2.Controls.Add(this.chbParking);
            this.guna2ShadowPanel2.Controls.Add(this.label8);
            this.guna2ShadowPanel2.Controls.Add(this.nudLevel);
            this.guna2ShadowPanel2.Controls.Add(this.nudExibition);
            this.guna2ShadowPanel2.Controls.Add(this.chbTerasse);
            this.guna2ShadowPanel2.Controls.Add(this.label2);
            this.guna2ShadowPanel2.Controls.Add(this.label1);
            this.guna2ShadowPanel2.Controls.Add(this.lbPrice);
            this.guna2ShadowPanel2.Controls.Add(this.linkLabel1);
            this.guna2ShadowPanel2.Controls.Add(this.label5);
            this.guna2ShadowPanel2.Controls.Add(this.starNotation);
            this.guna2ShadowPanel2.Controls.Add(this.nudShowers);
            this.guna2ShadowPanel2.Controls.Add(this.label9);
            this.guna2ShadowPanel2.Controls.Add(this.cbbLocation);
            this.guna2ShadowPanel2.Controls.Add(this.label7);
            this.guna2ShadowPanel2.Controls.Add(this.btnSave);
            this.guna2ShadowPanel2.Controls.Add(this.label10);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            resources.ApplyResources(this.guna2ShadowPanel2, "guna2ShadowPanel2");
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 233;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            // 
            // panelPicture
            // 
            resources.ApplyResources(this.panelPicture, "panelPicture");
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Name = "panelPicture";
            // 
            // lbItems
            // 
            resources.ApplyResources(this.lbItems, "lbItems");
            this.lbItems.Name = "lbItems";
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Animated = true;
            this.btnRemovePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePicture.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePicture.BorderRadius = 15;
            this.btnRemovePicture.BorderThickness = 2;
            this.btnRemovePicture.CheckedState.Parent = this.btnRemovePicture;
            this.btnRemovePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemovePicture.CustomImages.Parent = this.btnRemovePicture;
            this.btnRemovePicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemovePicture.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemovePicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemovePicture.DisabledState.Parent = this.btnRemovePicture;
            this.btnRemovePicture.FillColor = System.Drawing.Color.Transparent;
            this.btnRemovePicture.FillColor2 = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnRemovePicture, "btnRemovePicture");
            this.btnRemovePicture.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePicture.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRemovePicture.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePicture.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemovePicture.HoverState.Parent = this.btnRemovePicture;
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemovePicture.ShadowDecoration.Depth = 5;
            this.btnRemovePicture.ShadowDecoration.Parent = this.btnRemovePicture;
            // 
            // btnAddpicture
            // 
            this.btnAddpicture.Animated = true;
            this.btnAddpicture.BackColor = System.Drawing.Color.Transparent;
            this.btnAddpicture.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddpicture.BorderRadius = 15;
            this.btnAddpicture.BorderThickness = 2;
            this.btnAddpicture.CheckedState.Parent = this.btnAddpicture;
            this.btnAddpicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddpicture.CustomImages.Parent = this.btnAddpicture;
            this.btnAddpicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddpicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddpicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddpicture.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddpicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddpicture.DisabledState.Parent = this.btnAddpicture;
            this.btnAddpicture.FillColor = System.Drawing.Color.Transparent;
            this.btnAddpicture.FillColor2 = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAddpicture, "btnAddpicture");
            this.btnAddpicture.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddpicture.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddpicture.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddpicture.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddpicture.HoverState.Parent = this.btnAddpicture;
            this.btnAddpicture.Name = "btnAddpicture";
            this.btnAddpicture.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddpicture.ShadowDecoration.Depth = 5;
            this.btnAddpicture.ShadowDecoration.Parent = this.btnAddpicture;
            this.btnAddpicture.Click += new System.EventHandler(this.btnAddpicture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // lineName
            // 
            this.lineName.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lineName, "lineName");
            this.lineName.Name = "lineName";
            this.lineName.TabStop = false;
            // 
            // lineId
            // 
            this.lineId.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lineId, "lineId");
            this.lineId.Name = "lineId";
            this.lineId.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label6);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Name = "label9";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAddHouse
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineId)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lineName;
        private System.Windows.Forms.PictureBox lineId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemovePicture;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddpicture;
        private System.Windows.Forms.Label lbItems;
        private System.Windows.Forms.FlowLayoutPanel panelPicture;
    }
}