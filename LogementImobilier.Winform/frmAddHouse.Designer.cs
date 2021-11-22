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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
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
            this.panelMessage = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnClosePanel = new Guna.UI2.WinForms.Guna2Button();
            this.lbMessages = new System.Windows.Forms.Label();
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
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudShowers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExibition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKitchen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.label10.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(498, 52);
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
            this.guna2Transition1.SetDecoration(this.nudShowers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nudShowers.DisabledState.Parent = this.nudShowers;
            this.nudShowers.FocusedState.Parent = this.nudShowers;
            this.nudShowers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudShowers.ForeColor = System.Drawing.Color.Black;
            this.nudShowers.Location = new System.Drawing.Point(512, 153);
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
            this.cbbLocation.BorderColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.cbbLocation, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.cbbLocation.Location = new System.Drawing.Point(511, 81);
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
            this.guna2Transition1.SetDecoration(this.nudRooms, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nudRooms.DisabledState.Parent = this.nudRooms;
            this.nudRooms.FocusedState.Parent = this.nudRooms;
            this.nudRooms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudRooms.ForeColor = System.Drawing.Color.Black;
            this.nudRooms.Location = new System.Drawing.Point(512, 238);
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
            this.guna2Transition1.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(506, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Roms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(814, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kitchens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(507, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Showers";
            // 
            // starNotation
            // 
            this.starNotation.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.guna2Transition1.SetDecoration(this.starNotation, Guna.UI2.AnimatorNS.DecorationType.None);
            this.starNotation.Location = new System.Drawing.Point(510, 318);
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
            this.guna2Transition1.SetDecoration(this.nudExibition, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nudExibition.DisabledState.Parent = this.nudExibition;
            this.nudExibition.FocusedState.Parent = this.nudExibition;
            this.nudExibition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudExibition.ForeColor = System.Drawing.Color.Black;
            this.nudExibition.Location = new System.Drawing.Point(645, 153);
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
            this.guna2Transition1.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(641, 119);
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
            this.guna2Transition1.SetDecoration(this.nudKitchen, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nudKitchen.DisabledState.Parent = this.nudKitchen;
            this.nudKitchen.FocusedState.Parent = this.nudKitchen;
            this.nudKitchen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKitchen.ForeColor = System.Drawing.Color.Black;
            this.nudKitchen.Location = new System.Drawing.Point(819, 79);
            this.nudKitchen.Margin = new System.Windows.Forms.Padding(5);
            this.nudKitchen.Name = "nudKitchen";
            this.nudKitchen.ShadowDecoration.Parent = this.nudKitchen;
            this.nudKitchen.Size = new System.Drawing.Size(74, 34);
            this.nudKitchen.TabIndex = 21;
            this.nudKitchen.UpDownButtonFillColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(495, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Notation";
            // 
            // tbId
            // 
            this.tbId.Animated = true;
            this.tbId.BackColor = System.Drawing.Color.Transparent;
            this.tbId.BorderColor = System.Drawing.Color.White;
            this.tbId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbId, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.tbId.Location = new System.Drawing.Point(28, 72);
            this.tbId.Margin = new System.Windows.Forms.Padding(5);
            this.tbId.Name = "tbId";
            this.tbId.PasswordChar = '\0';
            this.tbId.PlaceholderText = "Enter id of Housing";
            this.tbId.SelectedText = "";
            this.tbId.ShadowDecoration.Parent = this.tbId;
            this.tbId.Size = new System.Drawing.Size(282, 40);
            this.tbId.TabIndex = 53;
            // 
            // tbName
            // 
            this.tbName.Animated = true;
            this.tbName.BackColor = System.Drawing.Color.Transparent;
            this.tbName.BorderColor = System.Drawing.Color.White;
            this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2Transition1.SetDecoration(this.tbName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.tbName.DefaultText = "";
            this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.DisabledState.Parent = this.tbName;
            this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbName.FocusedState.Parent = this.tbName;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.HoverState.BorderColor = System.Drawing.Color.Purple;
            this.tbName.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.tbName.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbName.HoverState.Parent = this.tbName;
            this.tbName.Location = new System.Drawing.Point(28, 124);
            this.tbName.Margin = new System.Windows.Forms.Padding(5);
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.PlaceholderText = "Enter name of Housing";
            this.tbName.SelectedText = "";
            this.tbName.ShadowDecoration.Parent = this.tbName;
            this.tbName.Size = new System.Drawing.Size(282, 40);
            this.tbName.TabIndex = 54;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.BorderRadius = 15;
            this.btnSave.BorderThickness = 2;
            this.btnSave.CheckedState.Parent = this.btnSave;
            this.btnSave.CustomImages.Parent = this.btnSave;
            this.guna2Transition1.SetDecoration(this.btnSave, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.DisabledState.Parent = this.btnSave;
            this.btnSave.FillColor = System.Drawing.Color.Transparent;
            this.btnSave.FillColor2 = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSave.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.Parent = this.btnSave;
            this.btnSave.Location = new System.Drawing.Point(762, 426);
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
            this.guna2Transition1.SetDecoration(this.chbTerasse, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chbTerasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTerasse.Location = new System.Drawing.Point(676, 327);
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
            this.guna2Transition1.SetDecoration(this.chbParking, Guna.UI2.AnimatorNS.DecorationType.None);
            this.chbParking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbParking.Location = new System.Drawing.Point(807, 327);
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
            this.guna2Transition1.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "Estimation of price : ";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbPrice, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Purple;
            this.lbPrice.Location = new System.Drawing.Point(459, 484);
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
            this.guna2Transition1.SetDecoration(this.nudLevel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.nudLevel.DisabledState.Parent = this.nudLevel;
            this.nudLevel.FocusedState.Parent = this.nudLevel;
            this.nudLevel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.ForeColor = System.Drawing.Color.Black;
            this.nudLevel.Location = new System.Drawing.Point(648, 238);
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
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(642, 208);
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
            this.guna2ShadowPanel1.Controls.Add(this.guna2ShadowPanel2);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2Transition1.SetDecoration(this.guna2ShadowPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1053, 584);
            this.guna2ShadowPanel1.TabIndex = 63;
            // 
            // panelMessage
            // 
            this.panelMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMessage.Controls.Add(this.pictureBox4);
            this.panelMessage.Controls.Add(this.btnClosePanel);
            this.panelMessage.Controls.Add(this.lbMessages);
            this.guna2Transition1.SetDecoration(this.panelMessage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelMessage.FillColor = System.Drawing.Color.Purple;
            this.panelMessage.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.panelMessage.Location = new System.Drawing.Point(707, 53);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.ShadowDecoration.Parent = this.panelMessage;
            this.panelMessage.Size = new System.Drawing.Size(345, 107);
            this.panelMessage.TabIndex = 73;
            this.panelMessage.Visible = false;
            // 
            // pictureBox4
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::LogementImobilier.Winform.Properties.Resources.notification_26px;
            this.pictureBox4.Location = new System.Drawing.Point(3, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 57);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.Animated = true;
            this.btnClosePanel.CheckedState.Parent = this.btnClosePanel;
            this.btnClosePanel.CustomImages.Parent = this.btnClosePanel;
            this.guna2Transition1.SetDecoration(this.btnClosePanel, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.btnClosePanel.Location = new System.Drawing.Point(307, 0);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.ShadowDecoration.Parent = this.btnClosePanel;
            this.btnClosePanel.Size = new System.Drawing.Size(38, 31);
            this.btnClosePanel.TabIndex = 4;
            this.btnClosePanel.Text = "X";
            // 
            // lbMessages
            // 
            this.lbMessages.AutoSize = true;
            this.lbMessages.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.lbMessages, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessages.ForeColor = System.Drawing.Color.White;
            this.lbMessages.Location = new System.Drawing.Point(61, 26);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(133, 32);
            this.lbMessages.TabIndex = 2;
            this.lbMessages.Text = "Welcome";
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
            this.guna2Transition1.SetDecoration(this.guna2ShadowPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(77, 50);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 233;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(931, 521);
            this.guna2ShadowPanel2.TabIndex = 68;
            // 
            // panelPicture
            // 
            this.panelPicture.AutoScroll = true;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.guna2Transition1.SetDecoration(this.panelPicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelPicture.Location = new System.Drawing.Point(32, 210);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(442, 213);
            this.panelPicture.TabIndex = 76;
            // 
            // lbItems
            // 
            this.lbItems.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lbItems, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItems.Location = new System.Drawing.Point(413, 426);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(50, 20);
            this.lbItems.TabIndex = 60;
            this.lbItems.Text = "items";
            // 
            // btnRemovePicture
            // 
            this.btnRemovePicture.Animated = true;
            this.btnRemovePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnRemovePicture.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePicture.BorderRadius = 15;
            this.btnRemovePicture.BorderThickness = 2;
            this.btnRemovePicture.CheckedState.Parent = this.btnRemovePicture;
            this.btnRemovePicture.CustomImages.Parent = this.btnRemovePicture;
            this.guna2Transition1.SetDecoration(this.btnRemovePicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnRemovePicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemovePicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemovePicture.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemovePicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemovePicture.DisabledState.Parent = this.btnRemovePicture;
            this.btnRemovePicture.FillColor = System.Drawing.Color.Transparent;
            this.btnRemovePicture.FillColor2 = System.Drawing.Color.Transparent;
            this.btnRemovePicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePicture.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePicture.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRemovePicture.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnRemovePicture.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRemovePicture.HoverState.Parent = this.btnRemovePicture;
            this.btnRemovePicture.Location = new System.Drawing.Point(165, 426);
            this.btnRemovePicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemovePicture.Name = "btnRemovePicture";
            this.btnRemovePicture.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemovePicture.ShadowDecoration.Depth = 5;
            this.btnRemovePicture.ShadowDecoration.Parent = this.btnRemovePicture;
            this.btnRemovePicture.Size = new System.Drawing.Size(54, 41);
            this.btnRemovePicture.TabIndex = 75;
            this.btnRemovePicture.Text = "-";
            // 
            // btnAddpicture
            // 
            this.btnAddpicture.Animated = true;
            this.btnAddpicture.BackColor = System.Drawing.Color.Transparent;
            this.btnAddpicture.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddpicture.BorderRadius = 15;
            this.btnAddpicture.BorderThickness = 2;
            this.btnAddpicture.CheckedState.Parent = this.btnAddpicture;
            this.btnAddpicture.CustomImages.Parent = this.btnAddpicture;
            this.guna2Transition1.SetDecoration(this.btnAddpicture, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAddpicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddpicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddpicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddpicture.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddpicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddpicture.DisabledState.Parent = this.btnAddpicture;
            this.btnAddpicture.FillColor = System.Drawing.Color.Transparent;
            this.btnAddpicture.FillColor2 = System.Drawing.Color.Transparent;
            this.btnAddpicture.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddpicture.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddpicture.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAddpicture.HoverState.FillColor2 = System.Drawing.SystemColors.MenuHighlight;
            this.btnAddpicture.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddpicture.HoverState.Parent = this.btnAddpicture;
            this.btnAddpicture.Location = new System.Drawing.Point(95, 426);
            this.btnAddpicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddpicture.Name = "btnAddpicture";
            this.btnAddpicture.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddpicture.ShadowDecoration.Depth = 5;
            this.btnAddpicture.ShadowDecoration.Parent = this.btnAddpicture;
            this.btnAddpicture.Size = new System.Drawing.Size(54, 41);
            this.btnAddpicture.TabIndex = 73;
            this.btnAddpicture.Text = "+";
            this.btnAddpicture.Click += new System.EventHandler(this.btnAddpicture_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.pictureBox2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox2.Location = new System.Drawing.Point(512, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(282, 2);
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // lineName
            // 
            this.lineName.BackColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.lineName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lineName.Location = new System.Drawing.Point(29, 160);
            this.lineName.Name = "lineName";
            this.lineName.Size = new System.Drawing.Size(282, 2);
            this.lineName.TabIndex = 71;
            this.lineName.TabStop = false;
            // 
            // lineId
            // 
            this.lineId.BackColor = System.Drawing.Color.Black;
            this.guna2Transition1.SetDecoration(this.lineId, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lineId.Location = new System.Drawing.Point(27, 109);
            this.lineId.Name = "lineId";
            this.lineId.Size = new System.Drawing.Size(282, 2);
            this.lineId.TabIndex = 70;
            this.lineId.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label6);
            this.guna2Transition1.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 30);
            this.panel1.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(425, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 68;
            this.label6.Text = "ADD";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.linkLabel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(564, 383);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(232, 29);
            this.linkLabel1.TabIndex = 65;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Other caracateristics";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 25);
            this.label9.TabIndex = 64;
            this.label9.Text = "Pictures";
            // 
            // pictureBox1
            // 
            this.guna2Transition1.SetDecoration(this.pictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LogementImobilier.Winform.Properties.Resources.wallpaper_meuble;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1051, 582);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation1;
            this.guna2Transition1.TimeStep = 11F;
            // 
            // frmAddHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 584);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox lineName;
        private System.Windows.Forms.PictureBox lineId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMessage;
        private Guna.UI2.WinForms.Guna2Button btnClosePanel;
        public System.Windows.Forms.Label lbMessages;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemovePicture;
        private Guna.UI2.WinForms.Guna2GradientButton btnAddpicture;
        private System.Windows.Forms.Label lbItems;
        private System.Windows.Forms.FlowLayoutPanel panelPicture;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}